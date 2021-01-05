using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenApp
{
    public partial class Form1 : Form
    {
        string[] populacja = new string[5];
        double[] ocena = new double[5];
        int nrpop = 0;
        string bestpop = "";
        double bestocena = -100000;

        Random rnd;

        // -2* x^3/3+8* x^2-5
        public double calculateYFromEquation (double x) {
            return -2 * Math.Pow(x, 3) / 3 + 8 * Math.Pow(x, 2) - 5;
        }

       
        public double chromosomeToNumber(string chromosome) {
            double result = 0;
            int pow = 2;
            for (int place = 1; place < chromosome.Length; place++) {
                result += Math.Pow(2, pow) * int.Parse(chromosome[place].ToString());
                pow -= 1;
            }

            return (int.Parse(chromosome[0].ToString()) == 0 ? -1 : 1)  * result;
        }

        public double ocen(string str)
        {
            return this.calculateYFromEquation(this.chromosomeToNumber(str));
        }

        public string losuj()
        {
            string str = "";
            for (int i = 0; i < 11; i++)
            {
                int l = rnd.Next(0, 1000);
                if (l >= 500) str = str + "1";
                else str = str + "0";
            }
            return str;
        }

        public void PopInit()
        {
            for (int i = 0; i < 5; i++)
            {
                populacja[i] = losuj();
                ocena[i] = ocen(populacja[i]);
            }
            nrpop = 0;
        }

        public void pokazPopulacje()
        {
            pop1.Text = populacja[0];
            pop2.Text = populacja[1];
            pop3.Text = populacja[2];
            pop4.Text = populacja[3];
            pop5.Text = populacja[4];
            best.Text = bestpop;

            val1.Text = ocena[0].ToString();
            val2.Text = ocena[1].ToString();
            val3.Text = ocena[2].ToString();
            val4.Text = ocena[3].ToString();
            val5.Text = ocena[4].ToString();
            bestVal.Text = bestocena.ToString();
            label4.Text = "Nr pop = " + nrpop.ToString();

            // Obliczenie œredniej dla populacji
            double average = ocena[0];
            for (int i = 1; i < 5; i++)
            {
                average += ocena[i];
            }
            average = average / 5;
            averageVal.Text = average.ToString();
        }
        
        public Form1()
        {
            DateTime dt = DateTime.Now;
            rnd = new Random(dt.Second);

           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopInit();
            pokazPopulacje();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopInit();
            pokazPopulacje();
  
        }

        // funkcja dokonuje mutacji losowego bitu osobnika 
        private string mutacja(string str)
        {
            string sout = str;
            int i = rnd.Next(1, 11);
            int x = rnd.Next(0, 1000);
            if(x<500)
                sout = sout.Substring(0, i-1) + "0" + sout.Substring(i, str.Length - i);
            else
                sout = sout.Substring(0,i-1) + "1" + sout.Substring(i,str.Length-i);
            return sout;
        }

        // funkcja dokonuje krzyzowania osobnikow i zwraca dziecko które ma lepsza ocene
        private string krzyzowanie(string s1, string s2, int c)
        {
            string c1 = null;
            string c2 = null;
            c1 = s1.Substring(0,c) + s2.Substring(c,s2.Length-c);
            c2 = s2.Substring(0, c) + s1.Substring(c, s1.Length - c);
            if (ocen(c1) > ocen(c2))
                return c1;
            return c2;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            // Generowanie nastepnej populacji

            //      Wybor najlepszych osobnikow
            int good = 0;
            double good_val = -10000;
            int best = 0;
            double best_val = -10000;
            for (int i = 0; i < 5; i++)
            {
                if (ocena[i] > good_val)
                {
                    if (ocena[i] > best_val)
                    {
                        good_val = best_val;
                        good = best;
                        best_val = ocena[i];
                        best = i;
                    }
                    else
                    {
                        good_val = ocena[i];
                        good = i;
                    }                        
                }
            }
            

            //      Tworzenie potomków poprzez krzy¿owanie najlepszych osobnikow
            for (int i = 0; i < 5; i++)
            {
                if (i != best && i != good)
                {
                    populacja[i] = krzyzowanie(populacja[best], populacja[good], rnd.Next(0, 10));
                }
            }
            //      Dokonanie mutacji potomka z prawdopodobienstwem 10%  
            for (int i = 0; i < 5; i++)
            {
                if (i != best && i != good && rnd.Next(1,100) < 10)
                {
                    populacja[i] = mutacja(populacja[i]);
                }
            }
            
            //      Wyznaczenie oceny dla nowej populacji

            for (int i = 0; i < 5; i++)
            {
                ocena[i] = ocen(populacja[i]);
            }

            //      Wyznaczenie najlepszego osobnika we wszystkich populacjach

            for (int i = 0; i < 5; i++)
            {
                if (ocena[i] > best_val)
                    best = i;
            }
            bestpop = populacja[best];
            bestocena = ocena[best];

            nrpop++;           
            pokazPopulacje();
        }
    }
}