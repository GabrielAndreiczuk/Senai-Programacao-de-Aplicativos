using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto
{
    public partial class calcResistencia : Form
    {
        
        public calcResistencia()
        {
            InitializeComponent();
        }
        //LIMPA TEXTO INICIAL DA TEXTBOX
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        //LIMPA TEXTO INICIAL DA TEXTBOX
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        //TRAVA DE CARACTERES TEXTBOX
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
        //TRAVA DE CARACTERES TEXTBOX
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

        //PROGRAMAÇÃO BOTÃO DE CALCULAR VALOR DO RESISTOR
        private void button2_Click(object sender, EventArgs e)
        {
            double V, I, R;
            bool converterV  = double.TryParse(textBox1.Text, out V);
            bool converterI = double.TryParse(textBox2.Text, out I);
            if (converterV == true && converterI == true) 
            {
                R = V / I;
                labelCalcResistor.Text = $"{R:F2} Ω";
                label5.Show();
                labelCalcResistor.Show();
                button1.Show();
            }
            else
            {
                MessageBox.Show("Informe todos os valores corretamente.", "Atencão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        //FUNCIONALIDADE QUE RETONA O VALOR DO CÁLCULO PARA A PÁGINA DE MENU
        public string Resistor
        {
            get { return labelCalcResistor.Text; }
        }

        //PROGRAMAÇÃO BOTÃO DE CONCLUIR
        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
