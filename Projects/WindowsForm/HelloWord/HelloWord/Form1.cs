using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            Boolean qtd = false;
            Boolean qtd2 = false;


            for (int i = 0; i < txtnome.TextLength; i++)
			{
			   if (char.IsDigit(txtnome.Text,i)){
                 qtd = true;
               }
			}
            
            for (int i = 0; i < txtsobrenome.TextLength; i++)
            {
                 if (char.IsDigit(txtsobrenome.Text,i)){
                 qtd2 = true;
               }
            }
            if (qtd2 == true && qtd == true)
            {
                MessageBox.Show("Não é permitido digitar números");
            }
            if (qtd == false && qtd2 == false)
            {
               MessageBox.Show(txtnome.Text + " " + txtsobrenome.Text);
            }
         }

    }
}
