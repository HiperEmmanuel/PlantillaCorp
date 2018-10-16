namespace PlantillaCorp
{
    partial class PlantillaCorp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantillaCorp));
            this.lista = new System.Windows.Forms.TextBox();
            this.plantilla = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Location = new System.Drawing.Point(13, 122);
            this.lista.Multiline = true;
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(168, 330);
            this.lista.TabIndex = 0;
            this.lista.Text = "Pegue aqui la lista de elementos";
            // 
            // plantilla
            // 
            this.plantilla.BackColor = System.Drawing.SystemColors.Info;
            this.plantilla.Location = new System.Drawing.Point(342, 12);
            this.plantilla.Multiline = true;
            this.plantilla.Name = "plantilla";
            this.plantilla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plantilla.Size = new System.Drawing.Size(343, 440);
            this.plantilla.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 103);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(202, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "----------------------------------->\r\nGenera codigo HTML, \r\na partir del numero d" +
    "e\r\n elementos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PlantillaCorp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(699, 464);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plantilla);
            this.Controls.Add(this.lista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlantillaCorp";
            this.Text = "PlantillaCorp v1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lista;
        private System.Windows.Forms.TextBox plantilla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

