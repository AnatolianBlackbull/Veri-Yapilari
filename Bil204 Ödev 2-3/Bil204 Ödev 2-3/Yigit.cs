using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bil204_Ödev_2_3
{
    public class Yigit
    {
        public YigitEleman Head { get; private set; }
        public int Boyut { get; private set; }
        public int ToplamSozcuk { get; private set; }
        public int OrtalamaSozcuk { get; private set; }

        // Adresi verilen dosyayı açıp yığıta çevirir.
        public void DosyadanCek(string str)
        {
            string[] c;
            Boyut = 0; ToplamSozcuk = 0;
            using (FileStream a = File.Open(str, FileMode.Open))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                c = temp.GetString(b).Split('\n');
                a.Close();
            }

            foreach (string i in c)
            {
                Insert(i.ToLower());
                Boyut++;
            }

            OrtalamaSozcuk = Boyut / ToplamSozcuk;
        }

        // Yığıttaki sözcüklerden heap ağacı üretir.
        public Agac AgacaCevir()
        {
            YigitEleman tmp = Head;
            Agac agc = new Agac(ToplamSozcuk);
            bool eklendi = false;
            int sayac = 0, eklenenSayisi = 0;
            
            while(tmp != null)
            {
                for (int i = 0; i < tmp.Sozcukler.Length; i++)
                {
                    for (int j = 0; j < agc.HeapDizi.Length; j++)
                    {
                        if (tmp.Sozcukler[i] == agc.HeapDizi[j].Sozcuk)
                        {
                            agc.HeapDizi[j].KullanimSayi++;
                            agc.HeapDizi[j].Konumlar.Add(sayac + ". Cümle, " + i + ". Sözcük");
                            eklendi = true;
                            agc.YukariTasi(j); // Kullanım sayısı arttığı için yeniden sıralanır.
                            break;
                        }
                    }
                    if (!eklendi)
                    {
                        agc.Insert(tmp.Sozcukler[i]);
                        agc.HeapDizi[eklenenSayisi].Konumlar.Add(sayac + ". Cümle, " + i + ". Sözcük");
                        eklenenSayisi++;
                    }
                    eklendi = false;
                }

                tmp = tmp.Next;
                sayac++;
            }

            return agc;
        }

        // Verilen cümleyi yığıta ekler.
        private void Insert(string str)
        {
            YigitEleman tmp = Head;

            if (tmp == null)
            {
                Head = new YigitEleman(str);
            }
            else
            {
                tmp = new YigitEleman(str);
                tmp.Next = Head;
                Head = tmp;
            }

            ToplamSozcuk += Head.SozukSayi;
        }
    }
}
