namespace Exercicio2
{
    partial class Form1
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
            this.txtarquivo = new System.Windows.Forms.TextBox();
            this.lblarquivo = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtmostrar = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtarquivo
            // 
            this.txtarquivo.Location = new System.Drawing.Point(12, 34);
            this.txtarquivo.Name = "txtarquivo";
            this.txtarquivo.Size = new System.Drawing.Size(494, 20);
            this.txtarquivo.TabIndex = 2;
            // 
            // lblarquivo
            // 
            this.lblarquivo.AutoSize = true;
            this.lblarquivo.Location = new System.Drawing.Point(12, 18);
            this.lblarquivo.Name = "lblarquivo";
            this.lblarquivo.Size = new System.Drawing.Size(106, 13);
            this.lblarquivo.TabIndex = 3;
            this.lblarquivo.Text = "Escolha um arquivo :";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(15, 60);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(471, 23);
            this.btnProcurar.TabIndex = 4;
            this.btnProcurar.Text = "Open File";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtmostrar
            // 
            this.txtmostrar.Location = new System.Drawing.Point(12, 103);
            this.txtmostrar.Multiline = true;
            this.txtmostrar.Name = "txtmostrar";
            this.txtmostrar.Size = new System.Drawing.Size(494, 194);
            this.txtmostrar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 309);
            this.Controls.Add(this.txtmostrar);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.lblarquivo);
            this.Controls.Add(this.txtarquivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtarquivo;
        private System.Windows.Forms.Label lblarquivo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtmostrar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}

