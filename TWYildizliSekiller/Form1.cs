using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TWYildizliSekiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SekilleriCiz();
        }

        private void nudSatirAdet_ValueChanged(object sender, EventArgs e)
        {
            SekilleriCiz();
        }

        private void SekilleriCiz()
        {
            int n = (int)nudSatirAdet.Value;
            string yildiz = txtYildizKarakter.Text;
            Sekil1(n, yildiz);
            Sekil2(n, yildiz);
            Sekil3(n, yildiz);
            Sekil4(n, yildiz);
            Sekil5(n, yildiz);
            Sekil6(n, yildiz);
            Sekil7(n, yildiz);
            Sekil8(n, yildiz);
            Sekil9(n, yildiz);
        }

        private void Sekil9(int n, string yildiz)
        {
            string sonuc = "";
            string bosluk = Bosluk(yildiz);

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                    sonuc += Kere(yildiz, n);
                else
                    sonuc += yildiz + Kere(bosluk, n - 2) + yildiz;

                sonuc += Environment.NewLine;
            }

            txtSekil9.Text = sonuc;
        }

        private void Sekil8(int n, string yildiz)
        {
            string sonuc = "";
            string bosluk = Bosluk(yildiz);

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    sonuc += (i == j || i + j == n + 1) ? yildiz : bosluk;
                }
                sonuc += Environment.NewLine;
            }

            txtSekil8.Text = sonuc;
        }

        private void Sekil7(int n, string yildiz)
        {
            string sonuc = "";
            string bosluk = Bosluk(yildiz);

            for (int i = 1; i <= n; i++)
            {
                sonuc += Kere(bosluk, n - i);
                sonuc += yildiz;
                sonuc += Environment.NewLine;
            }

            txtSekil7.Text = sonuc;
        }

        private void Sekil6(int n, string yildiz)
        {
            string sonuc = "";
            string bosluk = Bosluk(yildiz);

            for (int i = 0; i < n; i++)
            {
                sonuc += Kere(bosluk, i);
                sonuc += yildiz;
                sonuc += Environment.NewLine;
            }

            txtSekil6.Text = sonuc;
        }

        private string Bosluk(string yildiz)
        {
            return new string(' ', yildiz.Length);
        }

        private void Sekil5(int n, string yildiz)
        {
            string sonuc = "";
            for (int i = 1; i <= n; i++)
            {
                sonuc += Kere(" ", (n - i) * yildiz.Length);
                sonuc += Kere(yildiz, 2 * i - 1);
                sonuc += "\r\n";
            }
            txtSekil5.Text = sonuc;
        }

        private void Sekil4(int n, string yildiz)
        {
            string sonuc = "";
            for (int i = 1; i <= n; i++)
            {
                sonuc += Kere(" ", (n - i) * yildiz.Length);
                sonuc += Kere(yildiz, i);
                sonuc += "\r\n";
            }
            txtSekil4.Text = sonuc;
        }

        private string Kere(string metin, int adet)
        {
            string sonuc = "";
            for (int i = 0; i < adet; i++)
            {
                sonuc += metin;
            }
            return sonuc;
        }

        private void Sekil3(int n, string yildiz)
        {
            string sonuc = "";

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sonuc += yildiz + " ";
                }
                sonuc += Environment.NewLine;
            }

            txtSekil3.Text = sonuc;
        }

        private void Sekil2(int n, string yildiz)
        {
            string sonuc = "";

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sonuc += yildiz;
                }
                sonuc += Environment.NewLine;
            }

            txtSekil2.Text = sonuc;
        }

        private void Sekil1(int n, string yildiz)
        {
            string sonuc = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sonuc += yildiz;
                }
                sonuc +=  "\r\n";
            }

            txtSekil1.Text = sonuc;
        }

        private void txtYildizKarakter_TextChanged(object sender, EventArgs e)
        {
            SekilleriCiz();
        }
    }
}
