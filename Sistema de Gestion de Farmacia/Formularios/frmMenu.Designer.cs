namespace Sistema_de_Gestion_de_Farmacia
{
    partial class frmMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNREPORTES = new System.Windows.Forms.Button();
            this.BTNCONSULTAS = new System.Windows.Forms.Button();
            this.BTNVENTAS = new System.Windows.Forms.Button();
            this.BTNPRODUCTOS = new System.Windows.Forms.Button();
            this.BTNCLIENTES = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.BTNREPORTES);
            this.panel1.Controls.Add(this.BTNCONSULTAS);
            this.panel1.Controls.Add(this.BTNVENTAS);
            this.panel1.Controls.Add(this.BTNPRODUCTOS);
            this.panel1.Controls.Add(this.BTNCLIENTES);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 729);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FARMACIA SOLIDARIDAD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Gestion_de_Farmacia.Properties.Resources.istockphoto_1313889711_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(336, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(747, 597);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.frmMenu_Load);
            // 
            // BTNREPORTES
            // 
            this.BTNREPORTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNREPORTES.Image = global::Sistema_de_Gestion_de_Farmacia.Properties.Resources.informe;
            this.BTNREPORTES.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTNREPORTES.Location = new System.Drawing.Point(46, 571);
            this.BTNREPORTES.Name = "BTNREPORTES";
            this.BTNREPORTES.Size = new System.Drawing.Size(220, 49);
            this.BTNREPORTES.TabIndex = 5;
            this.BTNREPORTES.Text = "REPORTES";
            this.BTNREPORTES.UseVisualStyleBackColor = true;
            this.BTNREPORTES.Click += new System.EventHandler(this.BTNREPORTES_Click);
            // 
            // BTNCONSULTAS
            // 
            this.BTNCONSULTAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCONSULTAS.Image = global::Sistema_de_Gestion_de_Farmacia.Properties.Resources.consulta;
            this.BTNCONSULTAS.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTNCONSULTAS.Location = new System.Drawing.Point(46, 468);
            this.BTNCONSULTAS.Name = "BTNCONSULTAS";
            this.BTNCONSULTAS.Size = new System.Drawing.Size(220, 48);
            this.BTNCONSULTAS.TabIndex = 4;
            this.BTNCONSULTAS.Text = "CONSULTAS";
            this.BTNCONSULTAS.UseVisualStyleBackColor = true;
            this.BTNCONSULTAS.Click += new System.EventHandler(this.BTNCONSULTAS_Click);
            // 
            // BTNVENTAS
            // 
            this.BTNVENTAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVENTAS.Image = global::Sistema_de_Gestion_de_Farmacia.Properties.Resources.compras;
            this.BTNVENTAS.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTNVENTAS.Location = new System.Drawing.Point(46, 361);
            this.BTNVENTAS.Name = "BTNVENTAS";
            this.BTNVENTAS.Size = new System.Drawing.Size(220, 48);
            this.BTNVENTAS.TabIndex = 3;
            this.BTNVENTAS.Text = "VENTAS";
            this.BTNVENTAS.UseVisualStyleBackColor = true;
            this.BTNVENTAS.Click += new System.EventHandler(this.BTNVENTAS_Click);
            // 
            // BTNPRODUCTOS
            // 
            this.BTNPRODUCTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPRODUCTOS.Image = global::Sistema_de_Gestion_de_Farmacia.Properties.Resources.agregar_producto__1_;
            this.BTNPRODUCTOS.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTNPRODUCTOS.Location = new System.Drawing.Point(46, 252);
            this.BTNPRODUCTOS.Name = "BTNPRODUCTOS";
            this.BTNPRODUCTOS.Size = new System.Drawing.Size(220, 49);
            this.BTNPRODUCTOS.TabIndex = 2;
            this.BTNPRODUCTOS.Text = "PRODUCTOS";
            this.BTNPRODUCTOS.UseVisualStyleBackColor = true;
            this.BTNPRODUCTOS.Click += new System.EventHandler(this.BTNPRODUCTOS_Click);
            // 
            // BTNCLIENTES
            // 
            this.BTNCLIENTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCLIENTES.Image = global::Sistema_de_Gestion_de_Farmacia.Properties.Resources.nueva_cuenta;
            this.BTNCLIENTES.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTNCLIENTES.Location = new System.Drawing.Point(46, 147);
            this.BTNCLIENTES.Name = "BTNCLIENTES";
            this.BTNCLIENTES.Size = new System.Drawing.Size(220, 48);
            this.BTNCLIENTES.TabIndex = 1;
            this.BTNCLIENTES.Text = "CLIENTES";
            this.BTNCLIENTES.UseVisualStyleBackColor = true;
            this.BTNCLIENTES.Click += new System.EventHandler(this.BTNCLIENTES_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1154, 730);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNCLIENTES;
        private System.Windows.Forms.Button BTNREPORTES;
        private System.Windows.Forms.Button BTNCONSULTAS;
        private System.Windows.Forms.Button BTNVENTAS;
        private System.Windows.Forms.Button BTNPRODUCTOS;
    }
}

