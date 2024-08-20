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
    public partial class simularParcelas : Form
    {
        
        public simularParcelas(string nome, double preco)
        {
            InitializeComponent();
            label1.Text = "PRODUTO: " + nome;
            label2.Text = $"PREÇO: R${preco:F2}";
        }
        public string Parcelas
        {          
            get { return comboBox1.Text; }
        }

        private void simularParcelas_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] textoParcelas = comboBox1.Text.Split(' ');
            double parcelas = double.Parse(textoParcelas[0]);
            string[] textoPreco = label2.Text.Split('$');
            double preco = double.Parse( textoPreco[1]);
            label5.Text = $"VALOR FINAL: R${preco * 1.1:F2}";
            label6.Text = $"{comboBox1.Text} DE R${(preco * 1.1) / parcelas:F2}";
            label5.Show();
            label6.Show();
            button5.Show();
        }
    }
}
