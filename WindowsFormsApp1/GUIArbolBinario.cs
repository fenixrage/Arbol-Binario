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
            String cadena = ServicioArbolBinario.recorrePreOrden(ServicioArbolBinario.getRaiz(), txtCadena.Text.Trim());
            txtOrdenes.Text = cadena;
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            String cadena = ServicioArbolBinario.recorreInOrden(ServicioArbolBinario.getRaiz(), txtCadena.Text.Trim());
            txtOrdenes.Text = cadena;
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            String cadena = ServicioArbolBinario.recorrePostOrden(ServicioArbolBinario.getRaiz(), txtCadena.Text.Trim());
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
    }
}
