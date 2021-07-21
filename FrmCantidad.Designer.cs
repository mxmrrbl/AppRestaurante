
namespace Restaurante
{
    partial class FrmCantidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblMesa = new System.Windows.Forms.Label();
            this.TxtCantidadPersonas = new System.Windows.Forms.TextBox();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnCancelar1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.546539F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.23627F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.97852F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnConfirmar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnCancelar1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.16667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.85549F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.43353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.54054F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(419, 173);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.94118F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.05882F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.LblMesa, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TxtCantidadPersonas, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(43, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(326, 44);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // LblMesa
            // 
            this.LblMesa.AutoSize = true;
            this.LblMesa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMesa.Location = new System.Drawing.Point(3, 23);
            this.LblMesa.Name = "LblMesa";
            this.LblMesa.Size = new System.Drawing.Size(182, 21);
            this.LblMesa.TabIndex = 3;
            this.LblMesa.Text = "Cantidad de personas:";
            // 
            // TxtCantidadPersonas
            // 
            this.TxtCantidadPersonas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtCantidadPersonas.Location = new System.Drawing.Point(191, 18);
            this.TxtCantidadPersonas.Name = "TxtCantidadPersonas";
            this.TxtCantidadPersonas.Size = new System.Drawing.Size(132, 23);
            this.TxtCantidadPersonas.TabIndex = 4;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConfirmar.Location = new System.Drawing.Point(43, 53);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(326, 37);
            this.BtnConfirmar.TabIndex = 4;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtmConfirmar_Click);
            // 
            // BtnCancelar1
            // 
            this.BtnCancelar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCancelar1.Location = new System.Drawing.Point(43, 96);
            this.BtnCancelar1.Name = "BtnCancelar1";
            this.BtnCancelar1.Size = new System.Drawing.Size(326, 38);
            this.BtnCancelar1.TabIndex = 5;
            this.BtnCancelar1.Text = "Cancelar";
            this.BtnCancelar1.UseVisualStyleBackColor = true;
            this.BtnCancelar1.Click += new System.EventHandler(this.BtmCancelar1_Click);
            // 
            // FrmCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 173);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCantidad";
            this.Text = "Cantidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCantidad_FormClosed);
            this.Load += new System.EventHandler(this.FrmCantidad_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LblMesa;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnCancelar1;
        private System.Windows.Forms.TextBox TxtCantidadPersonas;
    }
}