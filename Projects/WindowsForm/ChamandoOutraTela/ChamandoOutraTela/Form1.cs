using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamandoOutraTela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexecutar_Click(object sender, EventArgs e)
        {
            Boolean aug = false;
            for (int i = 0; i < txtnome.TextLength; i++)
            {
                if (char.IsDigit(txtnome.Text, i))
                {
                    aug = true;
                }
            }
            if (aug == true)
            {
                MessageBox.Show("Não é permitido digitar numeros!");
            }
            else
            {
                while (true) { 
                OutroForm segundoform = new OutroForm();
                segundoform.meutextbox.Text = txtnome.Text;
                segundoform.Show();
                }
            }
        }
    }
}
