using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_1
{   
    public partial class Form1 : Form
    {
        int n1;
        int n2;
        String operacion = "";
        Boolean operando = false;
        public Form1()
        {
            InitializeComponent();
        }


        private int Operar(int n1, int n2, String operacion)
        {
            int resultado = 0;
            if (operacion.Equals("+"))
            {
                resultado = n1 + n2;
            }
            else if (operacion.Equals("-"))
            {
                resultado = n1 - n2;
            }
            else if (operacion.Equals("*"))
            {
                resultado = n1 * n2;
            }
            else if(operacion.Equals("/"))
            {
                resultado = n1 / n2;
            }
            return resultado;
        }

        private void ActScreen(int num)
        {
            if (operando = false)
            {
                Pantalla.Text = Pantalla.Text + num.ToString();
                n1 = int.Parse(Pantalla.Text);
            }
            else
            { 
                Pantalla.Text = Pantalla.Text + num.ToString();
                n2 = int.Parse(Pantalla.Text);
            } 
        }

        private void Boton0_Click(object sender, EventArgs e)
        {
            ActScreen(0);
        }
        private void Boton1_Click(object sender, EventArgs e)
        {
            ActScreen(1);
        }
        private void Boton2_Click(object sender, EventArgs e)
        {
            ActScreen(2);
        }
        private void Boton3_Click(object sender, EventArgs e)
        {
            ActScreen(3);
        }
        private void Boton4_Click(object sender, EventArgs e)
        {
            ActScreen(4);
        }
        private void Boton5_Click(object sender, EventArgs e)
        {
            ActScreen(5);
        }
        private void Boton6_Click(object sender, EventArgs e)
        {
            ActScreen(6);
        }
        private void Boton7_Click(object sender, EventArgs e)
        {
            ActScreen(7);
        }
        private void Boton8_Click(object sender, EventArgs e)
        {
            ActScreen(8);
        }
        private void Boton9_Click(object sender, EventArgs e)
        {
            ActScreen(9);
        }

        private void BotonResta_Click(object sender, EventArgs e)
        {
            operando = true;
            operacion = "-";
        }
        private void BotonSuma_Click(object sender, EventArgs e)
        {
            operando = true;
            operacion = "+";
        }
        private void BotonMultplicar_Click(object sender, EventArgs e)
        {
            operando = true;
            operacion = "*";
        }
        private void BotonDividir_Click(object sender, EventArgs e)
        {
            operando = true;
            operacion = "/";
        }

        private void ButtonIgual_Click(object sender, EventArgs e)
        {

           // String resultado = Operar(n1, n2, operacion).ToString();
           // Pantalla.Text = resultado;
            
        }


    }
}
