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
    public partial class atividade7 : Form
    {
        public atividade7()
        {
            InitializeComponent();
        }

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
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_calc_res_Click(object sender, EventArgs e)
        {
            double imc, peso, altura;
            bool converterPeso = double.TryParse(textBox1.Text, out peso);
            bool converterAltura = double.TryParse(textBox2.Text, out altura);
            if(converterPeso == true && converterAltura == true)
            {
                imc = peso / (altura * altura);
                label6.Text = imc.ToString("N2");
                if(imc >= 40){
                    label3.Text = "SITUACAO: OBESIDADE GRAU III (MORBIDA)";
                }else if (imc >= 35)
                {
                    label3.Text = "SITUACAO: OBESIDADE GRAU II (SEVERA)";
                }
                else if (imc >= 30)
                {
                    label3.Text = "SITUACAO: OBESIDADE GRAU I";
                }
                else if (imc >= 25)
                {
                    label3.Text = "LEVEMENTE ACIMA DO PESO";
                }
                else if (imc >= 18.6)
                {
                    label3.Text = "PESO IDEAL (PARABÉNS)";
                }
                else
                {
                    label3.Text = "ABAIXO DO PESO";
                }
                label2.Show();
                label3.Show();
                label6.Show();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "INSIRA PESO";
            textBox2.Text = "INSIRA ALTURA";
            label2.Hide();
            label3.Hide();
            label6.Hide();
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
