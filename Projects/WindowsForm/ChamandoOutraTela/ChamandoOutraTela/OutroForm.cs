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
    public partial class OutroForm : Form
    {
        Form1 form1;
        public TextBox meutextbox
        {
            get { return this.txtrecebeu; }
        }
        public OutroForm()
        {
            InitializeComponent();
         
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
