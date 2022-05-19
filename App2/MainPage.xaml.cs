using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        string LabelWidok = "";
        public int iloscTablicy = 0;
        public char[] tabPol = new char[1];
        public double[] liczby = new double[1];
        public char[] znaki = new char[1];
        public bool[] tabOstatDod = new bool[1];
        public bool ostatnioDodana;
        public int[] tabznakiMDZPozycja = new int[1];
        public int[] tabznakiDodOdPozycja = new int[1];
        public int[] zmienioneLiczby = new int[1];
        public MainPage()
        {
            InitializeComponent();
        }
        public double[] zmniejszTabliceLiczby(int zmniejszona)
        {
            double[] nowaTab = new double[liczby.Length - 1];
            for (int i = 0; i < nowaTab.Length; i++)
            {
                if (zmniejszona <= i)
                {
                    nowaTab[i] = liczby[i + 1];
                }
                else
                {
                    nowaTab[i] = liczby[i];
                }
            }
            return nowaTab;
        }
        public char[] zmniejszTabliceZnaki(int zmniejszona)
        {
            char[] nowaTab = new char[znaki.Length - 1];
            for (int i = 0; i < nowaTab.Length; i++)
            {
                if (zmniejszona <= i)
                {
                    nowaTab[i] = znaki[i + 1];
                }
                else
                {
                    nowaTab[i] = znaki[i];
                }
            }
            return nowaTab;
        }
        public int[] powiekszTabliceINT(int[] tab)
        {
            int[] nowaTab = new int[tab.Length + 1];
            for (int i = 0; i < tab.Length; i++)
            {
                nowaTab[i] = tab[i];
            }
            return nowaTab;
        }
        public bool[] powiekszTabliceBOOL(bool[] tab)
        {
            bool[] nowaTab = new bool[tab.Length + 1];
            for (int i = 0; i < tab.Length; i++)
            {
                nowaTab[i] = tab[i];
            }
            return nowaTab;
        }
        public char[] powiekszTabliceCHAR(char[] tab)
        {
            char[] nowaTab = new char[tab.Length + 1];
            for (int i = 0; i < tab.Length; i++)
            {
                nowaTab[i] = tab[i];
            }
            return nowaTab;
        }
        public void zamianaLiczbWTabeliLiczby(double zmieniana)
        {
            for (int i = 0; i < zmienioneLiczby.Length - 1; i++)
            {
                liczby[zmienioneLiczby[i]] = zmieniana;
            }
        }
        public double[] powiekszTabliceDOUBLE(double[] tab)
        {
            double[] nowaTab = new double[tab.Length + 1];
            for (int i = 0; i < tab.Length; i++)
            {
                nowaTab[i] = tab[i];
            }
            return nowaTab;
        }
        public double convert(string liczba)
        {

            if (double.TryParse(liczba, out double j))
            {
                return j;
            }

            return 0;
        }
        private void btn1Clicked(object sender, EventArgs e)
        {
            char[] nowaTab = new char[1];
            char[] nowaTabchar = new char[1];
            int[] nowaTabint = new int[1];
            bool[] nowaTabBool = new bool[1];
            double[] nowaTabDouble = new double[1];
            tabOstatDod = nowaTabBool;
            iloscTablicy = 0;
            tabPol = nowaTab;
            liczby = nowaTabDouble;
            znaki = nowaTabchar;
            tabznakiMDZPozycja = nowaTabint;
            tabznakiDodOdPozycja = nowaTabint;
            zmienioneLiczby = nowaTabint;
            Label1.Text = "";
            LabelWidok = "";
        }
        private void btn2Clicked(object sender, EventArgs e)
        {
            char[] nowaTab = new char[tabPol.Length - 2];
            for (int i = 0; i < nowaTab.Length; i++)
            {
                nowaTab[i] = tabPol[i];
            }
            tabPol = nowaTab;
            tabPol = powiekszTabliceCHAR(tabPol);
            iloscTablicy--;
            LabelWidok = LabelWidok.Remove(LabelWidok.Length - 1, 1);
            Label1.Text = LabelWidok;
        }
        private void btn3Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "/";
            Label1.Text = LabelWidok;
            ostatnioDodana = false;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '/';
            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn8.IsEnabled = false;
            btn12.IsEnabled = false;
        }
        private void btn4Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "*";
            Label1.Text = LabelWidok;
            ostatnioDodana = false;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '*';
            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn8.IsEnabled = false;
            btn12.IsEnabled = false;
        }
        private void btn5Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "7";
            Label1.Text = LabelWidok;
            ostatnioDodana = true;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '7';
            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn8.IsEnabled = true;
            btn12.IsEnabled = true;
        }
        private void btn6Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "8";
            Label1.Text = LabelWidok;
            ostatnioDodana = true;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '8';
            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn8.IsEnabled = true;
            btn12.IsEnabled = true;
        }
        private void btn7Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "9";
            Label1.Text = LabelWidok;
            ostatnioDodana = true;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '9';
            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn8.IsEnabled = true;
            btn12.IsEnabled = true;
        }
        private void btn8Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "-";
            Label1.Text = LabelWidok;
            ostatnioDodana = false;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '-';
            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn8.IsEnabled = false;
            btn12.IsEnabled = false;
        }
        private void btn9Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "4";
            Label1.Text = LabelWidok;
            ostatnioDodana = true;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '4';
            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn8.IsEnabled = true;
            btn12.IsEnabled = true;
        }
        private void btn10Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "5";
            Label1.Text = LabelWidok;
            ostatnioDodana = true;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '5';
            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn8.IsEnabled = true;
            btn12.IsEnabled = true;
        }
        private void btn11Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "6";
            Label1.Text = LabelWidok;
            ostatnioDodana = true;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '6';
            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn8.IsEnabled = true;
            btn12.IsEnabled = true;
        }
        private void btn12Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "+";
            Label1.Text = LabelWidok;
            ostatnioDodana = false;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '+';
            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn8.IsEnabled = false;
            btn12.IsEnabled = false;

        }
        private void btn13Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "1";
            Label1.Text = LabelWidok;
            ostatnioDodana = true;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '1';
            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn8.IsEnabled = true;
            btn12.IsEnabled = true;

        }
        private void btn14Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "2";
            Label1.Text = LabelWidok;
            ostatnioDodana = true;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '2';
            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn8.IsEnabled = true;
            btn12.IsEnabled = true;
        }
        private void btn15Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "3";
            Label1.Text = LabelWidok;
            ostatnioDodana = true;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '3';
            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn8.IsEnabled = true;
            btn12.IsEnabled = true;
        }
        private void btn17Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + ",";
            Label1.Text = LabelWidok;
            ostatnioDodana = true;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = ',';
            iloscTablicy = iloscTablicy + 1;
        }
        private void btn18Clicked(object sender, EventArgs e)
        {
            LabelWidok = LabelWidok + "0";
            Label1.Text = LabelWidok;
            ostatnioDodana = true;
            tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
            tabOstatDod[iloscTablicy] = ostatnioDodana;
            tabPol = powiekszTabliceCHAR(tabPol);
            tabPol[iloscTablicy] = '0';

            iloscTablicy = iloscTablicy + 1;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn8.IsEnabled = true;
            btn12.IsEnabled = true;
        }
        private void btn16Clicked(object sender, EventArgs e)
        {
            int tabznakiMDZCount = 0;
            int tabznakiDodOdCount = 0;
            int liczbyCount = 0;
            string liczba = "";
            int znakiCount = 0;
            int zmienioneLiczbyCount = 0;
            for (int i = 0; i < iloscTablicy; i++)
            {

                if (tabOstatDod[i] == true)
                {
                    liczba = liczba + tabPol[i];
                    if (i < iloscTablicy)
                    {
                        liczby[liczbyCount] = convert(liczba);
                    }
                }
                else
                {
                    liczby = powiekszTabliceDOUBLE(liczby);
                    liczby[liczbyCount] = convert(liczba);
                    liczbyCount++;
                    znaki[znakiCount] = tabPol[i];
                    znaki = powiekszTabliceCHAR(znaki);
                    znakiCount++;
                    liczba = "";
                }

            }
            for (int i = 0; i < znaki.Length; i++)
            {
                if (znaki[i] == 47 || znaki[i] == 42)
                {
                    tabznakiMDZPozycja[tabznakiMDZCount] = i;
                    tabznakiMDZPozycja = powiekszTabliceINT(tabznakiMDZPozycja);
                    tabznakiMDZCount++;
                }
                else
                {
                    tabznakiDodOdPozycja[tabznakiDodOdCount] = i;
                    tabznakiDodOdPozycja = powiekszTabliceINT(tabznakiDodOdPozycja);
                    tabznakiDodOdCount++;
                }
            }
            for (int i = 0; i < tabznakiMDZCount; i++)
            {
                double obliczona;
                if (znaki[tabznakiMDZPozycja[0]] == 47)
                {
                    obliczona = liczby[tabznakiMDZPozycja[0]] / liczby[tabznakiMDZPozycja[0] + 1];
                    Console.WriteLine(obliczona);
                    Console.WriteLine(liczby[tabznakiMDZPozycja[0]]);
                    Console.WriteLine(liczby[tabznakiMDZPozycja[0] + 1]);
                    Console.WriteLine("////////////////////////");
                    liczby[tabznakiMDZPozycja[0]] = obliczona;
                    liczby = zmniejszTabliceLiczby(tabznakiMDZPozycja[0] + 1);
                    for (int ii = 0; ii < liczby.Length; ii++)
                        Console.WriteLine(liczby[ii]);
                    znaki = zmniejszTabliceZnaki(tabznakiMDZPozycja[0]);
                    for (int ii = 0; ii < znaki.Length; ii++)
                        Console.WriteLine(znaki[ii]);
                    int countMdz = 0;
                    int dodOdCount = 0;
                    int[] tabIntPust = new int[1];
                    tabznakiMDZPozycja = tabIntPust;
                    tabznakiDodOdPozycja = tabIntPust;
                    for (int ii = 0; ii < znaki.Length; ii++)
                    {
                        if (znaki[ii] == 47 || znaki[ii] == 42)
                        {
                            tabznakiMDZPozycja[countMdz] = ii;
                            tabznakiMDZPozycja = powiekszTabliceINT(tabznakiMDZPozycja);
                            countMdz++;
                        }
                        else
                        {
                            tabznakiDodOdPozycja[dodOdCount] = ii;
                            tabznakiDodOdPozycja = powiekszTabliceINT(tabznakiDodOdPozycja);
                            dodOdCount++;
                        }
                    }
                }
                if (znaki[tabznakiMDZPozycja[0]] == 42)
                {
                    obliczona = liczby[tabznakiMDZPozycja[i]] * liczby[tabznakiMDZPozycja[i] + 1];
                    Console.WriteLine(obliczona);
                    Console.WriteLine(liczby[tabznakiMDZPozycja[0]]);
                    Console.WriteLine(liczby[tabznakiMDZPozycja[0] + 1]);
                    Console.WriteLine("////////////////////////");
                    liczby[tabznakiMDZPozycja[0]] = obliczona;
                    liczby = zmniejszTabliceLiczby(tabznakiMDZPozycja[0] + 1);
                    for (int ii = 0; ii < liczby.Length; ii++)
                        Console.WriteLine(liczby[ii]);
                    znaki = zmniejszTabliceZnaki(tabznakiMDZPozycja[0]);
                    for (int ii = 0; ii < znaki.Length; ii++)
                        Console.WriteLine(znaki[ii]);
                    int countMdz = 0;
                    int dodOdCount = 0;
                    int[] tabIntPust = new int[1];
                    tabznakiMDZPozycja = tabIntPust;
                    tabznakiDodOdPozycja = tabIntPust;
                    for (int ii = 0; ii < znaki.Length; ii++)
                    {
                        if (znaki[ii] == 47 || znaki[ii] == 42)
                        {
                            tabznakiMDZPozycja[countMdz] = ii;
                            tabznakiMDZPozycja = powiekszTabliceINT(tabznakiMDZPozycja);
                            countMdz++;
                        }
                        else
                        {
                            tabznakiDodOdPozycja[dodOdCount] = ii;
                            tabznakiDodOdPozycja = powiekszTabliceINT(tabznakiDodOdPozycja);
                            dodOdCount++;
                        }
                    }
                }
            }




            for (int i = 0; i < tabznakiDodOdCount; i++)
            {
                double obliczona;
                if (znaki[tabznakiDodOdPozycja[i]] == 43)
                {
                    obliczona = liczby[tabznakiDodOdPozycja[i]] + liczby[tabznakiDodOdPozycja[i] + 1];
                    zmienioneLiczby = powiekszTabliceINT(zmienioneLiczby);
                    zmienioneLiczby[zmienioneLiczbyCount] = tabznakiDodOdPozycja[i];
                    zmienioneLiczbyCount++;
                    zmienioneLiczby = powiekszTabliceINT(zmienioneLiczby);
                    zmienioneLiczby[zmienioneLiczbyCount] = tabznakiDodOdPozycja[i] + 1;
                    zmienioneLiczbyCount++;
                    zamianaLiczbWTabeliLiczby(obliczona);
                }
                if (znaki[tabznakiDodOdPozycja[i]] == 45)
                {
                    obliczona = liczby[tabznakiDodOdPozycja[i]] - liczby[tabznakiDodOdPozycja[i] + 1];
                    zmienioneLiczby = powiekszTabliceINT(zmienioneLiczby);
                    zmienioneLiczby[zmienioneLiczbyCount] = tabznakiDodOdPozycja[i];
                    zmienioneLiczbyCount++;
                    zmienioneLiczby = powiekszTabliceINT(zmienioneLiczby);
                    zmienioneLiczby[zmienioneLiczbyCount] = tabznakiDodOdPozycja[i] + 1;
                    zmienioneLiczbyCount++;
                    zamianaLiczbWTabeliLiczby(obliczona);
                }

            }
            LabelWidok = liczby[0].ToString();
            Label1.Text = liczby[0].ToString();
            String wynik = Label1.Text;
            char[] nowaTab = new char[wynik.Length + 1];
            char[] nowaTabchar = new char[1];
            int[] nowaTabint = new int[1];
            bool[] nowaTabBool = new bool[1];
            double[] nowaTabDouble = new double[1];
            tabOstatDod = nowaTabBool;
            iloscTablicy = 0;
            for (int i = 0; i < wynik.Length; i++)
            {
                tabOstatDod = powiekszTabliceBOOL(tabOstatDod);
                tabOstatDod[iloscTablicy] = true;
                iloscTablicy++;
                nowaTab[i] = wynik[i];
            }
            tabPol = nowaTab;
            liczby = nowaTabDouble;
            znaki = nowaTabchar;
            tabznakiMDZPozycja = nowaTabint;
            tabznakiDodOdPozycja = nowaTabint;
            zmienioneLiczby = nowaTabint;

        }
    }
}
