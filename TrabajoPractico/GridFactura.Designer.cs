﻿
namespace TrabajoPractico
{
    partial class GridFactura
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
            this.dataGridDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDetalle
            // 
            this.dataGridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetalle.Location = new System.Drawing.Point(31, 32);
            this.dataGridDetalle.Name = "dataGridDetalle";
            this.dataGridDetalle.Size = new System.Drawing.Size(524, 256);
            this.dataGridDetalle.TabIndex = 0;
            this.dataGridDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GridFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 320);
            this.Controls.Add(this.dataGridDetalle);
            this.Name = "GridFactura";
            this.Text = "GridFactura";
            this.Load += new System.EventHandler(this.GridFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDetalle;
    }
}