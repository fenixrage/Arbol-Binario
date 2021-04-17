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
            String cad= "";
            String cadena = txtCadena.Text.Trim();
            cad = ServicioArbolBinario.quitarParentesisExternos(txtCadena.Text.Trim());
            cad = ServicioArbolBinario.recorrePreOrden(ServicioArbolBinario.getRaiz(), cadena);

            txtOrdenes.Text = cad;
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            String cad = "";
            String cadena = txtCadena.Text.Trim();
            cad = ServicioArbolBinario.recorreInOrden(ServicioArbolBinario.getRaiz(), cadena);

            txtOrdenes.Text = cad;
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            String cad = "";
            String cadena = txtCadena.Text.Trim();
            cad = ServicioArbolBinario.recorrePostOrden(ServicioArbolBinario.getRaiz(), cadena);

            txtOrdenes.Text = cad;
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            txtCadena.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cad = ServicioArbolBinario.quitarParentesisExternos(txtCadena.Text);
            cad = ServicioArbolBinario.quitarEspacios(cad);

            txtCadena.Text = cad;
        }
    }
}
