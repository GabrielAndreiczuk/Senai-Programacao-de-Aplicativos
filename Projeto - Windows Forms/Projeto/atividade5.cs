using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Projeto
{
    public partial class atividade5 : Form
    {
        public atividade5()
        {
            InitializeComponent();
        }

        private void atividade5_Load(object sender, EventArgs e)
        {

        }
        //LIMPAR TEXTO INICIAL DA TEXTBOX
        private void textBox1_Click(object sender, EventArgs e)
        {
            (sender as TextBox).Text = "";
        }
        //TRAVA DE CARACTERES TEXTBOX 
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc_Gasolina();
        }
        private void calc_Gasolina()
        {
            double preco, consumo, km, capacidade;
            bool converterPreco = double.TryParse(textBox2.Text, out preco);
            bool converterConsumo = double.TryParse(textBox1.Text, out consumo);
            bool converterKm = double.TryParse(textBox7.Text, out km);
            bool converterCapacidade = double.TryParse(textBox8.Text, out capacidade);
            if (converterPreco == true && converterConsumo == true && converterKm == true && converterCapacidade == true)
            {
                double totalGasto = (km / consumo) * preco;
                label14.Text = $"R${totalGasto:F2}";
                label15.Text = $"{(totalGasto / preco):F2}";
                label16.Text = $"{totalGasto / (capacidade * preco):F2}";
                label11.Show();
                label12.Show();
                label13.Show();
                label14.Show();
                label15.Show();
                label16.Show();
            }
            else
            {
                MessageBox.Show("Informe todos os valores corretamente!", "Atencão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calc_Alcool();
        }
        private void calc_Alcool()
        {
            double preco, consumo, km, capacidade;
            bool converterPreco = double.TryParse(textBox3.Text, out preco);
            bool converterConsumo = double.TryParse(textBox4.Text, out consumo);
            bool converterKm = double.TryParse(textBox7.Text, out km);
            bool converterCapacidade = double.TryParse(textBox8.Text, out capacidade);
            if (converterPreco == true && converterConsumo == true && converterKm == true && converterCapacidade == true)
            {
                double totalGasto = (km / consumo) * preco;
                label22.Text = $"R${totalGasto:F2}";
                label21.Text = $"{(totalGasto / preco):F2}";
                label20.Text = $"{totalGasto / (capacidade * preco):F2}";
                label17.Show();
                label18.Show();
                label19.Show();
                label20.Show();
                label21.Show();
                label22.Show();
            }
            else
            {
                MessageBox.Show("Informe todos os valores corretamente!", "Atencão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calc_Diesel();
        }
        private void calc_Diesel()
        {
            double preco, consumo, km, capacidade;
            bool converterPreco = double.TryParse(textBox5.Text, out preco);
            bool converterConsumo = double.TryParse(textBox6.Text, out consumo);
            bool converterKm = double.TryParse(textBox7.Text, out km);
            bool converterCapacidade = double.TryParse(textBox8.Text, out capacidade);
            if (converterPreco == true && converterConsumo == true && converterKm == true && converterCapacidade == true)
            {
                double totalGasto = (km / consumo) * preco;
                label28.Text = $"R${totalGasto:F2}";
                label27.Text = $"{(totalGasto / preco):F2}";
                label26.Text = $"{totalGasto / (capacidade * preco):F2}";
                label23.Show();
                label24.Show();
                label25.Show();
                label26.Show();
                label27.Show();
                label28.Show();
            }
            else
            {
                MessageBox.Show("Informe todos os valores corretamente!", "Atencão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            calc_Gasolina();
            calc_Alcool();
            calc_Diesel();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "INSIRA O CONSUMO";
            textBox2.Text = "INSIRA O PREÇO";
            textBox3.Text = "INSIRA O PREÇO";
            textBox4.Text = "INSIRA O CONSUMO";
            textBox5.Text = "INSIRA O PREÇO";
            textBox6.Text = "INSIRA O CONSUMO";
            textBox7.Text = "INSIRA DISTÂNCIA";
            textBox8.Text = "INSIRA CAPACIDADE";
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
            label17.Hide();
            label18.Hide();
            label19.Hide();
            label20.Hide();
            label21.Hide();
            label22.Hide();
            label23.Hide();
            label24.Hide();
            label25.Hide();
            label26.Hide();
            label27.Hide();
            label28.Hide();
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
