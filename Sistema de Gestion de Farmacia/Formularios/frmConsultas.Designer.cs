namespace Sistema_de_Gestion_de_Farmacia.Formularios
{
    partial class frmConsultas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lINQTOOBJECTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosConStockBajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosOrdenadosPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosMásCarosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesOrdenadosPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasMayoresA50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosSinStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeMayorValorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeMenorValorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONSULTAS";
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(12, 118);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.RowHeadersWidth = 51;
            this.dgvConsultas.RowTemplate.Height = 24;
            this.dgvConsultas.Size = new System.Drawing.Size(897, 402);
            this.dgvConsultas.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lINQTOOBJECTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lINQTOOBJECTToolStripMenuItem
            // 
            this.lINQTOOBJECTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosConStockBajoToolStripMenuItem,
            this.productosOrdenadosPorNombreToolStripMenuItem,
            this.productosMásCarosToolStripMenuItem,
            this.clientesOrdenadosPorNombreToolStripMenuItem,
            this.ventasMayoresA50ToolStripMenuItem,
            this.productosSinStockToolStripMenuItem,
            this.ventaDeMayorValorToolStripMenuItem,
            this.ventaDeMenorValorToolStripMenuItem});
            this.lINQTOOBJECTToolStripMenuItem.Name = "lINQTOOBJECTToolStripMenuItem";
            this.lINQTOOBJECTToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.lINQTOOBJECTToolStripMenuItem.Text = "LINQ TO OBJECT";
            // 
            // productosConStockBajoToolStripMenuItem
            // 
            this.productosConStockBajoToolStripMenuItem.Name = "productosConStockBajoToolStripMenuItem";
            this.productosConStockBajoToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.productosConStockBajoToolStripMenuItem.Text = "Productos con stock bajo";
            this.productosConStockBajoToolStripMenuItem.Click += new System.EventHandler(this.productosConStockBajoToolStripMenuItem_Click);
            // 
            // productosOrdenadosPorNombreToolStripMenuItem
            // 
            this.productosOrdenadosPorNombreToolStripMenuItem.Name = "productosOrdenadosPorNombreToolStripMenuItem";
            this.productosOrdenadosPorNombreToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.productosOrdenadosPorNombreToolStripMenuItem.Text = "Productos ordenados por nombre";
            this.productosOrdenadosPorNombreToolStripMenuItem.Click += new System.EventHandler(this.productosOrdenadosPorNombreToolStripMenuItem_Click);
            // 
            // productosMásCarosToolStripMenuItem
            // 
            this.productosMásCarosToolStripMenuItem.Name = "productosMásCarosToolStripMenuItem";
            this.productosMásCarosToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.productosMásCarosToolStripMenuItem.Text = "Productos más caros";
            this.productosMásCarosToolStripMenuItem.Click += new System.EventHandler(this.productosMásCarosToolStripMenuItem_Click);
            // 
            // clientesOrdenadosPorNombreToolStripMenuItem
            // 
            this.clientesOrdenadosPorNombreToolStripMenuItem.Name = "clientesOrdenadosPorNombreToolStripMenuItem";
            this.clientesOrdenadosPorNombreToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.clientesOrdenadosPorNombreToolStripMenuItem.Text = "Clientes ordenados por nombre";
            this.clientesOrdenadosPorNombreToolStripMenuItem.Click += new System.EventHandler(this.clientesOrdenadosPorNombreToolStripMenuItem_Click);
            // 
            // ventasMayoresA50ToolStripMenuItem
            // 
            this.ventasMayoresA50ToolStripMenuItem.Name = "ventasMayoresA50ToolStripMenuItem";
            this.ventasMayoresA50ToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.ventasMayoresA50ToolStripMenuItem.Text = "Ventas mayores a $50";
            this.ventasMayoresA50ToolStripMenuItem.Click += new System.EventHandler(this.ventasMayoresA50ToolStripMenuItem_Click);
            // 
            // productosSinStockToolStripMenuItem
            // 
            this.productosSinStockToolStripMenuItem.Name = "productosSinStockToolStripMenuItem";
            this.productosSinStockToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.productosSinStockToolStripMenuItem.Text = "Productos sin stock";
            this.productosSinStockToolStripMenuItem.Click += new System.EventHandler(this.productosSinStockToolStripMenuItem_Click);
            // 
            // ventaDeMayorValorToolStripMenuItem
            // 
            this.ventaDeMayorValorToolStripMenuItem.Name = "ventaDeMayorValorToolStripMenuItem";
            this.ventaDeMayorValorToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.ventaDeMayorValorToolStripMenuItem.Text = "Venta de mayor valor";
            this.ventaDeMayorValorToolStripMenuItem.Click += new System.EventHandler(this.ventaDeMayorValorToolStripMenuItem_Click);
            // 
            // ventaDeMenorValorToolStripMenuItem
            // 
            this.ventaDeMenorValorToolStripMenuItem.Name = "ventaDeMenorValorToolStripMenuItem";
            this.ventaDeMenorValorToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.ventaDeMenorValorToolStripMenuItem.Text = "Venta de menor valor";
            this.ventaDeMenorValorToolStripMenuItem.Click += new System.EventHandler(this.ventaDeMenorValorToolStripMenuItem_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 554);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmConsultas";
            this.Text = "frmConsultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lINQTOOBJECTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosConStockBajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosOrdenadosPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosMásCarosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesOrdenadosPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasMayoresA50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosSinStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeMayorValorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeMenorValorToolStripMenuItem;
    }
}