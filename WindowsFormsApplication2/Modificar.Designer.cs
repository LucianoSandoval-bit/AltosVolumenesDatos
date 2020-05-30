namespace WindowsFormsApplication2
{
    partial class Modificar
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TXT_RegistradoPor = new System.Windows.Forms.TextBox();
            this.TXT_Caracteristica = new System.Windows.Forms.TextBox();
            this.TXT_Estado = new System.Windows.Forms.TextBox();
            this.TXT_Region = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Registrado por";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Caracteristica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Estado con esta region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Region";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT_RegistradoPor
            // 
            this.TXT_RegistradoPor.Location = new System.Drawing.Point(56, 261);
            this.TXT_RegistradoPor.Name = "TXT_RegistradoPor";
            this.TXT_RegistradoPor.Size = new System.Drawing.Size(276, 22);
            this.TXT_RegistradoPor.TabIndex = 13;
            // 
            // TXT_Caracteristica
            // 
            this.TXT_Caracteristica.Location = new System.Drawing.Point(56, 201);
            this.TXT_Caracteristica.Name = "TXT_Caracteristica";
            this.TXT_Caracteristica.Size = new System.Drawing.Size(276, 22);
            this.TXT_Caracteristica.TabIndex = 12;
            // 
            // TXT_Estado
            // 
            this.TXT_Estado.Location = new System.Drawing.Point(56, 141);
            this.TXT_Estado.Name = "TXT_Estado";
            this.TXT_Estado.Size = new System.Drawing.Size(276, 22);
            this.TXT_Estado.TabIndex = 11;
            // 
            // TXT_Region
            // 
            this.TXT_Region.Location = new System.Drawing.Point(56, 80);
            this.TXT_Region.Name = "TXT_Region";
            this.TXT_Region.Size = new System.Drawing.Size(276, 22);
            this.TXT_Region.TabIndex = 10;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXT_RegistradoPor);
            this.Controls.Add(this.TXT_Caracteristica);
            this.Controls.Add(this.TXT_Estado);
            this.Controls.Add(this.TXT_Region);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXT_RegistradoPor;
        private System.Windows.Forms.TextBox TXT_Caracteristica;
        private System.Windows.Forms.TextBox TXT_Estado;
        private System.Windows.Forms.TextBox TXT_Region;
    }
}