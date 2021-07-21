using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Restaurante.CustomControlItem;

namespace Restaurante
{
    public sealed partial class FrmRestaurante : Form
    {
        public static FrmRestaurante Instancia { get; } = new FrmRestaurante();

        private FrmRestaurante()
        {
            InitializeComponent();
        }
        public int Getmesa()
        {
            ComboBoxItem mesa = CbxMesa1.SelectedItem as ComboBoxItem;
            return (int)mesa.Value;
        }

        private void BtmAgregar_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCantidad cantidad = new FrmCantidad();
            cantidad.Show();
            this.Hide();
        }
        private void FrmRestaurante_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            listar();
            this.Hide();
        }
        private void listar()
        {

            FrmListaOrdenes Lista = new FrmListaOrdenes();
            Lista.Show();
        }
        private void FrmRestaurante_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }
        

        private void LoadComboBox()
        {
            ComboBoxItem porDefecto = new ComboBoxItem();
            porDefecto.Text = "Seleccione una opción";
            porDefecto.Value = null;

            ComboBoxItem Mesa1 = new ComboBoxItem();
            Mesa1.Text = "Mesa 1";
            Mesa1.Value = 1;

            ComboBoxItem Mesa2 = new ComboBoxItem();
            Mesa2.Text = "Mesa 2";
            Mesa2.Value = 2;

            ComboBoxItem Mesa3 = new ComboBoxItem();
            Mesa3.Text = "Mesa 3";
            Mesa3.Value = 3;

            ComboBoxItem Mesa4 = new ComboBoxItem();
            Mesa4.Text = "Mesa 4";
            Mesa4.Value = 4;

            CbxMesa1.Items.Add(porDefecto);
            CbxMesa1.Items.Add(Mesa1);
            CbxMesa1.Items.Add(Mesa2);
            CbxMesa1.Items.Add(Mesa3);
            CbxMesa1.Items.Add(Mesa4);
            CbxMesa1.SelectedItem = porDefecto;
        }

       
    }
}
