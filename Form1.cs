using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace divisao
{
    public partial class frmRestoDeDivisao : Form
    {
        public frmRestoDeDivisao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        int dividendo = Convert.ToInt32(txtDividendo.Text);
        int divisor = Convert.ToInt32(txtDivisor.Text);
        int resto = dividendo % divisor;
        txtRestoDivisao.Text = resto.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        int soma1 = Convert.ToInt32(txtSoma1.Text);
        int soma2 = Convert.ToInt32(txtSoma2.Text);
        int resultado = soma1 + soma2;
        txtRestoSoma.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        int subtracao1 = Convert.ToInt32(txtSubtracao1.Text);
        int subtracao2 = Convert.ToInt32(txtSubtracao2.Text);
        int resultado = subtracao1 - subtracao2;
        txtRestoSubtracao.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        int multiplicacao1 = Convert.ToInt32(txtMultiplicacao1.Text);
        int multiplicacao2 = Convert.ToInt32(txtMultiplicacao2.Text);
        int resultado = multiplicacao1 * multiplicacao2;
        txtRestoMultiplicacao.Text = resultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        int soma11 = Convert.ToInt32(txt5Numero11.Text);
        int soma22 = Convert.ToInt32(txt5Numero22.Text);
        int soma33 = Convert.ToInt32(txt5Numero33.Text);
        int soma44 = Convert.ToInt32(txt5Numero44.Text);
        int soma55 = Convert.ToInt32(txt5Numero55.Text);
        int resultado = (soma11 + soma22) * (soma33 + soma44) / soma55;
        txtResultado5Numero22.Text = resultado.ToString();

        }
    }
}
