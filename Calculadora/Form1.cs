using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operador;
        float a = 0;
        bool validar = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                lbl.Text = lbl.Text + txtValor.Text + "="; //O lbl recebe 
                txtValor.Text = Convert.ToString(a + Convert.ToSingle(txtValor.Text));
            }
            else if (operador == "-")
            {
                lbl.Text = lbl.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a - Convert.ToSingle(txtValor.Text));
            }
            else if (operador == "*")
            {
                lbl.Text = lbl.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a * Convert.ToSingle(txtValor.Text));
            }
            else if (operador == "/")
            {
                lbl.Text = lbl.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a / Convert.ToSingle(txtValor.Text));
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            lbl.Text = "";
            a = 0;
            validar = false; 
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToSingle(txtValor.Text); // Armazena e calcula o valor que será exibido no Lbl;
                lbl.Text = Convert.ToString(a) + "+"; // Converte e exibe o valor de a; 
                txtValor.Text = ""; // Limpa o campo txtValor;
                operador = "+";
            }
            else
            {
                lbl.Text = txtValor.Text + btnAdicao.Text;
                a = Convert.ToSingle(txtValor.Text);
                txtValor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                    a = a - Convert.ToSingle(txtValor.Text);
                    lbl.Text = Convert.ToString(a) + "-";
                    txtValor.Text = "";
                    operador = "-";
            }
            else
            {
                lbl.Text = txtValor.Text + btnSubtracao.Text;
                a = Convert.ToSingle(txtValor.Text);
                txtValor.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a*Convert.ToSingle(txtValor.Text);
                lbl.Text = Convert.ToString(a) + "*";
                txtValor.Text = "";
                operador = "*";
            }
            else
            {
                lbl.Text = txtValor.Text + btnMultiplicacao.Text;
                a = Convert.ToSingle(txtValor.Text);
                txtValor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToSingle(txtValor.Text);
                lbl.Text = Convert.ToString(a) + "/";
                txtValor.Text = "";
                operador = "/";
            }
            else
            {
                lbl.Text = txtValor.Text + btnDivisao.Text;
                a = Convert.ToSingle(txtValor.Text);
                txtValor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
