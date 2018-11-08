using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._2
{
    public class HeapSort:SortBase
    {

        public override void Sort(int[] items)
        {
            int temp;
            for (int i = ((items.Length / 2) - 1); i >= 0; i-- )
            {


            }
                for (int i = items.Length - 1; i >= 0; i--)
                {
                    temp = items[0];
                    items[0] = items[i];
                    items[i] = temp;
                    yigin(0, i - 1, items);
                }

        }

        public void yigin(int root, int node, int[] items)
        {
            bool bitis = false;
            int dugum, temp;

            while ((root * 2 <= node) && (!bitis))
            {
                if (root * 2 == node)
                    dugum = root * 2;
                else if (items[root * 2] > items[root * 2 + 1])
                    dugum = root * 2;
                else
                    dugum = root * 2 + 1;

                if (items[root] < items[dugum])
                {
                    temp = items[root];
                    items[root] = items[dugum];
                    items[dugum] = temp;
                    root = dugum;
                }
                else
                {
                    bitis = true;
                }
            }
        }
    }
}
