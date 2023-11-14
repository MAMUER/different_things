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
        public double T1=0;
        public double n1=0;
        public double i = 0;
        public double psi = 0;
        public int tip = 0;
        public int charNagr = 0;
        public int wayReg = 0;
        public int charSmaz = 0;
        public int rezhRab = 0;
        public bool check=true;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxT_TextChanged(object sender, EventArgs e)
        {
            try
            {
T1 = Convert.ToDouble(textBoxT.Text);
            }
            catch
            {
if (T1 < 0)
            {
                check = false;
                labelOuti.Text = "T1 < 0";
            }
            }            
        }

        private void textBoxn_TextChanged(object sender, EventArgs e)
        {
            try
            {
n1 = Convert.ToDouble(textBoxn.Text);
            }
            catch
            {
if (n1 < 0)
            {
                check = false;
                labelOuti.Text = "n1 < 0";
            }
            }            
        }

        private void textBoxpsi_TextChanged(object sender, EventArgs e)
        {
            try
            {
psi= Convert.ToDouble(textBoxpsi.Text);
            }
            catch
            {
if (psi < 0 || psi > 90)
            {
                check = false;
                labelOuti.Text = "psi должен быть в пределах 0 и 90 градусов";
            }
            }            
        }

        private void textBoxTipPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
tip = Convert.ToInt32(textBoxTipPer.Text);
            }
            catch
            {
if (tip != 1 & tip != 2)
            {                
                check = false;
                labelOuti.Text = "Тип передачи не 1 и не 2";
            }
            }            
        }

        private void textBoxCharNagr_TextChanged(object sender, EventArgs e)
        {
            try
            {
charNagr = Convert.ToInt32(textBoxHarNagr.Text);
            }
            catch
            {
if (charNagr != 1 & charNagr != 2)
            {
                labelOuti.Text = "Характер нагрузки не 1 и не 2";
                check = false;
            }
            }            
        }

        private void textBoxWayOfReg_TextChanged(object sender, EventArgs e)
        {
            try
            {
wayReg = Convert.ToInt32(textBoxRegNat.Text);
            }
            catch
            {
if (wayReg != 1 & wayReg != 2 & wayReg !=3)
            {
                labelOuti.Text = "Способ регулирования не 1, не 2 и не 3";
                check = false;
            }
            }            
        }

        private void textBoxCharOfSma_TextChanged(object sender, EventArgs e)
        {
            try
            {
charSmaz = Convert.ToInt32(textBoxHarOfSmaz.Text);
            }
            catch
            {
if (charSmaz != 1 & charSmaz != 2 & charSmaz != 3)
            {
                labelOuti.Text = "Характер смазывания не 1, не 2 и не 3";
                check = false;
            }
            }            
        }

        private void textBoxi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                i = Convert.ToDouble(textBoxi.Text);
            }
            catch
            {
                if (i <= 0)
                {
                    labelOuti.Text = "Передаточное число <= 0";
                    check = false;
                }
            }            
        }

        private void textBoxRezhRab_TextChanged(object sender, EventArgs e)
        {
            try
            {
rezhRab = Convert.ToInt32(textBoxRezhRab.Text);
            }
            catch
            {
if (rezhRab != 1 & rezhRab != 2 & rezhRab != 3)
            {
                labelOuti.Text = "Режим работы не 1, не 2 и не 3";
                check = false;
            }
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z1 = 0;
            int z2 = 0;
            double Pc = 0;
            int n1lim = 0;
            double d = 0;
            double dр=0;
            double Bвн=0;
            double A=0;
            double Fр=0;
            double q = 0;
            String use="";
            double Ke = 0;
            double Kd = 0;
            double Ka=1;
            double Kn = 0;
            double Kreg = 0;
            double Ksm = 0;
            double Krezh = 0;
            double Kt=1;
            double d1 = 0;
            double Ft = 0;
            double p = 0;
            double Krad=1;
            double S = 0;
            double d2 = 0;
            double da1 = 0;
            double da2 = 0;
            double df1 = 0;
            double df2 = 0;
            double b = 0;
            double a = 0;
            double Lр = 0;
            double kb = 0;
            double Fsum = 0;
            if (!check)
            {
                goto end;
            }
                z1 = (int)Math.Round((29 - 2 * i));
                if (z1 < 13)
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
                    z2 = (int)Math.Round(z1 * i);
                    if (z2 > 120 | z2 <= 0)
                    {
                        labelOuti.Text = "Ошибка z2";
                    }
                    else
                    {
                        Pc = 12.8 * Math.Pow((T1 / z1), 1 / 3);
                        if (Pc <= 0)
                        {
                            labelOuti.Text = "Ошибка шага";
                        }
                        else
                        {
                        here:
                            if (Pc <= 14.3)
                            {
                                Pc = 12.7;
                                n1lim = 3100;                                
                                use = "z1=" + Convert.ToString(z1) + "   z2=" + Convert.ToString(z2) + "   ПР-12.7-1820-1";
                                d = 4.45;
                                dр = 8.51;
                                Bвн = 5.4;
                                A = 40;
                                Fр = 18.2;
                                q = 0.65;
                            }
                            else if (Pc > 14.3 & Pc <= 17.5)
                            {
                                Pc = 15.875;
                                n1lim = 2300;
                                if (n1lim < n1)
                                {
                                    Pc = 12.7;
                                    goto here;
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
                                }
                            }
                            else if (Pc > 17.5 & Pc <= 22.23)
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
                                }
                            }
                            else if (Pc > 22.23 & Pc <= 28.6)
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
                                }
                            }
                            else if (Pc > 28.6 & Pc <= 35)
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
                                }
                            }
                            else if (Pc > 35 & Pc <= 41.3)
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
                                }
                            }
                            else if (Pc > 41.3 & Pc <= 47.63)
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
                                }
                            }
                            else if (Pc > 47.63)
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
                                }
                            }
                            switch (charNagr) {
                                case 1:                                
                                    Kd = 1;
                                    break;
                                case 2:
                                    Kd = 1.35;
                                    break;
                            }                            
                            if (psi <= 45)
                            {
                                Kn = 1;
                            }
                            else
                            {
                                Kn = 0.15 * Math.Sqrt(psi* Math.PI/180);
                            }
                        switch (wayReg)
                        {
                            case 1:
                                Kreg = 1;
                                break;
                            case 2:
                                Kreg = 1.1;
                                break;
                            case 3:
                                Kreg = 1.25;
                                break;
                        }
                        switch (charSmaz)
                        {
                            case 1:
                                Ksm = 0.8;
                                break;
                            case 2:
                                Ksm = 1;
                                break;
                            case 3:
                                Ksm = 1.5;
                                break;
                        }
                        switch (rezhRab)
                        {
                            case 1:
                                Ksm = 1;
                                break;
                            case 2:
                                Ksm = 1.25;
                                break;
                            case 3:
                                Ksm = 1.45;
                                break;
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
        end:
            check = true;
        }

        private void labelT_Click(object sender, EventArgs e)
        {
            
        }
    }
}
