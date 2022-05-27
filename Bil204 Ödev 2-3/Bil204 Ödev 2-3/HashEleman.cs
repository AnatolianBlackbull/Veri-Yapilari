using System;
using System.Collections.Generic;
using System.Text;

namespace Bil204_Ödev_2_3
{
    public class HashEleman
    {
        public string Sozcuk;
        public int Anahtar { get; private set; }

        public HashEleman(string str, int anh)
        {
            Sozcuk = str;
            Anahtar = anh;
        }
    }
}
