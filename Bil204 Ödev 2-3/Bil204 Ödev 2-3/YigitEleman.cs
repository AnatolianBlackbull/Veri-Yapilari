using System;
using System.Collections.Generic;
using System.Text;

namespace Bil204_Ödev_2_3
{
    public class YigitEleman
    {
        public string Cumle;
        public int SozukSayi = 0;
        public string[] Sozcukler;
        public YigitEleman Next;

        public YigitEleman(string str)
        {
            Cumle = str;

            string[] r = { ".", ",", ";", ":", "?", "!", "(", ")", "-", "/"};

            foreach (string j in r) // Noktalama işaretlerini cümleden atar.
            {
                Cumle = Cumle.Replace(j, "");
            }

            Sozcukler = Cumle.Split(' '); // Cümledeki sözcükleri ayırır.
            SozukSayi = Sozcukler.Length;
        }
    }
}
