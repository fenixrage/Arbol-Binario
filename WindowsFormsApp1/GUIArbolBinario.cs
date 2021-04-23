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

        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            txtCadena.Clear();
            txtOrdenes.Clear();
            txtResultado.Clear();
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
