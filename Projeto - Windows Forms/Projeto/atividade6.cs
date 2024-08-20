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
    public partial class atividade6 : Form
    {
        public atividade6()
        {
            InitializeComponent();
        }
        double temperatura, conversao;

        private void textBox_Click(object sender, EventArgs e)
        {
            (sender as TextBox).Text = "";
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números e vírgula!","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if((e.KeyChar == ',') && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool ConverterTemp = double.TryParse(textBox1.Text, out temperatura);
            if (ConverterTemp == true)
            {
                conversao = (temperatura * 1.8) + 32;
                label2.Text = $"{temperatura:F2}° C = {conversao:F2}° F";
                label2.Show();
            }
            else
            {
                MessageBox.Show("Informe um valor de temperatura para conversão!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ConverterTemp = double.TryParse(textBox1.Text, out temperatura);
            if (ConverterTemp == true)
            {
                conversao = (temperatura - 32) / 1.8;
                label2.Text = $"{temperatura:F2}° F = {conversao:F2}° C";
                label2.Show();
            }
            else
            {
                MessageBox.Show("Informe um valor de temperatura para conversão!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool ConverterTemp = double.TryParse(textBox1.Text, out temperatura);
            if (ConverterTemp == true)
            {
                conversao = temperatura  + 273.15;
                label2.Text = $"{temperatura:F2}° C = {conversao:F2}° K";
                label2.Show();
            }
            else
            {
                MessageBox.Show("Informe um valor de temperatura para conversão!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool ConverterTemp = double.TryParse(textBox1.Text, out temperatura);
            if (ConverterTemp == true)
            {
                conversao = temperatura - 273.15;
                label2.Text = $"{temperatura:F2}° K = {conversao:F2}° C";
                label2.Show();
            }
            else
            {
                MessageBox.Show("Informe um valor de temperatura para conversão!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            label2.Hide();
            textBox1.Text = "INSIRA TEMPERATURA";
            textBox1.Focus();
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
