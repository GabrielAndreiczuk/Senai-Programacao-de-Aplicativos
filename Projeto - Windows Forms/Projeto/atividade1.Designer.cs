namespace Projeto
{
    partial class atividade1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_calc_res = new System.Windows.Forms.Button();
            this.textBoxR1 = new System.Windows.Forms.TextBox();
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.textBoxR3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(152, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORME O VALOR DA RESISTÊNCIA 1(R1): \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(152, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "INFORME O VALOR DA RESISTÊNCIA 2(R2): \r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(152, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "INFORME O VALOR DA RESISTÊNCIA 3(R3): \r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(600, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "CÁLCULO DE RESISTÊNCIAS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_calc_res
            // 
            this.button_calc_res.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_calc_res.BackColor = System.Drawing.Color.Black;
            this.button_calc_res.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_calc_res.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_calc_res.ForeColor = System.Drawing.Color.White;
            this.button_calc_res.Location = new System.Drawing.Point(756, 167);
            this.button_calc_res.Name = "button_calc_res";
            this.button_calc_res.Size = new System.Drawing.Size(300, 60);
            this.button_calc_res.TabIndex = 7;
            this.button_calc_res.Text = "NÃO SEI O VALOR DE RESISTÊNCIA";
            this.button_calc_res.UseVisualStyleBackColor = false;
            this.button_calc_res.Click += new System.EventHandler(this.button_calc_res_Click);
            // 
            // textBoxR1
            // 
            this.textBoxR1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxR1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxR1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxR1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxR1.ForeColor = System.Drawing.Color.White;
            this.textBoxR1.Location = new System.Drawing.Point(521, 167);
            this.textBoxR1.Name = "textBoxR1";
            this.textBoxR1.Size = new System.Drawing.Size(200, 19);
            this.textBoxR1.TabIndex = 8;
            this.textBoxR1.Text = "INSIRA R1";
            this.textBoxR1.Click += new System.EventHandler(this.textBoxR1_Click);
            this.textBoxR1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxR1_KeyPress);
            // 
            // textBoxR2
            // 
            this.textBoxR2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxR2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxR2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxR2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxR2.ForeColor = System.Drawing.Color.White;
            this.textBoxR2.Location = new System.Drawing.Point(521, 221);
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.Size = new System.Drawing.Size(200, 19);
            this.textBoxR2.TabIndex = 9;
            this.textBoxR2.Text = "INSIRA R2";
            this.textBoxR2.Click += new System.EventHandler(this.textBoxR2_Click);
            this.textBoxR2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxR2_KeyPress);
            // 
            // textBoxR3
            // 
            this.textBoxR3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxR3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxR3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxR3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxR3.ForeColor = System.Drawing.Color.White;
            this.textBoxR3.Location = new System.Drawing.Point(521, 278);
            this.textBoxR3.Name = "textBoxR3";
            this.textBoxR3.Size = new System.Drawing.Size(200, 19);
            this.textBoxR3.TabIndex = 10;
            this.textBoxR3.Text = "INSIRA R3";
            this.textBoxR3.Click += new System.EventHandler(this.textBoxR3_Click);
            this.textBoxR3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxR3_KeyPress);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(450, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 60);
            this.button1.TabIndex = 11;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.BackColor = System.Drawing.Color.Black;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(756, 247);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(300, 60);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "LIMPAR VALORES";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(325, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 50);
            this.label5.TabIndex = 13;
            this.label5.Text = "RESISTÊNCIA EM SÉRIE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(625, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 50);
            this.label6.TabIndex = 14;
            this.label6.Text = "RESISTÊNCIA EM PARALELO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(325, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 50);
            this.label7.TabIndex = 15;
            this.label7.Text = "300 Ω";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(625, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 50);
            this.label8.TabIndex = 16;
            this.label8.Text = "150 Ω";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Visible = false;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMenu.BackColor = System.Drawing.Color.Black;
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Location = new System.Drawing.Point(972, 564);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(200, 60);
            this.buttonMenu.TabIndex = 17;
            this.buttonMenu.Text = "VOLTAR AO MENU";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // atividade1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxR3);
            this.Controls.Add(this.textBoxR2);
            this.Controls.Add(this.textBoxR1);
            this.Controls.Add(this.button_calc_res);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "atividade1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CÁLCULO DE 3 RESISTÊNCIAS";
            this.Load += new System.EventHandler(this.atividade1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_calc_res;
        private System.Windows.Forms.TextBox textBoxR1;
        private System.Windows.Forms.TextBox textBoxR2;
        private System.Windows.Forms.TextBox textBoxR3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonMenu;
    }
}