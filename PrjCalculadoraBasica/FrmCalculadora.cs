using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjCalculadoraBasica
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            double fator1, fator2, produto;
            fator1 = Double.Parse(tb_num1.Text);
            fator2 = Double.Parse(tb_num2.Text);
            produto = fator1 + fator2;
            tb_resultado.Text = produto.ToString();
            tb_resultado.Enabled = true;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double parcela1, parcela2, soma;
            parcela1 = Double.Parse(tb_num1.Text);
            parcela2 = Double.Parse(tb_num2.Text);
            soma = parcela1 + parcela2;
            tb_resultado.Text = soma.ToString();
            tb_resultado.Enabled = true;
        }

        private void btnDiferenca_Click(object sender, EventArgs e)
        {
            double minuendo, subtraendo, diferenca;
            minuendo = Double.Parse(tb_num1.Text);
            subtraendo = Double.Parse(tb_num2.Text);
            diferenca = minuendo - subtraendo;
            tb_resultado.Text = diferenca.ToString();
            tb_resultado.Enabled = true;
        }

        private void btnQuociente_Click(object sender, EventArgs e)
        {
            double dividendo, divisor, quociente;
            dividendo = Double.Parse(tb_num1.Text);
            divisor = Double.Parse(tb_num2.Text);
            if (divisor == 0) tb_resultado.Text = "Divisão por zero é indefinida";
            else {
                quociente = dividendo / divisor;
                tb_resultado.Text = quociente.ToString();
                tb_resultado.Enabled = true;
            }
        }

        private void btnResto_Click(object sender, EventArgs e)
        {
            double dividendo, divisor, resto;
            dividendo = Double.Parse(tb_num1.Text);
            divisor = Double.Parse(tb_num2.Text);
            if (dividendo % 1 != 0 && divisor % 1 != 0) tb_resultado.Text = "Valores não inteiros";
            else{
                resto = dividendo % divisor;
                tb_resultado.Text = resto.ToString();
                tb_resultado.Enabled = true;
            }
        }

        private void btnRaizquadrada_Click(object sender, EventArgs e)
        {
            double radicando, raiz;
            radicando = Double.Parse(tb_num1.Text);
            raiz = Math.Sqrt(radicando);
            tb_resultado.Text = raiz.ToString();
            tb_resultado.Enabled = true;
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            // base é um comando, por isso basee
            double basee, expoente, potencia;
            basee = Double.Parse(tb_num1.Text);
            expoente = Double.Parse(tb_num2.Text);
            potencia = Math.Pow(basee, expoente);
            tb_resultado.Text = potencia.ToString();
            tb_resultado.Enabled = true;
        }
        private void tb_num1_TextChanged(object sender, EventArgs e)
        {
            if (tb_num1.Text != null)
            {
                btnRaizquadrada.Enabled = true;
                tb_num2.Enabled = true;
            }
        }
        private void tb_num2_TextChanged(object sender, EventArgs e)
        {
            if (tb_num2.Text != null)
            {
                btnRaizquadrada.Enabled = false;
                tb_num2.Enabled = true;
                btnSoma.Enabled = true;
                btnResto.Enabled = true;
                btnQuociente.Enabled = true;
                btnProduto.Enabled = true;
                btnLimpar.Enabled = true;
                btnDiferenca.Enabled = true;
                btnPotencia.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tb_num1.Clear();
            tb_num2.Clear();
            tb_resultado.Clear();
            tb_num1.Focus();
            tb_num1.Enabled = true;
            btnLimpar.Enabled = false;
            btnResto.Enabled = false;
            btnProduto.Enabled = false;
            btnQuociente.Enabled = false;
            btnDiferenca.Enabled = false;
            btnSoma.Enabled = false;
            tb_num2.Enabled = false;
            tb_resultado.Enabled = false;
            btnPotencia.Enabled = false;
            
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            btnLimpar.Enabled = false;
            btnResto.Enabled = false;
            btnProduto.Enabled = false;
            btnQuociente.Enabled = false;
            btnDiferenca.Enabled = false;
            btnSoma.Enabled = false;
            tb_num2.Enabled = false;
            tb_resultado.Enabled = false;
            btnPotencia.Enabled = false;
        }
    }
}
