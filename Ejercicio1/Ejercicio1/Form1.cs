using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{

    public partial class Form1 : Form //Erick Rodriguez
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        decimal Resultado =  0;
       
        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            decimal numero = Convert.ToDecimal(NumeroTextBox.Text);
            Resultado = TipoNum(numero);
            if (Resultado % 2 == 0)
            {
                MessageBox.Show("El numero: " + Resultado + " Es Par", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("El numero: " + Resultado + " Es Impar ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Resultado = Signo(numero);
            if (Resultado >= 0)
            {
                MessageBox.Show("El numero: " + Resultado + " Positivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El numero: " + Resultado + " Negativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }            
        
        private decimal TipoNum(decimal num)
        {
            return num;
        }

        private decimal Signo(decimal num)
        {
            return num;
        }
    }
}
