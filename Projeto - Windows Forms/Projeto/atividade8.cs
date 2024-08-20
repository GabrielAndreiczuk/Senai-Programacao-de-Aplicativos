using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class atividade8 : Form
    {
        public atividade8()
        {
            InitializeComponent();
        }
        double preco;
        string nome, parcelas;

        private void textBox_Click(object sender, EventArgs e)
        {
            (sender as TextBox).Text = "";
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if((e.KeyChar == ',') && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool converterPreco = double.TryParse(textBox2.Text, out preco);
            if(converterPreco == true)
            {
                label5.Text = "COMPRA À VISTA (DINHEIRO OU PIX)";
                label3.Text = $"VALOR FINAL: R${preco * 0.85:F2}";
                label3.Show();
                label5.Show();
                label6.Hide();
                button5.Show();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os campos de nome e preço!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool converterPreco = double.TryParse(textBox2.Text, out preco);
            if (converterPreco == true)
            {
                label5.Text = "COMPRA À VISTA (CARTÃO DE CRÉDITO)";
                label3.Text = $"VALOR FINAL: R${preco * 0.9:F2}";
                label3.Show();
                label5.Show();
                label6.Hide();
                button5.Show();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os campos de nome e preço!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool converterPreco = double.TryParse(textBox2.Text, out preco);
            if (converterPreco == true)
            {
                label5.Text = "COMPRA PARCELADA (2X NO CARTÃO)";
                label3.Text = $"VALOR FINAL: R${preco:F2}";
                label6.Text = $"2 X DE R${preco/2}";
                label3.Show();
                label5.Show();
                label6.Show();
                button5.Show();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os campos de nome e preço!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

            bool converterPreco = double.TryParse(textBox2.Text, out preco);
            if (converterPreco == true)
            {
                nome = textBox1.Text;
                simularParcelas Form = new simularParcelas(nome, preco);
                Form.Closed += (s, args) => parcelas = Form.Parcelas;
                Form.Closed += (s, args) => AtribuirValores(parcelas);
                Form.Show();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os campos de nome e preço!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtribuirValores(string parcelas)
        {
            if(parcelas != "")
            {
                string[] textCbo = parcelas.Split(' ');
                double divisao = double.Parse(textCbo[0]);
                label5.Text = "COMPRA PARCELADA (3 OU MAIS X NO CARTÃO)";
                label3.Text = $"VALOR FINAL: R${preco * 1.1:F2}";
                label6.Text = $"{divisao} X DE R${(preco * 1.1) / divisao:F2}";
                label3.Show();
                label5.Show();
                label6.Show();
                button5.Show();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os campos de nome e preço!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "INSIRA PRODUTO";
            textBox2.Text = "INSIRA PREÇO";
            label3.Hide();
            label5.Hide();
            label6.Hide();
            button5.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sua compra foi finalizada com sucesso!","Parabéns!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            buttonClear_Click(null, null);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu Form = new menu();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }     
    }
}
