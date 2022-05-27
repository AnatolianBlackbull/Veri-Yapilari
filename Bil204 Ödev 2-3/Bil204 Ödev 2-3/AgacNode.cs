using System;
using System.Collections.Generic;
using System.Text;

namespace Bil204_Ödev_2_3
{
    public class AgacNode
    {
        public string Sozcuk;
        public int KullanimSayi;
        public List<string> Konumlar = new List<string>();

        public AgacNode(string str)
        {
            Sozcuk = str;
            KullanimSayi = 1;
        }
    }
}
