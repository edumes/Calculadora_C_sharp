using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = "";
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);

            double soma = n1 + n2;
            string resultado = (lbl_resultado.Text + soma.ToString());
            lbl_resultado.Text = resultado;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = "";
        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = "";
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);

            double soma = n1 - n2;
            string resultado = (lbl_resultado.Text + soma.ToString());
            lbl_resultado.Text = resultado;
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = "";
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);

            double soma = n1 * n2;
            string resultado = (lbl_resultado.Text + soma.ToString());
            lbl_resultado.Text = resultado;
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = "";
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);

            double soma = n1 / n2;
            string resultado = (lbl_resultado.Text + soma.ToString());
            lbl_resultado.Text = resultado;
        }
    }
}
