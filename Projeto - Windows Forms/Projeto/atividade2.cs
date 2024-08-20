using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto
{
    public partial class atividade2 : Form
    {
        public atividade2()
        {
            InitializeComponent();
        }

        private void atividade2_Load(object sender, EventArgs e)
        {

        }
        //LIMPAR APÓS CLIQUE A TEXTBOX 1
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        //TRAVA DE CARACTERES TEXTBOX 1
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números inteiros.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //LIMPAR APÓS CLIQUE A TEXTBOX R1
        private void textBoxR1_Click(object sender, EventArgs e)
        {
            textBoxR1.Text = "";
        }

        //TRAVA DE CARACTERES TEXTBOX R1
        private void textBoxR1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if ((e.KeyChar == ',') && (textBoxR1.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //CHAMADA PÁGINA DE CÁLCULO DE RESISTOR
        private void button_calc_res_Click(object sender, EventArgs e)
        {
            string textResistor = "";
            calcResistencia form = new calcResistencia();
            form.Closed += (s, args) => textResistor = form.Resistor;
            form.Closed += (s, args) => atribuir_valor(textResistor);
            form.Show();
        }
        private void atribuir_valor(string textResistor)
        {
            //VERIFICA SE O USUÁRIO FECHOU A PÁGINA ANTES DO RESULTADO SER CALCULADO
            if (!(textResistor == "-"))
            {
                //PREENCHER O VALOR DO  RESISTOR FALTANDO
                string[] divTextResistor = textResistor.Split('Ω');
                textBoxR1.Text = divTextResistor[0];
            }   
        }

        //PROGRAMAÇÃO BOTÃO INSERIR
        int i = 0;//DECLARAÇÃO VARIÁVEL UTILZIADA COMO CONTADOR
        double[] resistores = new double[100];
        private void button1_Click(object sender, EventArgs e)
        {          
            double valorR, NResistencias;
            bool converterR = double.TryParse(textBoxR1.Text, out valorR);
            bool converterNR = double.TryParse(textBox1.Text, out NResistencias);    
            //VERIFICA SE OS VALORES INFORMADOES SÃO DÍGITOS VÁLIDOS
            if ((converterR == true) && (converterNR == true))
            {
                if (i < NResistencias)//VERIFICA SE O CONTADOR É MENOR QUE O NUMERO MAXIMO DE RESISTENCIAS INFORMADAS
                {
                    label1.Text = $"INFORME O VALOR DA RESISTÊNCIA {i+2}(R{i+2}): ";
                    label3.Text += $"{valorR} Ω - ";
                    resistores[i] = valorR;
                    label8.Show();
                    i++;
                    textBoxR1.Focus();
                }
                if(i == NResistencias)
                {
                    label1.Text = $"INFORME O VALOR DA RESISTÊNCIA {i}(R{i}): ";
                    //FORMATAÇÃO NA LABEL A ÚLTIMA RESISTÊNCIA INSERIDA
                    string texto_resistores = label3.Text;
                    int index = texto_resistores.Length;
                    string formatacaoTexto = texto_resistores.Substring(0,index-2);
                    label3.Text = formatacaoTexto + '.';

                    double RTParalelo, RTSerie, soma_res = 0;
                    
                    //CÁLCULO RESISTÊNCIA EM PARALELO
                    for (int cont = 0; cont < NResistencias; cont++)
                    {
                        soma_res = soma_res + (1 / resistores[cont]);
                    }
                    RTParalelo = 1 / soma_res;
                    label8.Text = $"{RTParalelo:F2} Ω";

                    //CÁLCULO RESISTÊNCIA EM SÉRIE
                    soma_res = 0;
                    for (int cont = 0; cont < NResistencias; cont++)
                    {
                        soma_res = soma_res + resistores[cont];
                    }
                    RTSerie = soma_res;
                    label7.Text = $"{RTSerie} Ω";

                    label5.Show();
                    label6.Show();
                    label7.Show();
                    label8.Show();
                    i++;
                }
            }
            else
            {
                MessageBox.Show("Informe todos os valores de resistência!", "Atencão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "INSIRA A QUANTIDADE";
            limparvalores();
        }

        void limparvalores()
        {
            label1.Text = "INFORME O VALOR DA RESISTÊNCIA 1(R1): ";
            textBoxR1.Text = "INSIRA R1";
            label3.Text = "";
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            i = 0; //RESET DO CONTADOR PARA INICIAR UM NOVO CÁLCULO
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu form = new menu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
