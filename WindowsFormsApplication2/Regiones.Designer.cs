namespace WindowsFormsApplication2
{
    partial class Regiones
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechasDeModificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DG_Data = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistradoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caracteristica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoConEstaRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // regionToolStripMenuItem
            // 
            this.regionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.cambioToolStripMenuItem,
            this.fechasDeModificacionToolStripMenuItem});
            this.regionToolStripMenuItem.Name = "regionToolStripMenuItem";
            this.regionToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.regionToolStripMenuItem.Text = "Region";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.bajaToolStripMenuItem.Text = "Baja";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // cambioToolStripMenuItem
            // 
            this.cambioToolStripMenuItem.Name = "cambioToolStripMenuItem";
            this.cambioToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.cambioToolStripMenuItem.Text = "Cambio";
            this.cambioToolStripMenuItem.Click += new System.EventHandler(this.cambioToolStripMenuItem_Click);
            // 
            // fechasDeModificacionToolStripMenuItem
            // 
            this.fechasDeModificacionToolStripMenuItem.Name = "fechasDeModificacionToolStripMenuItem";
            this.fechasDeModificacionToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.fechasDeModificacionToolStripMenuItem.Text = "Fechas de Modificacion";
            this.fechasDeModificacionToolStripMenuItem.Click += new System.EventHandler(this.fechasDeModificacionToolStripMenuItem_Click);
            // 
            // DG_Data
            // 
            this.DG_Data.AllowUserToAddRows = false;
            this.DG_Data.AllowUserToDeleteRows = false;
            this.DG_Data.AllowUserToOrderColumns = true;
            this.DG_Data.AllowUserToResizeColumns = false;
            this.DG_Data.AllowUserToResizeRows = false;
            this.DG_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Region,
            this.DiaRegistro,
            this.RegistradoPor,
            this.Caracteristica,
            this.EstadoConEstaRegion});
            this.DG_Data.Location = new System.Drawing.Point(0, 67);
            this.DG_Data.Name = "DG_Data";
            this.DG_Data.RowHeadersVisible = false;
            this.DG_Data.RowHeadersWidth = 51;
            this.DG_Data.RowTemplate.Height = 24;
            this.DG_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Data.Size = new System.Drawing.Size(649, 389);
            this.DG_Data.TabIndex = 1;
            this.DG_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Region
            // 
            this.Region.DataPropertyName = "REGION";
            this.Region.HeaderText = "Region";
            this.Region.MinimumWidth = 6;
            this.Region.Name = "Region";
            // 
            // DiaRegistro
            // 
            this.DiaRegistro.DataPropertyName = "Fecharg";
            this.DiaRegistro.HeaderText = "Dia de registro";
            this.DiaRegistro.MinimumWidth = 6;
            this.DiaRegistro.Name = "DiaRegistro";
            // 
            // RegistradoPor
            // 
            this.RegistradoPor.DataPropertyName = "RegistradoPor";
            this.RegistradoPor.HeaderText = "Registrado por";
            this.RegistradoPor.MinimumWidth = 6;
            this.RegistradoPor.Name = "RegistradoPor";
            // 
            // Caracteristica
            // 
            this.Caracteristica.DataPropertyName = "Caracteristica";
            this.Caracteristica.HeaderText = "Caracteristica";
            this.Caracteristica.MinimumWidth = 6;
            this.Caracteristica.Name = "Caracteristica";
            // 
            // EstadoConEstaRegion
            // 
            this.EstadoConEstaRegion.DataPropertyName = "EstadoConEstaRegion";
            this.EstadoConEstaRegion.HeaderText = "Estado con esta region";
            this.EstadoConEstaRegion.MinimumWidth = 6;
            this.EstadoConEstaRegion.Name = "EstadoConEstaRegion";
            // 
            // Regiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 458);
            this.Controls.Add(this.DG_Data);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Regiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regiones";
            this.Load += new System.EventHandler(this.Regiones_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioToolStripMenuItem;
        private System.Windows.Forms.DataGridView DG_Data;
        private System.Windows.Forms.ToolStripMenuItem fechasDeModificacionToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistradoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caracteristica;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoConEstaRegion;
    }
}