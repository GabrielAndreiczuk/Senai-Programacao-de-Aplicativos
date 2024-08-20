using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto
{
    public partial class atividade3 : Form
    {
        public atividade3()
        {
            InitializeComponent();
        }

        private void atividade3_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
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
        //TRAVA DE CARACTERES TEXTBOX 2
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if ((e.KeyChar == ',') && (textBox2.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //TRAVA DE CARACTERES TEXTBOX 3
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if ((e.KeyChar == ',') && (textBox3.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //TRAVA DE CARACTERES TEXTBOX 4
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if ((e.KeyChar == ',') && (textBox4.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, media;
            bool converterN1 = double.TryParse(textBox1.Text, out nota1);
            bool converterN2 = double.TryParse(textBox2.Text, out nota2);
            bool converterN3 = double.TryParse(textBox3.Text, out nota3);
            bool converterN4 = double.TryParse(textBox4.Text, out nota4);
            if(converterN1 == true && converterN2 == true && converterN3 == true && converterN4 == true)
            {

                media = (nota1 + nota2 + nota3 + nota4)/4;
                label7.Text = $"{media:F2}";
                if (media >= 7)
                {
                    label8.Text = "ALUNO APROVADO!";
                    label7.ForeColor = Color.DarkGreen;
                    label8.ForeColor = Color.DarkGreen;
                }
                else
                {
                    label8.Text = "ALUNO REROVADO!";
                    label7.ForeColor = Color.Red;
                    label8.ForeColor = Color.Red;
                }
                label6.Show();
                label7.Show();
                label8.Show();
            }
            else
            {
                MessageBox.Show("Informe todos os valores corretamente!", "Atencão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            label6.Hide();
            label7.Hide();
            label8.Hide();
            textBox1.Text = "INSIRA NOTA 1";
            textBox2.Text = "INSIRA NOTA 2";
            textBox3.Text = "INSIRA NOTA 3";
            textBox4.Text = "INSIRA NOTA 4";
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
