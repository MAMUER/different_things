using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chain
{
    public partial class Form1 : Form
    {
        public double T1;
        public double n1;
        public double i;
        public double psi;
        public int tip;
        public int charNagr;
        public double wayReg;
        public double charSmaz;
        public double rezhRab;
        public bool check=true;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxT_TextChanged(object sender, EventArgs e)
        {
            T1 = Convert.ToDouble(textBoxT.Text);
            if (T1 < 0)
            {
                check = false;
            }
        }

        private void textBoxn_TextChanged(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBoxn.Text);
            if (n1 < 0)
            {
                check = false;
            }
        }

        private void textBoxpsi_TextChanged(object sender, EventArgs e)
        {
            psi= Convert.ToDouble(textBoxpsi.Text);
            if (psi < 0)
            {
                check = false;
            }
        }

        private void textBoxTipPer_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTipPer.Text == "открытая")
            {
                tip = 1;
            }else if(textBoxTipPer.Text == "закрытая")
            {
                tip = 2;
            }
            else
            {
                check = false;
            }
        }

        private void textBoxCharNagr_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHarNagr.Text == "постоянная")
            {
                charNagr = 1;
            }
            else if (textBoxHarNagr.Text == "переменная")
            {
                charNagr = 2;
            }
            else
            {
                check = false;
            }
        }

        private void textBoxWayOfReg_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRegNat.Text == "смещение звездочки")
            {
                wayReg = 1;
            }
            else if (textBoxRegNat.Text == "оттяжная звездочка")
            {
                wayReg = 2;
            }
            else if(textBoxRegNat.Text == "нажимной ролик")
            {
                wayReg = 3;
            }
            else
            {
                check = false;
            }
        }

        private void textBoxCharOfSma_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHarOfSmaz.Text == "непрерывный")
            {
                charSmaz = 1;
            }
            else if (textBoxHarOfSmaz.Text == "регулярный")
            {
                charSmaz = 2;
            }
            else if (textBoxHarOfSmaz.Text == "нерегулярный")
            {
                charSmaz = 3;
            }
            else
            {
                check = false;
            }
        }

        private void textBoxi_TextChanged(object sender, EventArgs e)
        {
            i = Convert.ToDouble(textBoxi.Text);
        }

        private void textBoxRezhRab_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRezhRab.Text == "односменный")
            {
                rezhRab = 1;
            }
            else if (textBoxRezhRab.Text == "двухсменный")
            {
                rezhRab = 2;
            }
            else if (textBoxRezhRab.Text == "трехсменный")
            {
                rezhRab = 3;
            }
            else
            {
                check = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z1;
            int z2;
            double Pc;
            int n1lim;
            double d;
            double dр=0;
            double Bвн=0;
            double A=0;
            double Fр=0;
            double q;
            String use="";
            double Ke;
            double Kd;
            double Ka=1;
            double Kn;
            double Kreg;
            double Ksm;
            double Krezh;
            double Kt=1;
            double d1;
            double Ft;
            double p;
            double Krad=1;
            double S;
            double d2;
            double da1;
            double da2;
            double df1;
            double df2;
            double b;
            double a;
            double Lр;
            double kb;
            double Fsum;

                z1 = (int)Math.Truncate((29 - 2 * i) + 1);
                if (z1 < 13 | z1 <= 0)
                {
                    labelOuti.Text = "Ошибка z1";
                }
                else
                {
                    switch (z1)
                    {
                        case 13:
                            z1 = 13;
                            break;
                        case 14 | 15:
                            z1 = 15;
                            break;
                        case 16 | 17:
                            z1 = 17;
                            break;
                        case 18 | 19:
                            z1 = 19;
                            break;
                        case 20 | 21:
                            z1 = 21;
                            break;
                        case 22 | 23:
                            z1 = 23;
                            break;
                        case 24 | 25:
                            z1 = 25;
                            break;
                        case 26 | 27:
                            z1 = 27;
                            break;
                        default:
                            z1 = 29;
                            break;
                    }
                    z2 = (int)Math.Truncate(z1 * i + 1);
                    if (z2 > 120 | z2 <= 0)
                    {
                        labelOuti.Text = "Ошибка z2";
                    }
                    else
                    {
                        Pc = 12.8 * Math.Pow((T1 / z1), 1 / 3);
                        if (Pc < 0)
                        {
                            labelOuti.Text = "Ошибка Pc";
                        }
                        else
                        {
                        here:
                            if (Pc <= 12.7)
                            {
                                Pc = 12.7;
                                use = "z1=" + Convert.ToString(z1) + "   z2=" + Convert.ToString(z2) + "   ПР-12.7-1820-1";
                                d = 4.45;
                                dр = 8.51;
                                Bвн = 5.4;
                                A = 40;
                                Fр = 18.2;
                                q = 0.65;
                                goto there;
                            }
                            else if (Pc <= 15.875)
                            {
                                Pc = 15.875;
                                n1lim = 2300;
                                if (n1lim < n1)
                                {
                                    Pc = 12.7;
                                }
                                else
                                {
                                    use = "z1=" + Convert.ToString(z1) + "   z2=" + Convert.ToString(z2) + "   Цепь: ПР-15.875-2270-1";
                                    d = 5.08;
                                    dр = 10.16;
                                    Bвн = 6.48;
                                    A = 55;
                                    Fр = 22.7;
                                    q = 0.8;
                                    goto there;
                                }
                            }
                            else if (Pc <= 19.05)
                            {
                                Pc = 19.05;
                                n1lim = 1800;
                                if (n1lim < n1)
                                {
                                    Pc = 15.875;
                                    goto here;
                                }
                                else
                                {
                                    use = "z1=" + Convert.ToString(z1) + "   z2=" + Convert.ToString(z2) + "   Цепь: ПР-19.05-3180";
                                    d = 5.96;
                                    dр = 11.91;
                                    Bвн = 12.7;
                                    A = 105;
                                    Fр = 31.8;
                                    q = 1.9;
                                    goto there;
                                }
                            }
                            else if (Pc <= 25.4)
                            {
                                Pc = 25.4;
                                n1lim = 1200;
                                if (n1lim < n1)
                                {
                                    Pc = 19.05;
                                    goto here;
                                }
                                else
                                {
                                    use = "z1=" + Convert.ToString(z1) + "   z2=" + Convert.ToString(z2) + "   Цепь: ПР-25.4-5670";
                                    d = 7.95;
                                    dр = 15.88;
                                    Bвн = 15.88;
                                    A = 180;
                                    Fр = 56.7;
                                    q = 2.6;
                                    goto there;
                                }
                            }
                            else if (Pc <= 31.75)
                            {
                                Pc = 31.75;
                                n1lim = 1000;
                                if (n1lim < n1)
                                {
                                    Pc = 25.4;
                                    goto here;
                                }
                                else
                                {
                                    use = "z1=" + Convert.ToString(z1) + "   z2=" + Convert.ToString(z2) + "   Цепь: ПР-31.75-8850";
                                    d = 9.55;
                                    dр = 19.05;
                                    Bвн = 19.05;
                                    A = 260;
                                    Fр = 88.5;
                                    q = 3.8;
                                    goto there;
                                }
                            }
                            else if (Pc <= 38.1)
                            {
                                Pc = 38.1;
                                n1lim = 900;
                                if (n1lim < n1)
                                {
                                    Pc = 31.75;
                                    goto here;
                                }
                                else
                                {
                                    use = "z1=" + Convert.ToString(z1) + "   z2=" + Convert.ToString(z2) + "   Цепь: ПР-38.1-12700";
                                    d = 11.1;
                                    dр = 22.23;
                                    Bвн = 25.4;
                                    A = 395;
                                    Fр = 127;
                                    q = 5.5;
                                    goto there;
                                }
                            }
                            else if (Pc <= 44.45)
                            {
                                Pc = 44.45;
                                n1lim = 600;
                                if (n1lim < n1)
                                {
                                    Pc = 38.1;
                                    goto here;
                                }
                                else
                                {
                                    use = "z1=" + Convert.ToString(z1) + "   z2=" + Convert.ToString(z2) + "   Цепь: ПР-44.45-17240";
                                    d = 12.7;
                                    dр = 25.7;
                                    Bвн = 25.4;
                                    A = 475;
                                    Fр = 172.4;
                                    q = 7.5;
                                    goto there;
                                }
                            }
                            else if (Pc > 44.45)
                            {
                                Pc = 50.8;
                                n1lim = 450;
                                if (n1lim < n1)
                                {
                                    Pc = 44.45;
                                    goto here;
                                }
                                else
                                {
                                    use = "z1=" + Convert.ToString(z1) + "   z2=" + Convert.ToString(z2) + "   Цепь: ПР-50.8-22680";
                                    d = 14.29;
                                    dр = 28.58;
                                    Bвн = 31.75;
                                    A = 645;
                                    Fр = 226.8;
                                    q = 9.7;
                                    goto there;
                                }
                            }
                        there:
                            if (charNagr == 1)
                            {
                                Kd = 1;
                            }
                            else
                            {
                                Kd = 1.2;
                            }
                            if (psi <= 45)
                            {
                                Kn = 1;
                            }
                            else
                            {
                                Kn = 0.15 * Math.Sqrt(psi);
                            }
                            if (wayReg == 1)
                            {
                                Kreg = 1;
                            }
                            else if (wayReg == 2)
                            {
                                Kreg = 1.1;
                            }
                            else
                            {
                                Kreg = 1.25;
                            }
                            if (charSmaz == 1)
                            {
                                Ksm = 0.8;
                            }
                            else if (wayReg == 2)
                            {
                                Ksm = 1;
                            }
                            else
                            {
                                Ksm = 1.5;
                            }
                            if (rezhRab == 1)
                            {
                                Krezh = 1;
                            }
                            else if (wayReg == 2)
                            {
                                Krezh = 1.25;
                            }
                            else
                            {
                                Krezh = 1.45;
                            }
                            Ke = Kd * Ka * Kn * Kreg * Ksm * Krezh * Kt;
                            d1 = Pc / Math.Sin(Math.PI / z1);
                            Ft = 2000 * T1 / d1;
                            p = Ke * Ft / (A * Krad);
                            S = Fр / (Kd * Ft);
                            d2 = Pc / Math.Sin(Math.PI / z2);
                            da1 = Pc * (0.5 + Math.Cos(Math.PI / z1) / Math.Sin(Math.PI / z1));
                            da2 = Pc * (0.5 + Math.Cos(Math.PI / z2) / Math.Sin(Math.PI / z2));
                            df1 = d1 - dр - 0.1;
                            df2 = d2 - dр - 0.1;
                            b = 0.9 * Bвн - 0.15;
                            a = 40 * Pc;
                            Lр = 2 * a / Pc + (z1 + z2) / 2 + Math.Pow((z2 - z1) / (2 * Math.PI), 2) * Pc / a;
                            Lр = Math.Truncate(Lр++);
                            a = (Pc / 4) * (Lр - (z1 + z2) / 2 + Math.Sqrt(Math.Pow(Lр - (z1 + z2) / 2, 2) - 8 * Math.Pow((z2 - z1) / (2 * Math.PI), 2)));
                            a = a - 0.004 * a;
                            if (psi <= 45)
                            {
                                kb = 1.15;
                            }
                            else
                            {
                                kb = 1.05;
                            }
                            if (charNagr == 2)
                            {
                                kb = kb * 1.1;
                            }
                            Fsum = kb * Ft;
                            labelOuti.Text = use + " \nd1= " + (float)d1 + "   d2= " + (float)d2 + "   b=" + b + " \nLр=" + (float)Lр + "   a=" + (float)a + "   Fsum=" + (float)Fsum;
                        }
                    }
                }
        }             

    }
}
