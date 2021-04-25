using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Lógica;

namespace WindowsFormsApp1
{
    public partial class GUIArbolBinario : Form
    {
        public GUIArbolBinario()
        {
            InitializeComponent();
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            String original = "";
            String resultado;
            resultado = ServicioArbolBinario.recorrePreOrden(ServicioArbolBinario.getRaiz(), original);
            txtOrdenes.Text = resultado;
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            String original = "";
            String resultado;
            resultado = ServicioArbolBinario.recorreInOrden(ServicioArbolBinario.getRaiz(), original);
            txtOrdenes.Text = resultado;
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            String original = "";
            String resultado;
            resultado = ServicioArbolBinario.recorrePostOrden(ServicioArbolBinario.getRaiz(), original);
            txtOrdenes.Text = resultado;
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            txtCadena.Clear();
            txtOrdenes.Clear();
            txtResultado.Clear();
        }

        private void btnGenerarArbol_Click(object sender, EventArgs e)
        {
            
            ServicioArbolBinario.procesarExpresion(txtCadena.Text);

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            String resultado;
            double numero;

            numero = ServicioArbolBinario.evaluarArbolExpresion();
            resultado = Convert.ToString(numero);

            txtResultado.Text = resultado;
        }





        //prueba para el boton de verificar si es atomica


        /*
        private void button2_Click(object sender, EventArgs e)
        {
            bool cadena = ServicioArbolBinario.verificarSiEsAtomica(txtCadena.Text.Trim());
            if(cadena ==true)
            {
                MessageBox.Show("Es operacion atomica");
            }
            else
            {
                MessageBox.Show("No es atomica");
            }
        }*/
    }
}
