using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            btnDepositar.BackColor = Color.Gainsboro;
            btnDepositar.ForeColor = Color.Black;

            btnSaque.BackColor = Color.LightBlue;
            btnSaque.ForeColor = Color.DodgerBlue;

            lblOperacao.Text = "Saque";




        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            Double valor;
            Double saldo;

            valor = double.Parse( txtValor.Text );
            // saldo = double.Parse( lblSaldo.Text );

            string novo_saldo;
            novo_saldo = lblSaldo.Text;
            //novo_saldo = novo_saldo.Substring(0, 2); =====>>>>> PRIMEIRA OPÇÃO PARA CORTAR O R$ NA SOMA, PARA QU
           
            novo_saldo = novo_saldo.Replace("R$", "");  // CORTAR O R$ DO TEXTO (REPLACE OU SUBSTRING)
            saldo = double.Parse(novo_saldo);

            double soma;
            

            if (lblOperacao.Text == "Saque")
            {
                 soma = saldo - valor;
            }
            else
            {
                 soma = valor + saldo;
            }

            lblSaldo.Text = "R$ " + soma;


        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            btnSaque.BackColor = Color.Gainsboro;
            btnSaque.ForeColor = Color.Black;

            btnDepositar.BackColor = Color.LightBlue;
            btnDepositar.ForeColor = Color.DodgerBlue;

            lblOperacao.Text = "Depósito";
        }
    }
}
