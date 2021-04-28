﻿
namespace presentacion
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.ListarMarcas = new System.Windows.Forms.Button();
            this.ListarCategorias = new System.Windows.Forms.Button();
            this.dGVArticulos = new System.Windows.Forms.DataGridView();
            this.pBMarcas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // ListarMarcas
            // 
            this.ListarMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListarMarcas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ListarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarMarcas.ForeColor = System.Drawing.Color.Black;
            this.ListarMarcas.Location = new System.Drawing.Point(616, 322);
            this.ListarMarcas.Name = "ListarMarcas";
            this.ListarMarcas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListarMarcas.Size = new System.Drawing.Size(109, 37);
            this.ListarMarcas.TabIndex = 0;
            this.ListarMarcas.Text = "Listar Marcas";
            this.ListarMarcas.UseVisualStyleBackColor = true;
            this.ListarMarcas.Click += new System.EventHandler(this.ListarMarcas_Click);
            // 
            // ListarCategorias
            // 
            this.ListarCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ListarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarCategorias.ForeColor = System.Drawing.Color.Black;
            this.ListarCategorias.Location = new System.Drawing.Point(501, 322);
            this.ListarCategorias.Name = "ListarCategorias";
            this.ListarCategorias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListarCategorias.Size = new System.Drawing.Size(109, 37);
            this.ListarCategorias.TabIndex = 1;
            this.ListarCategorias.Text = "Listar Categorias";
            this.ListarCategorias.UseVisualStyleBackColor = true;
            // 
            // dGVArticulos
            // 
            this.dGVArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVArticulos.Location = new System.Drawing.Point(12, 26);
            this.dGVArticulos.Name = "dGVArticulos";
            this.dGVArticulos.Size = new System.Drawing.Size(479, 265);
            this.dGVArticulos.TabIndex = 2;
            // 
            // pBMarcas
            // 
            this.pBMarcas.Location = new System.Drawing.Point(535, 79);
            this.pBMarcas.Name = "pBMarcas";
            this.pBMarcas.Size = new System.Drawing.Size(169, 159);
            this.pBMarcas.TabIndex = 3;
            this.pBMarcas.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(737, 371);
            this.Controls.Add(this.pBMarcas);
            this.Controls.Add(this.dGVArticulos);
            this.Controls.Add(this.ListarCategorias);
            this.Controls.Add(this.ListarMarcas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogador de articulos";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListarMarcas;
        private System.Windows.Forms.Button ListarCategorias;
        private System.Windows.Forms.DataGridView dGVArticulos;
        private System.Windows.Forms.PictureBox pBMarcas;
    }
}

