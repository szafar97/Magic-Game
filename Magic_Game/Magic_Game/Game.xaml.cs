using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Magic_Game
{
    class Items
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
        public int F { get; set; }
        public int G { get; set; }
        public int H { get; set; }
    }

    public partial class Game : Window
    {
        int[] arr = new int[8];
        int result;
        int setindex;

        public Game()
        {
            InitializeComponent();
            result = 0;
            setindex = 0;
            setA();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        void setA()
        {
            List<Items> it = new List<Items>();

            int index = 0;

            for (int i = 1; i <= 127; i += 2)
            {
                arr[index++] = i;

                if (index % 8 == 0)
                {
                    it.Add(new Items { A = arr[0], B = arr[1], C = arr[2], D = arr[3], E = arr[4], F = arr[5], G = arr[6], H = arr[7] });
                    index = 0;
                }
            }

            grid.ItemsSource = it;
        }

        void setB()
        {
            List<Items> it = new List<Items>();

            int index = 0;

            for (int i = 2; i <= 127; i += 3)
            {
                arr[index++] = i;
                arr[index++] = ++i;

                if (index % 8 == 0)
                {
                    it.Add(new Items { A = arr[0], B = arr[1], C = arr[2], D = arr[3], E = arr[4], F = arr[5], G = arr[6], H = arr[7] });
                    index = 0;
                }
            }

            grid.ItemsSource = it;
        }

        void setC()
        {
            List<Items> it = new List<Items>();

            int index = 0;

            for (int i = 4; i <= 127; i++)
            {
                if (i % 8 == 0)
                {
                    i += 3;
                    continue;
                }

                arr[index++] = i;

                if (index % 8 == 0)
                {
                    it.Add(new Items { A = arr[0], B = arr[1], C = arr[2], D = arr[3], E = arr[4], F = arr[5], G = arr[6], H = arr[7] });
                    index = 0;
                }
            }

            grid.ItemsSource = it;
        }

        void setD()
        {
            List<Items> it = new List<Items>();

            int index = 0;

            for (int i = 8; i <= 127; i++)
            {
                if (i % 16 == 0)
                {
                    i += 7;
                    continue;
                }

                arr[index++] = i;

                if (index % 8 == 0)
                {
                    it.Add(new Items { A = arr[0], B = arr[1], C = arr[2], D = arr[3], E = arr[4], F = arr[5], G = arr[6], H = arr[7] });
                    index = 0;
                }
            }

            grid.ItemsSource = it;
        }

        void setE()
        {
            List<Items> it = new List<Items>();

            int index = 0;

            for (int i = 16; i <= 127; i++)
            {
                if (i % 32 == 0)
                {
                    i += 15;
                    continue;
                }

                arr[index++] = i;

                if (index % 8 == 0)
                {
                    it.Add(new Items { A = arr[0], B = arr[1], C = arr[2], D = arr[3], E = arr[4], F = arr[5], G = arr[6], H = arr[7] });
                    index = 0;
                }
            }

            grid.ItemsSource = it;
        }

        void setF()
        {
            List<Items> it = new List<Items>();

            int index = 0;

            for (int i = 32; i <= 127; i++)
            {
                if (i % 64 == 0)
                {
                    i += 31;
                    continue;
                }

                arr[index++] = i;

                if (index % 8 == 0)
                {
                    it.Add(new Items { A = arr[0], B = arr[1], C = arr[2], D = arr[3], E = arr[4], F = arr[5], G = arr[6], H = arr[7] });
                    index = 0;
                }
            }

            grid.ItemsSource = it;
        }

        void setG()
        {
            List<Items> it = new List<Items>();

            int index = 0;

            for (int i = 64; i <= 127; i++)
            {
                if (i % 128 == 0)
                {
                    i += 63;
                    continue;
                }

                arr[index++] = i;

                if (index % 8 == 0)
                {
                    it.Add(new Items { A = arr[0], B = arr[1], C = arr[2], D = arr[3], E = arr[4], F = arr[5], G = arr[6], H = arr[7] });
                    index = 0;
                }
            }

            grid.ItemsSource = it;
        }

        private void BTN_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Content.Equals("YES"))
            {
                result += Convert.ToInt32(Math.Pow(2, Convert.ToDouble(setindex)));
            }

            setindex++;
            ShowNextSet();
        }

        void ShowNextSet()
        {
            switch(setindex)
            {
                case 1:
                    setB();
                    break;

                case 2:
                    setC();
                    break;

                case 3:
                    setD();
                    break;

                case 4:
                    setE();
                    break;

                case 5:
                    setF();
                    break;

                case 6:
                    setG();
                    break;

                default:
                    End end = new End(result);
                    end.Show();
                    this.Close();
                    break;
            }
        }
    }
}