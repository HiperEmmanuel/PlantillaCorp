namespace PlantillaCorp
{
    partial class Form1
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
            this.lista = new System.Windows.Forms.TextBox();
            this.plantilla = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Location = new System.Drawing.Point(13, 13);
            this.lista.Multiline = true;
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(100, 236);
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
            this.plantilla.Size = new System.Drawing.Size(343, 237);
            this.plantilla.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plantilla);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lista;
        private System.Windows.Forms.TextBox plantilla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

