using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2._2
{
    public partial class frmSorting : Form
    {
        public frmSorting()
        {
            InitializeComponent();
        }
        int[] dizi = new int[100];
        int[] dizi2 = new int[750];
        int[] dizi3 = new int[1500];
        int[] dizi4 = new int[7500];
        int[] dizi5 = new int[15000];
        int[] dizi6 = new int[75000];
        int[] dizi7 = new int[150000];
        public void RandomDataGenerator()
        {
            Random r = new Random();
            //diziler için rastgele sayılar ürettik
            
            for (int i = 0; i < 100; i++)
            {
                dizi[i] = r.Next();
            }
            for (int i = 0; i < 750; i++)
            {
                dizi2[i] = r.Next();
            }
            for (int i = 0; i < 1500; i++)
            {
                dizi3[i] = r.Next();
            }
            for (int i = 0; i < 7500; i++)
            {
                dizi4[i] = r.Next();
            }
            for (int i = 0; i < 15000; i++)
            {
                dizi5[i] = r.Next();
            }
            for (int i = 0; i < 75000; i++)
            {
                dizi6[i] = r.Next();
            }
            for (int i = 0; i < 150000; i++)
            {
                dizi7[i] = r.Next();
            }
        }

        

        
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {   //Execure time'ı hesapladık
            BubbleSort bs = new BubbleSort();
            string sure = "";
            DateTime baslangic = DateTime.Now;
            bs.Sort(dizi);  //Algoritmaya parametre gönderdik
            TimeSpan ts =DateTime.Now.Subtract(baslangic);
            sure +="100-->"+ ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            bs.Sort(dizi2);
            ts = DateTime.Now.Subtract(baslangic);
            sure +="750-->" + ts.Milliseconds.ToString()+Environment.NewLine;

            baslangic = DateTime.Now;
            bs.Sort(dizi3);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "1500-->"+ts.Milliseconds.ToString()+Environment.NewLine;

            baslangic = DateTime.Now;
            bs.Sort(dizi4);
            ts = DateTime.Now.Subtract(baslangic);
            sure +="7500-->"+ ts.Milliseconds.ToString()+Environment.NewLine;

            baslangic = DateTime.Now;
            bs.Sort(dizi5);
            ts = DateTime.Now.Subtract(baslangic);
            sure +="15000-->"+ ts.Milliseconds.ToString()+Environment.NewLine;

            baslangic = DateTime.Now;
            bs.Sort(dizi6);
            ts = DateTime.Now.Subtract(baslangic);
            sure +="75000-->"+ ts.Milliseconds.ToString()+Environment.NewLine;

            baslangic = DateTime.Now;
            bs.Sort(dizi7);
            ts = DateTime.Now.Subtract(baslangic);
            sure +="150000-->"+ ts.Milliseconds.ToString()+Environment.NewLine;

            MessageBox.Show("Bubble Sort;"+Environment.NewLine+Environment.NewLine+sure.ToString());
            
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            SelectionSort ss = new SelectionSort();
            string sure = "";
            DateTime baslangic = DateTime.Now;
            ss.Sort(dizi);
            TimeSpan ts = DateTime.Now.Subtract(baslangic);
            sure += "100-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            ss.Sort(dizi2);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "750-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            ss.Sort(dizi3);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "1500-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            ss.Sort(dizi4);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "7500-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            ss.Sort(dizi5);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "15000-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            ss.Sort(dizi6);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "75000-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            ss.Sort(dizi7);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "150000-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            MessageBox.Show("Selection Sort;"+Environment.NewLine+Environment.NewLine+sure.ToString());
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomDataGenerator();
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            QuickSort qs = new QuickSort();
            string sure = "";
            DateTime baslangic = DateTime.Now;
            qs.Sort(dizi);
            TimeSpan ts = DateTime.Now.Subtract(baslangic);
            sure += "100-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            qs.Sort(dizi2);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "750-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            qs.Sort(dizi3);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "1500-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            qs.Sort(dizi4);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "7500-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            qs.Sort(dizi5);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "15000-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            qs.Sort(dizi6);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "75000-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            qs.Sort(dizi7);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "150000-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            MessageBox.Show("Quick Sort;"+Environment.NewLine+Environment.NewLine+sure.ToString());
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            InsertionSort Is=new InsertionSort();
            string sure = "";
            DateTime baslangic = DateTime.Now;
            Is.Sort(dizi);
            TimeSpan ts = DateTime.Now.Subtract(baslangic);
            sure += "100-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            Is.Sort(dizi2);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "750-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            Is.Sort(dizi3);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "1500-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            Is.Sort(dizi4);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "7500-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            Is.Sort(dizi5);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "15000-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            Is.Sort(dizi6);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "75000-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            Is.Sort(dizi7);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "150000-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            MessageBox.Show("Insertion Sort;"+Environment.NewLine+Environment.NewLine+sure.ToString());
        }

        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            HeapSort hs = new HeapSort();
            string sure = "";
            DateTime baslangic = DateTime.Now;
            hs.Sort(dizi);
            TimeSpan ts = DateTime.Now.Subtract(baslangic);
            sure += "100-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            hs.Sort(dizi2);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "750-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            hs.Sort(dizi3);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "1500-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            hs.Sort(dizi4);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "7500-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            hs.Sort(dizi5);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "15000-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            hs.Sort(dizi6);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "75000-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            baslangic = DateTime.Now;
            hs.Sort(dizi7);
            ts = DateTime.Now.Subtract(baslangic);
            sure += "150000-->" + ts.Milliseconds.ToString() + Environment.NewLine;

            MessageBox.Show("Heap Sort;" + Environment.NewLine+Environment.NewLine + sure.ToString());
        }
    }
}
