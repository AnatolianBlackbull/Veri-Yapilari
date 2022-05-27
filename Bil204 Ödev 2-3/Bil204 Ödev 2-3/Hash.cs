using System;
using System.Collections.Generic;
using System.Text;

namespace Bil204_Ödev_2_3
{
    public class Hash
    {
        public HashEleman[] Dizi;

        public Hash(Agac agc)
        {
            Dizi = new HashEleman[agc.HeapDizi.Length];

            foreach (AgacNode i in agc.HeapDizi)
            {
                Insert(i);
            }
        }

        private void Insert(AgacNode agcnd)
        {
            int mod = agcnd.KullanimSayi % Dizi.Length;

            if (Dizi[mod] == null)
            {
                Dizi[mod] = new HashEleman(agcnd.Sozcuk, agcnd.KullanimSayi / Dizi.Length);
            }
            else
            {
                while (Dizi[mod] != null)
                {
                    mod++;
                }

                Dizi[mod] = new HashEleman(agcnd.Sozcuk, agcnd.KullanimSayi / Dizi.Length);
            }
        }
    }
}
