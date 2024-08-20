using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Projeto
{
    public partial class atividade1 : Form
    {
        public atividade1()
        {
            InitializeComponent();            
        }

        private void atividade1_Load(object sender, EventArgs e)
        {

        }
        //LIMPAR TEXTO INICIAL DA TEXTBOX 1
        public void textBoxR1_Click(object sender, EventArgs e)
        {
            textBoxR1.Text = "";
        }
        //LIMPAR TEXTO INICIAL DA TEXTBOX 2
        private void textBoxR2_Click(object sender, EventArgs e)
        {
            textBoxR2.Text = "";
        }
        //LIMPAR TEXTO INICIAL DA TEXTBOX 3
        private void textBoxR3_Click(object sender, EventArgs e)
        {
            textBoxR3.Text = "";
        }

        //PROGRAMAÇÃO BOTÃO DESCOBRIR VALOR DA RESISTÊNCIA
        private void button_calc_res_Click(object sender, EventArgs e)
        {
            string textResistor = "";
            calcResistencia form = new calcResistencia();
            form.Closed += (s, args) => textResistor = form.Resistor;
            form.Closed += (s, args) => atribuir_valor(textResistor);
            form.Show();
        } 

        //FUNÇÃO ATRIBUIR VALOR VINDO DO CALCULO DE RESISTOR
        private void atribuir_valor(string textResistor)
        {
            //VERIFICA SE O USUÁRIO FECHOU A PÁGINA ANTES DO RESULTADO SER CALCULADO
            if (!(textResistor == "-"))
            {
                //DENTRO DESTA FUNÇÃO IDENTIFICAR QUAL RESISTOR ESTA FALTANDO
                string[] divTextResistor = textResistor.Split('Ω');
                if (textBoxR1.Text == "INSIRA R1" || textBoxR1.Text == "")
                {
                    textBoxR1.Text = divTextResistor[0];
                }
                else if (textBoxR2.Text == "INSIRA R2" || textBoxR2.Text == "")
                {
                    textBoxR2.Text = divTextResistor[0];
                }
                else
                {
                    textBoxR3.Text = divTextResistor[0];
                }
            }
        }

        //PROGRAMAÇÃO BOTÃO CALCULAR RESISTÊNCIAS
        private void button1_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, serie, paralelo;
            //VERIFICAÇÃO SE O VALOR INFORMADO NA TEXTBOX É UM NÚMERO
            bool converterR1 = double.TryParse(textBoxR1.Text, out R1);
            bool converterR2 = double.TryParse(textBoxR2.Text, out R2);
            bool converterR3 = double.TryParse(textBoxR3.Text, out R3);
            if(converterR1 == true && converterR2 == true && converterR3 == true)
            {          
                serie = R1 + R2 + R3;
                paralelo = 1 / (1 / R1 + 1 / R2 + 1 / R3);
                label7.Text = $"{serie} Ω";
                label8.Text = $"{paralelo:F2} Ω";
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
            }
            else
            {
                MessageBox.Show("Informe todos os valores de resistência!","Atencão!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        //PROGRAMAÇÃO BOTÃO LIMPAR VALORES
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxR1.Text = "INSIRA R1";
            textBoxR2.Text = "INSIRA R2";
            textBoxR3.Text = "INSIRA R3";
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
        }

        //PROGRAMAÇÃO BOTÃO VOLTAR PARAR O MENU
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu form = new menu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        //TRAVA DE CARACTERES TEXTBOX 1
        private void textBoxR1_KeyPress(object sender, KeyPressEventArgs e)
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
        //TRAVA DE CARACTERES TEXTBOX 2
        private void textBoxR2_KeyPress(object sender, KeyPressEventArgs e)
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
        //TRAVA DE CARACTERES TEXTBOX 3
        private void textBoxR3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula.","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
