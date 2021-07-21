
namespace Restaurante
{
    partial class FrmOrden
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAgregar2 = new System.Windows.Forms.Button();
            this.BtnCancelar2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblEntrada = new System.Windows.Forms.Label();
            this.LblPlatoFuerte = new System.Windows.Forms.Label();
            this.LblPostre = new System.Windows.Forms.Label();
            this.LblBebida = new System.Windows.Forms.Label();
            this.CbxEntrada = new System.Windows.Forms.ComboBox();
            this.CbxPlato = new System.Windows.Forms.ComboBox();
            this.CbxPostre = new System.Windows.Forms.ComboBox();
            this.CbxBebida = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LblMesa2 = new System.Windows.Forms.Label();
            this.LblOrden2 = new System.Windows.Forms.Label();
            this.TxtMesa2 = new System.Windows.Forms.TextBox();
            this.TxtOrden2 = new System.Windows.Forms.TextBox();
            this.LblNombe = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.BtnAgregar2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnCancelar2, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(14, 363);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(599, 65);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // BtnAgregar2
            // 
            this.BtnAgregar2.BackColor = System.Drawing.Color.SlateGray;
            this.BtnAgregar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAgregar2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregar2.Location = new System.Drawing.Point(3, 3);
            this.BtnAgregar2.Name = "BtnAgregar2";
            this.BtnAgregar2.Size = new System.Drawing.Size(293, 59);
            this.BtnAgregar2.TabIndex = 0;
            this.BtnAgregar2.Text = "Agregar";
            this.BtnAgregar2.UseVisualStyleBackColor = false;
            this.BtnAgregar2.Click += new System.EventHandler(this.Agregar2_Click);
            // 
            // BtnCancelar2
            // 
            this.BtnCancelar2.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancelar2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar2.Location = new System.Drawing.Point(302, 3);
            this.BtnCancelar2.Name = "BtnCancelar2";
            this.BtnCancelar2.Size = new System.Drawing.Size(294, 59);
            this.BtnCancelar2.TabIndex = 1;
            this.BtnCancelar2.Text = "Cancelar";
            this.BtnCancelar2.UseVisualStyleBackColor = false;
            this.BtnCancelar2.Click += new System.EventHandler(this.Cancelar2_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.86811F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.13189F));
            this.tableLayoutPanel3.Controls.Add(this.LblEntrada, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.LblPlatoFuerte, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.LblPostre, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.LblBebida, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.TxtNombre, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblNombe, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CbxEntrada, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.CbxPlato, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.CbxPostre, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.CbxBebida, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 92);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.98113F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.09434F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.28991F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.692F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.10454F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.46482F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(599, 265);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // LblEntrada
            // 
            this.LblEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEntrada.AutoSize = true;
            this.LblEntrada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEntrada.Location = new System.Drawing.Point(65, 68);
            this.LblEntrada.Name = "LblEntrada";
            this.LblEntrada.Size = new System.Drawing.Size(56, 17);
            this.LblEntrada.TabIndex = 0;
            this.LblEntrada.Text = "Entrada:";
            // 
            // LblPlatoFuerte
            // 
            this.LblPlatoFuerte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPlatoFuerte.AutoSize = true;
            this.LblPlatoFuerte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPlatoFuerte.Location = new System.Drawing.Point(41, 113);
            this.LblPlatoFuerte.Name = "LblPlatoFuerte";
            this.LblPlatoFuerte.Size = new System.Drawing.Size(80, 17);
            this.LblPlatoFuerte.TabIndex = 1;
            this.LblPlatoFuerte.Text = "Plato Fuerte:";
            // 
            // LblPostre
            // 
            this.LblPostre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPostre.AutoSize = true;
            this.LblPostre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPostre.Location = new System.Drawing.Point(73, 160);
            this.LblPostre.Name = "LblPostre";
            this.LblPostre.Size = new System.Drawing.Size(48, 17);
            this.LblPostre.TabIndex = 2;
            this.LblPostre.Text = "Postre:";
            // 
            // LblBebida
            // 
            this.LblBebida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblBebida.AutoSize = true;
            this.LblBebida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBebida.Location = new System.Drawing.Point(70, 213);
            this.LblBebida.Name = "LblBebida";
            this.LblBebida.Size = new System.Drawing.Size(51, 17);
            this.LblBebida.TabIndex = 3;
            this.LblBebida.Text = "Bebida:";
            // 
            // CbxEntrada
            // 
            this.CbxEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbxEntrada.FormattingEnabled = true;
            this.CbxEntrada.Location = new System.Drawing.Point(127, 59);
            this.CbxEntrada.Name = "CbxEntrada";
            this.CbxEntrada.Size = new System.Drawing.Size(221, 23);
            this.CbxEntrada.TabIndex = 4;
            // 
            // CbxPlato
            // 
            this.CbxPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbxPlato.FormattingEnabled = true;
            this.CbxPlato.Location = new System.Drawing.Point(127, 104);
            this.CbxPlato.Name = "CbxPlato";
            this.CbxPlato.Size = new System.Drawing.Size(221, 23);
            this.CbxPlato.TabIndex = 5;
            // 
            // CbxPostre
            // 
            this.CbxPostre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbxPostre.FormattingEnabled = true;
            this.CbxPostre.Location = new System.Drawing.Point(127, 151);
            this.CbxPostre.Name = "CbxPostre";
            this.CbxPostre.Size = new System.Drawing.Size(221, 23);
            this.CbxPostre.TabIndex = 6;
            // 
            // CbxBebida
            // 
            this.CbxBebida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbxBebida.FormattingEnabled = true;
            this.CbxBebida.Location = new System.Drawing.Point(127, 204);
            this.CbxBebida.Name = "CbxBebida";
            this.CbxBebida.Size = new System.Drawing.Size(221, 23);
            this.CbxBebida.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.288387F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.3606F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.52421F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.02504F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.18865F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.22037F));
            this.tableLayoutPanel2.Controls.Add(this.LblMesa2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblOrden2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtMesa2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtOrden2, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.01266F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.98734F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(599, 83);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // LblMesa2
            // 
            this.LblMesa2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMesa2.AutoSize = true;
            this.LblMesa2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMesa2.Location = new System.Drawing.Point(8, 50);
            this.LblMesa2.Name = "LblMesa2";
            this.LblMesa2.Size = new System.Drawing.Size(44, 17);
            this.LblMesa2.TabIndex = 0;
            this.LblMesa2.Text = "Mesa:";
            // 
            // LblOrden2
            // 
            this.LblOrden2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblOrden2.AutoSize = true;
            this.LblOrden2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOrden2.Location = new System.Drawing.Point(163, 50);
            this.LblOrden2.Name = "LblOrden2";
            this.LblOrden2.Size = new System.Drawing.Size(72, 17);
            this.LblOrden2.TabIndex = 1;
            this.LblOrden2.Text = "Orden No.";
            // 
            // TxtMesa2
            // 
            this.TxtMesa2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtMesa2.Location = new System.Drawing.Point(58, 41);
            this.TxtMesa2.Name = "TxtMesa2";
            this.TxtMesa2.ReadOnly = true;
            this.TxtMesa2.Size = new System.Drawing.Size(90, 23);
            this.TxtMesa2.TabIndex = 2;
            // 
            // TxtOrden2
            // 
            this.TxtOrden2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtOrden2.Location = new System.Drawing.Point(241, 41);
            this.TxtOrden2.Name = "TxtOrden2";
            this.TxtOrden2.ReadOnly = true;
            this.TxtOrden2.Size = new System.Drawing.Size(83, 23);
            this.TxtOrden2.TabIndex = 3;
            this.TxtOrden2.TextChanged += new System.EventHandler(this.TxtOrden2_TextChanged);
            // 
            // LblNombe
            // 
            this.LblNombe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNombe.AutoSize = true;
            this.LblNombe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNombe.Location = new System.Drawing.Point(59, 28);
            this.LblNombe.Name = "LblNombe";
            this.LblNombe.Size = new System.Drawing.Size(62, 17);
            this.LblNombe.TabIndex = 4;
            this.LblNombe.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtNombre.Location = new System.Drawing.Point(127, 19);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(135, 23);
            this.TxtNombre.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.757188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.64537F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.4377F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.7824F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.83619F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.53117F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 440);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FrmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 440);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmOrden";
            this.Text = "FrmOrden";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOrden_FormClosed);
            this.Load += new System.EventHandler(this.FrmOrden_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BtnAgregar2;
        private System.Windows.Forms.Button BtnCancelar2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LblEntrada;
        private System.Windows.Forms.Label LblPlatoFuerte;
        private System.Windows.Forms.Label LblPostre;
        private System.Windows.Forms.Label LblBebida;
        private System.Windows.Forms.ComboBox CbxEntrada;
        private System.Windows.Forms.ComboBox CbxPlato;
        private System.Windows.Forms.ComboBox CbxPostre;
        private System.Windows.Forms.ComboBox CbxBebida;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LblMesa2;
        private System.Windows.Forms.Label LblOrden2;
        private System.Windows.Forms.TextBox TxtMesa2;
        private System.Windows.Forms.TextBox TxtOrden2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblNombe;
        private System.Windows.Forms.TextBox TxtNombre;
    }
}