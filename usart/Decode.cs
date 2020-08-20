﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace usart
{
    enum state:UInt16
    {
        HEADER=0,
        pkg_len=1,
        switch_type=2,
        chksum=3,

        ar_type=10,
        ar_num=11,
        ar_dat_len=12,
        ar_dat=13,

        mt_type=20,
        mt_numy=21,
        mt_numx=22,
        mt_dat_len=23,
        mt_dat=24,

        st_fs_len=30,
        st_fs=31,
        st_dat_len=32,
        st_dat=33
    }
    public class Decode
    {
        bool extraDecode=false;
        state decodeState = state.HEADER;
        UInt16 count = 0;
        UInt16 paclen = 0;
        UInt16 type = 0;
        UInt16 chksum = 0;
        UInt16 pkg_type = 0;

        UInt16 ar_type = 0;
        UInt16 ar_num = 0;
        UInt16 ar_dlen = 0;
        byte[] ar_dat;

        UInt16 mt_type = 0;
        UInt16 mt_numy = 0;
        UInt16 mt_numx = 0;
        UInt16 mt_dlen = 0;
        byte[] mt_dat;

        UInt16 st_fs_len = 0;
        byte[] st_fs;
        UInt16 st_dlen = 0;
        byte[] st_dat;

        Dictionary<string, string> data = null;
        public void put(byte buff)
        {
            if (extraDecode)
            {
                switch (decodeState)
                {
                    case state.HEADER:
                        if (buff == (byte)0xAC)
                        {
                            count++;
                            if (count == 3)
                            {
                                decodeState = state.pkg_len;
                                count = 0;
                            }
                        }
                        break;
                    case state.pkg_len:
                        if (count == 0)
                        {
                            paclen = (UInt16)(buff << 8);
                            count++;
                        }
                        else
                        {
                            paclen+=(UInt16)(buff&0xff);
                            count = 0;
                            decodeState = state.switch_type;
                        }
                        break;
                    case state.switch_type:
                        chksum += buff;
                        pkg_type = buff;
                        if (buff == 1)
                        {
                            decodeState = state.ar_type;
                        }
                        else if (buff == 2)
                        {
                            decodeState = state.mt_type;
                        }
                        else if (buff == 3)
                            decodeState = state.st_fs_len;
                        break;
                    case state.ar_type:
                        chksum += buff;
                        ar_type = buff;
                        decodeState = state.ar_num;
                        break;
                    case state.ar_num:
                        chksum += buff;
                        ar_num = buff;
                        decodeState = state.ar_dat_len;
                        break;
                    case state.ar_dat_len:
                        chksum += buff;
                        if (count == 0)
                        {
                            ar_dlen = (UInt16)(buff << 8);
                            count++;
                        }
                        else
                        {
                            ar_dlen += buff;
                            count = 0;
                            ar_dat = new byte[ar_dlen];
                            decodeState = state.ar_dat;
                        }
                        break;
                    case state.ar_dat:
                        chksum += buff;
                        ar_dat[count] = buff;
                        count++;
                        if (count == ar_dlen)
                        {
                            count = 0;
                            decodeState = state.chksum;
                        }
                        break;

                    case state.mt_type:
                        chksum += buff;
                        mt_type = buff;
                        decodeState = state.mt_numy;
                        break;
                    case state.mt_numy:
                        chksum += buff;
                        mt_numy = buff;
                        decodeState = state.mt_numx;
                        break;
                    case state.mt_numx:
                        chksum += buff;
                        mt_numx = buff;
                        decodeState = state.mt_dat_len;
                        break;
                    case state.mt_dat_len:
                        chksum += buff;
                        if (count == 0)
                        {
                            mt_dlen = (UInt16)(buff << 8);
                            count = 1;
                        }
                        else
                        {
                            mt_dlen += buff;
                            count=0;
                            mt_dat = new byte[mt_dlen];
                            decodeState = state.mt_dat;
                        }
                        break;
                    case state.mt_dat:
                        chksum += buff;

                        mt_dat[count] = buff;
                        count++;
                        if(count==mt_dlen)
                        {
                            count = 0;
                            decodeState = state.chksum;
                        }
                        break;

                    case state.st_fs_len:
                        chksum += buff;
                        st_fs_len = buff;
                        st_fs = new byte[st_fs_len];
                        decodeState = state.st_fs;
                        break;
                    case state.st_fs:
                        chksum += buff;
                        st_fs[count] = buff;
                        count++;
                        if(count==st_fs_len)
                        {
                            count = 0;
                            decodeState = state.st_dat_len;
                        }
                        break;
                    case state.st_dat_len:
                        chksum += buff;
                        if (count == 0)
                        {
                            st_dlen = (UInt16)(buff << 8);
                            count = 1;
                        }
                        else
                        {
                            count = 0;
                            st_dlen += buff;
                            st_dat = new byte[st_dlen];
                            decodeState = state.st_dat;
                        }
                        break;
                    case state.st_dat:
                        chksum += buff;
                        st_dat[count] = buff;
                        count++;
                        if(count==st_dlen)
                        {
                            count = 0;
                            decodeState = state.chksum;
                        }
                        break;

                    case state.chksum:
                        decodeState = state.HEADER;
                        chksum = 0;
                        if ((chksum&0xFF)==buff)
                        {
                            storeData();
                        }
                        break;
                }
                
            }
            else
            {
                if (buff == (byte)0xAC)
                {
                    
                    extraDecode = true;
                    count++;
                    
                }
                
            }
        }
        private void storeData()
        {
            data = new Dictionary<string, string>();
            if(pkg_type==1)
            {
                data.Add("type","ty");
            }
        }
    }
}