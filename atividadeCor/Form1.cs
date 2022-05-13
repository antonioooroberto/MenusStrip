using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeCor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnselecionar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);
            int num3 = int.Parse(txtnum3.Text);

            if (num1 >= num3)
            {
                MessageBox.Show("Verde");
            }
            else
            {
                MessageBox.Show("O numero 1 não é maior do que o numero 3");
            }
            if (num2 == num1)
            {
                MessageBox.Show("Amarelo");
            }
            else
            {
                MessageBox.Show("O numero 2 não é igual ao numero 1");
            }
            if (num3 > 5 )
            {
                MessageBox.Show("azul");
            }
            else
            {
                MessageBox.Show("O numero 3 não é maior do que 5");
            }
            if (num2 != 0)
            {
                MessageBox.Show("branco");
            }
            else
            {
                MessageBox.Show("O numero 2 não é igual a 0");
            }
        }
    }
}
