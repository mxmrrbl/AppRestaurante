using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurante
{
    public sealed partial class FrmCantidad : Form
    {
        public static FrmCantidad Instancia { get; } = new FrmCantidad();
        public bool IsCanceled { get; set; }
        private FrmCantidad()
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
            this.Hide();
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
            this.Hide();
            FrmRestaurante.Instancia.Hide();
        }

        private void FrmCantidad_Load(object sender, EventArgs e)
        {

        }

        public string GetCantidad() 
        {
            return TxtCantidadPersonas.Text.ToString();       
        }
    }
}
