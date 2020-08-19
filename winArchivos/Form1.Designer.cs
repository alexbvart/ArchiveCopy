namespace winArchivos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCopiar = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelecciona = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.lbltitleNombreCopyArchivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(85, 224);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 0;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(25, 283);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(201, 23);
            this.txtSalida.TabIndex = 1;
            this.txtSalida.Text = "archivoCopy,abv";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelecciona
            // 
            this.btnSelecciona.Location = new System.Drawing.Point(85, 99);
            this.btnSelecciona.Name = "btnSelecciona";
            this.btnSelecciona.Size = new System.Drawing.Size(75, 23);
            this.btnSelecciona.TabIndex = 2;
            this.btnSelecciona.Text = "Selecciona un archivo";
            this.btnSelecciona.UseVisualStyleBackColor = true;
            this.btnSelecciona.Click += new System.EventHandler(this.btnSelecciona_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(25, 128);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(201, 23);
            this.txtRutaArchivo.TabIndex = 3;
            // 
            // lbltitleNombreCopyArchivo
            // 
            this.lbltitleNombreCopyArchivo.AutoSize = true;
            this.lbltitleNombreCopyArchivo.Location = new System.Drawing.Point(25, 263);
            this.lbltitleNombreCopyArchivo.Name = "lbltitleNombreCopyArchivo";
            this.lbltitleNombreCopyArchivo.Size = new System.Drawing.Size(86, 15);
            this.lbltitleNombreCopyArchivo.TabIndex = 4;
            this.lbltitleNombreCopyArchivo.Text = "Guardar como:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 450);
            this.Controls.Add(this.lbltitleNombreCopyArchivo);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.btnSelecciona);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.btnCopiar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelecciona;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Label lbltitleNombreCopyArchivo;
    }
}

