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
    public partial class atividade4 : Form
    {
        public atividade4()
        {
            InitializeComponent();
        }
        int cont = 0;
        double [] notas = new double[100];
        

        private void atividade4_Load(object sender, EventArgs e)
        {
            textBoxQtd.Focus();
        }

        private void textBoxQtd_Click(object sender, EventArgs e)
        {
            textBoxQtd.Text = "";
        }
        //TRAVA DE CARACTERES TEXTBOX 1
        private void textBoxQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números inteiros.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        //TRAVA DE CARACTERES TEXTBOX 1
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if ((e.KeyChar == ',') && (textBox1.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantidade;
            double valorNota;
            bool converterQtd = int.TryParse(textBoxQtd.Text, out quantidade);
            bool converterNota = double.TryParse(textBox1.Text, out valorNota);
            double media=0;
            if (converterQtd == true && converterNota == true)//VERIFICA SE TODOS OS VALORES FORAM CORRETAMENTE INFORMADOS
            {
                if (cont < quantidade)
                {
                    notas[cont] = valorNota;
                    label3.Text += $"{notas[cont]:F1} - ";
                    label1.Text = $"INFORME A NOTA {cont + 2}: ";
                    textBox1.Focus();
                    cont++;
                }
                if (cont == quantidade)
                {
                    //FORMATAÇÃO TEXTO NOTAS LABEL 3
                    int index = label3.Text.Length;
                    string textoNotas = label3.Text.Substring(0, index - 3);
                    label3.Text = textoNotas + '.';
                    //CORREÇÃO DE TEXTO LABEL 1
                    label1.Text = $"INFORME A NOTA {cont}: ";
                    for (int i = 0; i < quantidade; i++)
                    {
                        media += notas[i];
                    }
                    media /= quantidade;
                    label7.Text = $"{media:F1}";
                    if (media >= 7)
                    {
                        label7.ForeColor = Color.DarkGreen;
                        label8.ForeColor = Color.DarkGreen;
                        label8.Text = "ALUNO APROVADO!";
                    }
                    else
                    {
                        label7.ForeColor = Color.Red;
                        label8.ForeColor = Color.Red;
                        label8.Text = "ALUNO REPROVADO!";
                    }
                    label6.Show();
                    label7.Show();
                    label8.Show();
                    cont++;
                }
                else if (cont > quantidade)
                {
                    MessageBox.Show("Todas as notas já foram informadas!","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Informe todos os valores corretamente!", "Atencão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxQtd.Text = "QUANTIDADE";
            label1.Text = "INFORME A NOTA 1: ";
            textBox1.Text = "INSIRA NOTA 1";
            label3.Text = "";
            label6.Hide();
            label7.Hide();
            label8.Hide();
            cont = 0;
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
