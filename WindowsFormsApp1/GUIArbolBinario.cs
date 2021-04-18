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
            ServicioArbolBinario.crearArbol(txtCadena.Text.Trim());
            String resultado = null;
            String cadena = ServicioArbolBinario.recorrePreOrden(ServicioArbolBinario.getRaiz(), resultado);
            txtOrdenes.Text = cadena;
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            ServicioArbolBinario.crearArbol(txtCadena.Text.Trim());
            String resultado = null;
            String cadena = ServicioArbolBinario.recorreInOrden(ServicioArbolBinario.getRaiz(), resultado);
            txtOrdenes.Text = cadena;
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            ServicioArbolBinario.crearArbol(txtCadena.Text.Trim());
            String resultado = null;
            String cadena = ServicioArbolBinario.recorrePostOrden(ServicioArbolBinario.getRaiz(), resultado);
            txtOrdenes.Text = cadena;
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            txtCadena.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cad = ServicioArbolBinario.quitarParentesisExternos(txtCadena.Text.Trim());
            ServicioArbolBinario.quitarEspacios(cad);
            ServicioArbolBinario.encontrarOperadorCentral(cad);
            txtCadena.Text = cad;
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
