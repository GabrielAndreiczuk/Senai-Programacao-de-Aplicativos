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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            atividade1 Form = new atividade1();
            Form.Closed += (s,args) => this.Close();
            Form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            atividade2 Form = new atividade2();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            atividade3 Form = new atividade3();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            atividade4 Form = new atividade4();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            atividade5 Form = new atividade5();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            atividade6 Form = new atividade6();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            atividade7 Form = new atividade7();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            atividade8 Form = new atividade8();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }
    }
}
