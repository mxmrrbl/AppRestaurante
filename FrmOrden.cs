using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Restaurante.CustomControlItem;
using BusinessLayer;

namespace Restaurante
{
    public partial class FrmOrden : Form
    {
        private string Cantidad { set; get; }

        private int NumOrden { set; get; }

        private MantRestaurante mantenimiento;

        private bool IsOpen { set; get; }

        public FrmOrden()
        {
            InitializeComponent();
            mantenimiento = new MantRestaurante();
            IsOpen = false;
            NumOrden = 1;
            
        }

        private void TxtOrden2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmOrden_Load(object sender, EventArgs e)
        {
            
            LoadComboBox();
            LoadInformation();
        }

        private void LoadInformation() 
        {
            int mesa = FrmRestaurante.Instancia.Getmesa();
                
            Cantidad = FrmCantidad.Instancia.GetCantidad();


            if (mesa == 1)
            {
                NumOrden = Repositorio.Instancia.ListadoOrdenes1.Count + 1;

            }
            if (mesa == 2)
            {
                NumOrden = Repositorio.Instancia.ListadoOrdenes2.Count + 1;

            }
            if (mesa == 3)
            {
                NumOrden = Repositorio.Instancia.ListadoOrdenes3.Count + 1;

            }
            if (mesa == 4)
            {
                NumOrden = Repositorio.Instancia.ListadoOrdenes4.Count + 1;

            }
            TxtMesa2.Text = Convert.ToString(FrmRestaurante.Instancia.Getmesa());
            TxtOrden2.Text = $"{NumOrden}";

            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Agregar2_Click(object sender, EventArgs e)
        {
            
            int cantidad;
            Cantidad = FrmCantidad.Instancia.GetCantidad();
            cantidad = Convert.ToInt32(Cantidad);
            Guardar();
            
            this.Close();
           
        }
        private void Guardar()
        {
            int mesa = FrmRestaurante.Instancia.Getmesa();

            Orden orden = new Orden();
            orden.Nombre = TxtNombre.Text;
            orden.Entrada = CbxEntrada.SelectedItem.ToString();
            orden.Plato = CbxPlato.SelectedItem.ToString();
            orden.Bebida = CbxBebida.SelectedItem.ToString();
            orden.Postre = CbxPostre.SelectedItem.ToString();

            mantenimiento.Agregar(mesa, orden);

        }

        private void Cancelar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOrden_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmRestaurante.Instancia.Show();
        }

        private void LoadComboBox()
        {
            ComboBoxItem porDefecto = new ComboBoxItem();
            porDefecto.Text = "Seleccione una opción";
            porDefecto.Value = null;

            //Entradas
            ComboBoxItem bruschettas = new ComboBoxItem();
            bruschettas.Text = "Bruchettas";
            bruschettas.Value = 1;

            ComboBoxItem croquetas1 = new ComboBoxItem();
            croquetas1.Text = "Croquetas de Zapallo";
            croquetas1.Value = 2;

            ComboBoxItem croquetas2 = new ComboBoxItem();
            croquetas2.Text = "Croquetas de Calabacín";
            croquetas2.Value = 3;

            ComboBoxItem salpicon = new ComboBoxItem();
            salpicon.Text = "Salpicón de Rape";
            salpicon.Value = 4;

            ComboBoxItem bocaditos = new ComboBoxItem();
            bocaditos.Text = "Bocaditos de Pollo";
            bocaditos.Value = 5;

            //Platos Fuertes
            ComboBoxItem pappa = new ComboBoxItem();
            pappa.Text = "Pappa al Pomodoro";
            pappa.Value = 6;

            ComboBoxItem risotto1 = new ComboBoxItem();
            risotto1.Text = "Risotto Cuatro Quesos";
            risotto1.Value = 7;

            ComboBoxItem risotto2 = new ComboBoxItem();
            risotto2.Text = "Risotto Bianco";
            risotto2.Value = 8;

            ComboBoxItem pizza = new ComboBoxItem();
            pizza.Text = "Pizza Carbonara";
            pizza.Value = 9;

            ComboBoxItem pasta = new ComboBoxItem();
            pasta.Text = "Pasta a la Amatriciana";
            pasta.Value = 10;

            ComboBoxItem rigatoni = new ComboBoxItem();
            rigatoni.Text = "Rigatoni alla Zozzona";
            rigatoni.Value = 11;

            ComboBoxItem espaguetis = new ComboBoxItem();
            espaguetis.Text = "Espaguetis a la Carbonara";
            espaguetis.Value = 12;

            ComboBoxItem pollo = new ComboBoxItem();
            pollo.Text = "Pollo all cacciatora";
            pollo.Value = 13;

            ComboBoxItem conejo = new ComboBoxItem();
            conejo.Text = "Conejo estofado";
            conejo.Value = 14;

            ComboBoxItem pez = new ComboBoxItem();
            pez.Text = "Pez Espada a la Siciliana";
            pez.Value = 15;

            //Bebidas
            ComboBoxItem limoncello = new ComboBoxItem();
            limoncello.Text = "Limoncello";
            limoncello.Value = 16;

            ComboBoxItem grappa = new ComboBoxItem();
            grappa.Text = "Grappa";
            grappa.Value = 17;

            ComboBoxItem strega = new ComboBoxItem();
            strega.Text = "Strega";
            strega.Value = 18;

            ComboBoxItem amaretto = new ComboBoxItem();
            amaretto.Text = "Amaretto";
            amaretto.Value = 19;

            ComboBoxItem fernet = new ComboBoxItem();
            fernet.Text = "Fernet";
            fernet.Value = 20;

            //Postres
            ComboBoxItem biscotti = new ComboBoxItem();
            biscotti.Text = "Biscotti";
            biscotti.Value = 21;

            ComboBoxItem castagnole = new ComboBoxItem();
            castagnole.Text = "Castagnole";
            castagnole.Value = 22;

            ComboBoxItem torta = new ComboBoxItem();
            torta.Text = "Torta Caprese";
            torta.Value = 23;

            ComboBoxItem tiramisú = new ComboBoxItem();
            tiramisú.Text = "Tiramisú";
            tiramisú.Value = 24;

            ComboBoxItem panna = new ComboBoxItem();
            panna.Text = "Panna Cotta";
            panna.Value = 25;

            CbxEntrada.Items.Add(porDefecto);
            CbxEntrada.Items.Add(bruschettas);
            CbxEntrada.Items.Add(croquetas1);
            CbxEntrada.Items.Add(croquetas2);
            CbxEntrada.Items.Add(salpicon);
            CbxEntrada.Items.Add(bocaditos);
            CbxEntrada.SelectedItem = porDefecto;

            CbxPlato.Items.Add(porDefecto);
            CbxPlato.Items.Add(pappa);
            CbxPlato.Items.Add(risotto1);
            CbxPlato.Items.Add(risotto2);
            CbxPlato.Items.Add(pizza);
            CbxPlato.Items.Add(pasta);
            CbxPlato.Items.Add(rigatoni);
            CbxPlato.Items.Add(espaguetis);
            CbxPlato.Items.Add(pollo);
            CbxPlato.Items.Add(conejo);
            CbxPlato.Items.Add(pez);
            CbxPlato.SelectedItem = porDefecto;

            CbxBebida.Items.Add(porDefecto);
            CbxBebida.Items.Add(limoncello);
            CbxBebida.Items.Add(grappa);
            CbxBebida.Items.Add(strega);
            CbxBebida.Items.Add(amaretto);
            CbxBebida.Items.Add(fernet);
            CbxBebida.SelectedItem = porDefecto;

            CbxPostre.Items.Add(porDefecto);
            CbxPostre.Items.Add(biscotti);
            CbxPostre.Items.Add(castagnole);
            CbxPostre.Items.Add(torta);
            CbxPostre.Items.Add(tiramisú);
            CbxPostre.Items.Add(panna);
            CbxPostre.SelectedItem = porDefecto;
        }
    }
}
