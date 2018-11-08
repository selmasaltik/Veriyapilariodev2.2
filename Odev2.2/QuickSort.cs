﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._2
{
    public class QuickSort:SortBase
    {
        public override void Sort(int[] items)
        {
            quickSort(items, 0, items.Length - 1);
        }

        public void quickSort(int[] items, int altindis, int ustindis)
        {
            // altindis o adımda sıralanan altdizinin ek küçük indisidir
            // üstindis o adımda sıralanan altdizinin ek büyük indisidir
            int yeni_altindis = altindis, yeni_ustindis = ustindis, h;

            // pivot
            int pivot = items[(altindis + ustindis) / 2];

            // Takas ile diziyi ayrıştırma
            do
            {
                while (items[yeni_altindis] < pivot)
                    yeni_altindis++;

                while (items[yeni_ustindis] > pivot)
                    yeni_ustindis--;

                if (yeni_altindis <= yeni_ustindis)
                {
                    h = items[yeni_altindis];
                    items[yeni_altindis] = items[yeni_ustindis];
                    items[yeni_ustindis] = h;
                    yeni_altindis++;
                    yeni_ustindis--;
                }
            } while (yeni_altindis <= yeni_ustindis);

            // recursion
            if (altindis < yeni_ustindis)
                quickSort(items, altindis, yeni_ustindis);

            if (yeni_altindis < ustindis)
                quickSort(items, yeni_altindis, ustindis);
        } 
    }
}
