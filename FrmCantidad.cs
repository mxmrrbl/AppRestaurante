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
            if (IsCanceled == true)
            {
                FrmRestaurante.Instancia.Show();
            }

            HideForm();
            
        }

        private void HideForm()
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
            try
            {
                string cantidad = TxtCantidadPersonas.Text;
                int intCantidad = Convert.ToInt32(TxtCantidadPersonas.Text);
                if (cantidad == null)
                {
                    MessageBox.Show("Debe ingresar una cantidad", "Advertencia");
                    TxtCantidadPersonas.Clear();
                    //FrmRestaurante.Instancia.Show();
                    
                }
                if (intCantidad <= 4)
                {
                    FrmOrden frmOrden = new FrmOrden();
                    frmOrden.Show();
                    this.Hide();
                    FrmRestaurante.Instancia.Hide();
                }
                if (intCantidad > 4)
                {
                    MessageBox.Show("No se admiten más de 4 personas por mesa", "Advertencia");
                    TxtCantidadPersonas.Clear();
                    //FrmRestaurante.Instancia.Show();
                    
                }
            }catch
            {
                MessageBox.Show("Debe ingresar una cantidad numérica", "Advertencia");
                TxtCantidadPersonas.Clear();
                //FrmRestaurante.Instancia.Show();
                
            }
        }

        private void FrmCantidad_Load(object sender, EventArgs e)
        {

        }

        public string GetCantidad() 
        {
            if (IsCanceled == true)
            {
                TxtCantidadPersonas.Text = "1";
                return TxtCantidadPersonas.Text;

                IsCanceled = false;
            }

            return TxtCantidadPersonas.Text.ToString();
            
            
        }
    }
}
