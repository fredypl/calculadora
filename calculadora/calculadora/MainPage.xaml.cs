using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;


namespace calculadora
{
    public partial class MainPage : ContentPage
    {

        double d1, d2, resul;
        string opera, borrado;
        bool secuencia;

        public object MessageBox { get; private set; }

        public MainPage()
        {
            InitializeComponent();
        }

        private void potencia_Clicked(object sender, EventArgs e)
        {
            d1 = double.Parse(caja.Text);
            resul = d1 * d1;
            caja.Text = resul.ToString();
        }

        private void factorial_Clicked(object sender, EventArgs e)
        {
            double factorial = 1;
            resul = double.Parse(caja.Text);

            if (d1 < 0)
            {

            }
                    
            for (int i = 1; i <= resul; i++)
            {
                factorial = i * factorial;
            }
            caja.Text = factorial.ToString();
        
            
        }

        private void Raiz_Clicked(object sender, EventArgs e)
        {

            if (d1 > 0)
            {
                
            }

            else
                d1 = double.Parse(caja.Text);
                resul = Math.Sqrt(d1);
                caja.Text = resul.ToString();
            

        }

        private void entre_Clicked(object sender, EventArgs e)
        {
            opera = "/";
            d1 = double.Parse(caja.Text);
            secuencia = true;


        }

        private void siete_Clicked(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "7";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "7";
            }
        }

        private void ocho_Clicked(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "8";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "8";
            }
        }
        private void nueve_Clicked(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "9";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "9";
            }
        }

        private void por_Clicked(object sender, EventArgs e)
        {
            opera = "*";
            d1 = double.Parse(caja.Text);
            secuencia = true;


        }

        private void cuatro_Clicked(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "4";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "4";
            }
        }

        private void cinco_Clicked(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "5";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "5";
            }
        }

        private void seis_Clicked(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "6";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "6";
            }
        }

        private void menos_Clicked(object sender, EventArgs e)
        {
            opera = "-";
            d1 = double.Parse(caja.Text);
            secuencia = true;


        }

        private void uno_Clicked(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "1";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "1";
            }
        }
    
        private void dos_Clicked_1(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "2";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "2";
            }
        }

        private void tres_Clicked_2(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "3";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "3";
            }
        }

        private void mas_Clicked_3(object sender, EventArgs e)
        {
            opera = "+";
            d1 = double.Parse(caja.Text);
            secuencia = true;
           
                  
        }

        private void mas_menos_Clicked_4(object sender, EventArgs e)
        {
            double d1 = double.Parse(caja.Text);
            d1 *= -1;
            caja.Text = d1.ToString();
        }

        private void cero_Clicked_5(object sender, EventArgs e)
        {
            if (caja.Text == "0")

            {
                return;

            }
            else
            {
                caja.Text = caja.Text + "0";
            }
        }

        private void C_Clicked(object sender, EventArgs e)
        {
            caja.Text = "0";
            d1 = 0;
            d2 = 0;
            secuencia = true;

        }

        private void punto_Clicked_6(object sender, EventArgs e)
        {
            if (!caja.Text.Contains("."))
            { caja.Text = caja.Text + ".";
            }
            
        }
                 

        private void igual_Clicked_7(object sender, EventArgs e)
        {

            d2 = double.Parse(caja.Text);
            if (opera == "+")
            {
                resul = d1 + d2;
                caja.Text = resul.ToString();
                secuencia = true;
            }
            if (opera == "-")
            {
                resul = d1 - d2;
                caja.Text = resul.ToString();
                secuencia = true;
            }
            if (opera == "*")
            {
                resul = d1 * d2;
                caja.Text = resul.ToString();
                secuencia = true;
            }
            if (opera == "/")
            {
                resul = d1 / d2;
                caja.Text = resul.ToString();
                secuencia = true;
            }

        }


        private void CE_Clicked_1(object sender, EventArgs e)
        {
            int x = 0;
            borrado = caja.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            caja.Text = borrado;

            if (caja.Text == "")
            {
                caja.Text = "0";
                secuencia = true;
            }
            if (caja.Text == "-")
            {
                caja.Text = "0";
                secuencia = true;
            }
        }
    }
}
