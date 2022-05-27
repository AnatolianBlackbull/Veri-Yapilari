using System;
using System.Collections.Generic;
using System.Text;

namespace Bil204_Ödev_2_3
{
    public class Agac
    {
        public AgacNode[] HeapDizi;
        private int MaxBoyut;
        private int Boyut;

        public Agac(int maxBoy)
        {
            MaxBoyut = maxBoy;
            Boyut = 0;
            HeapDizi = new AgacNode[MaxBoyut];
        }

        public bool IsEmpty()
        {
            return Boyut == 0;
        }

        public bool Insert(string str)
        {
            if (Boyut == MaxBoyut)
            {
                return false;
            }

            AgacNode newHeapDugumu = new AgacNode(str);
            HeapDizi[Boyut] = newHeapDugumu;
            YukariTasi(Boyut++);
            return true;
        }

        public void YukariTasi(int index)
        {
            int parent = (index - 1) / 2;
            AgacNode bottom = HeapDizi[index];
            while (index > 0 && HeapDizi[parent].KullanimSayi < bottom.KullanimSayi)
            {
                HeapDizi[index] = HeapDizi[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            HeapDizi[index] = bottom;
        }
    }
}
