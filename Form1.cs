using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Jeamphy Romero, 15-EISN-1-223 , Sec 0908.

            //Declaracion de Variables
            int numero, resultado;
            string nombre;

            nombre = Convert.ToString(txtNombre.Text);
            numero = Convert.ToInt32(txtNumero.Text);

            cbxNum.Items.Clear();

            if (numero %2 ==0)
            {
                for (int i=numero; i<=100; i = i+2)
                {
                    resultado = i;
                    cbxNum.Items.Add(resultado);
                }
                txtResultado.Text = ("El numero es par");
            }
            else
            {
                for (int i = numero; i<=100; i=i+2)
                {
                    resultado = i;
                    cbxNum.Items.Add(resultado);
                }
                txtResultado.Text = ("El numero es impar");
            }
            if (txtNombre.Text== "Jeamphy Romero")
            {
                txtMatricula.Text = ("15-EISN-1-223");
            }
            else
            {
                txtMatricula.Text = ("Su nombre no es correcto");
            }

           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNumero.Clear();
            txtResultado.Clear();
            txtMatricula.Clear();
            cbxNum.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
