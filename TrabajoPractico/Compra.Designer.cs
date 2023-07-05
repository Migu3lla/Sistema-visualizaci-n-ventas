
namespace TrabajoPractico
{
    partial class Compra
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkIVA = new System.Windows.Forms.CheckBox();
            this.checkDescuento = new System.Windows.Forms.CheckBox();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.listProd = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.verDetalle = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkIVA
            // 
            this.checkIVA.AutoSize = true;
            this.checkIVA.Checked = true;
            this.checkIVA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIVA.Location = new System.Drawing.Point(249, 53);
            this.checkIVA.Name = "checkIVA";
            this.checkIVA.Size = new System.Drawing.Size(43, 17);
            this.checkIVA.TabIndex = 0;
            this.checkIVA.Text = "IVA";
            this.checkIVA.UseVisualStyleBackColor = true;
            this.checkIVA.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkDescuento
            // 
            this.checkDescuento.AutoSize = true;
            this.checkDescuento.Location = new System.Drawing.Point(249, 76);
            this.checkDescuento.Name = "checkDescuento";
            this.checkDescuento.Size = new System.Drawing.Size(78, 17);
            this.checkDescuento.TabIndex = 1;
            this.checkDescuento.Text = "Descuento";
            this.checkDescuento.UseVisualStyleBackColor = true;
            this.checkDescuento.CheckedChanged += new System.EventHandler(this.checkDescuento_CheckedChanged);
            // 
            // cmbPago
            // 
            this.cmbPago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Location = new System.Drawing.Point(249, 99);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(121, 21);
            this.cmbPago.TabIndex = 2;
            this.cmbPago.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.Location = new System.Drawing.Point(273, 195);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // listProd
            // 
            this.listProd.FormattingEnabled = true;
            this.listProd.Location = new System.Drawing.Point(25, 53);
            this.listProd.Name = "listProd";
            this.listProd.Size = new System.Drawing.Size(147, 69);
            this.listProd.TabIndex = 4;
            this.listProd.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Productos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // verDetalle
            // 
            this.verDetalle.Location = new System.Drawing.Point(273, 147);
            this.verDetalle.Name = "verDetalle";
            this.verDetalle.Size = new System.Drawing.Size(75, 23);
            this.verDetalle.TabIndex = 6;
            this.verDetalle.Text = "Detalle";
            this.verDetalle.UseVisualStyleBackColor = true;
            this.verDetalle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(62, 147);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(409, 242);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.verDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listProd);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbPago);
            this.Controls.Add(this.checkDescuento);
            this.Controls.Add(this.checkIVA);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Compra";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkIVA;
        private System.Windows.Forms.CheckBox checkDescuento;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox listProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button verDetalle;
        private System.Windows.Forms.Button btnAgregar;
    }
}

