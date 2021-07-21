﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;

namespace Restaurante
{
    public partial class FrmListaOrdenes : Form
    {
        private MantRestaurante mantenimiento;
        public FrmListaOrdenes()
        {
            InitializeComponent();
            mantenimiento = new MantRestaurante();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmRestaurante.Instancia.Show();
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Seguro que desea Limpiar?, se eliminarán todas las órdes de esta mesa.","Advertencia", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                MessageBox.Show("Se han eliminado las órdenes");
            }
            if (r == DialogResult.Cancel)
            {
            }
        }

        private void FrmListaOrdenes_Load(object sender, EventArgs e)
        {
            LoadOrdenes();
        }

        public void LoadOrdenes()
        {
            int mesa = FrmRestaurante.Instancia.Getmesa();

            LboxOrdenes.BeginUpdate();

            List<Orden> ordenes = mantenimiento.Visualizar(mesa);

            foreach (Orden item in ordenes)
            {
                LboxOrdenes.Items.Add(item.Datos);
            }

            LboxOrdenes.EndUpdate();
        }
    }
}