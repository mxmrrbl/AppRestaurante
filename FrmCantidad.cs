using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class FrmCantidad : Form
    {
        public bool IsCanceled { get; set; }
        public FrmCantidad()
        {
            InitializeComponent();
        }

        private void BtmCancelar1_Click(object sender, EventArgs e)
        {
            IsCanceled = true;
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void FrmCantidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsCanceled == true)
            {
                FrmRestaurante.Instancia.Show();
            }
        }

        private void BtmConfirmar_Click(object sender, EventArgs e)
        {
            FrmOrden frmOrden = new FrmOrden();
            frmOrden.Show();
            CloseForm();
            FrmRestaurante.Instancia.Hide();
        }

        private void FrmCantidad_Load(object sender, EventArgs e)
        {

        }
    }
}
