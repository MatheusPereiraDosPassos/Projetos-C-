namespace ChamandoOutraTela
{
    partial class OutroForm
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
            this.txtrecebeu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtrecebeu
            // 
            this.txtrecebeu.Location = new System.Drawing.Point(74, 101);
            this.txtrecebeu.Name = "txtrecebeu";
            this.txtrecebeu.Size = new System.Drawing.Size(100, 20);
            this.txtrecebeu.TabIndex = 0;
            this.txtrecebeu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OutroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtrecebeu);
            this.Name = "OutroForm";
            this.Text = "OutroForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrecebeu;
    }
}