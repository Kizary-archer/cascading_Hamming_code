﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamming
{
    public class encode
    {

        public encode()
        {
           
        }

        public List<int> En_code (List<int> conversion_end)
        //public List<int> En_code()
        {
            List<int> encode_end = new List<int>();
            int conBit = -1;
            List<int> mes = new List<int> { 0, 1, 0, 1 };
            List<int> encode_mes = new List<int>();

            int j = 0;

            encode_mes = mes;

            for (int i = 1; i < mes.Capacity; j++, i = (int)Math.Pow(2, j))
            {

                encode_mes.Insert(i-1,0);
                conBit++;
            }
            
            int cbit = 0;
            
            while(conBit >= 0)
            {
                int pb = (int)Math.Pow(2, conBit);
                for (int i = pb; i <= encode_mes.Capacity; i += pb)
                    for (int p = 1; p <= pb; p++, i++)
                    {
                        cbit += encode_mes[i-1];
                    }
                conBit--;
                encode_mes[pb - 1] = cbit % 2;
                cbit = 0;
            }
            return encode_end;
        }
        
    }
}


