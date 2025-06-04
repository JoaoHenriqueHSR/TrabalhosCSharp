namespace SubstituiçãoAulas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtHS1 = new TextBox();
            lblTitulo = new Label();
            lblHA = new Label();
            btnCalcular = new Button();
            btnSair = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtT1 = new TextBox();
            label2 = new Label();
            txtHAP1 = new TextBox();
            label1 = new Label();
            txtAtividade1 = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtT2 = new TextBox();
            label5 = new Label();
            txtHAP2 = new TextBox();
            label6 = new Label();
            txtAtividade2 = new TextBox();
            label7 = new Label();
            txtHS2 = new TextBox();
            groupBox3 = new GroupBox();
            label8 = new Label();
            txtT3 = new TextBox();
            label9 = new Label();
            txtHAP3 = new TextBox();
            label10 = new Label();
            txtAtividade3 = new TextBox();
            label11 = new Label();
            txtHS3 = new TextBox();
            lblSubistiuicao = new Label();
            txtHoraSubstituicao = new TextBox();
            txtTotalSemanal = new TextBox();
            txtTotalMensal = new TextBox();
            lblTotalSemanal = new Label();
            lblTotalMensal = new Label();
            groupBox4 = new GroupBox();
            label15 = new Label();
            label12 = new Label();
            txtTE1 = new TextBox();
            txtHSE1 = new TextBox();
            groupBox5 = new GroupBox();
            label13 = new Label();
            label14 = new Label();
            txtTE2 = new TextBox();
            txtHSE2 = new TextBox();
            groupBox6 = new GroupBox();
            label16 = new Label();
            label17 = new Label();
            txtTE3 = new TextBox();
            txtHSE3 = new TextBox();
            lblHorasPSubstituir = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // txtHS1
            // 
            txtHS1.Location = new Point(75, 50);
            txtHS1.Name = "txtHS1";
            txtHS1.Size = new Size(100, 23);
            txtHS1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(549, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(213, 37);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Calculo de Aulas";
            // 
            // lblHA
            // 
            lblHA.AutoSize = true;
            lblHA.Location = new Point(76, 29);
            lblHA.Name = "lblHA";
            lblHA.Size = new Size(123, 15);
            lblHA.TabIndex = 3;
            lblHA.Text = "Horas Aulas Semanais";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(285, 337);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(1153, 428);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtT1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHAP1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAtividade1);
            groupBox1.Controls.Add(lblHA);
            groupBox1.Controls.Add(txtHS1);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(699, 79);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "ETEC - Sede";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(551, 29);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 9;
            label3.Text = "Subtotal Mensal x4,5 h/a";
            // 
            // txtT1
            // 
            txtT1.Enabled = false;
            txtT1.Location = new Point(550, 50);
            txtT1.Name = "txtT1";
            txtT1.Size = new Size(100, 23);
            txtT1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 29);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 7;
            label2.Text = "Hora Aula + 30%";
            // 
            // txtHAP1
            // 
            txtHAP1.Enabled = false;
            txtHAP1.Location = new Point(397, 50);
            txtHAP1.Name = "txtHAP1";
            txtHAP1.Size = new Size(100, 23);
            txtHAP1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 29);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 5;
            label1.Text = "Hora atividade";
            // 
            // txtAtividade1
            // 
            txtAtividade1.Enabled = false;
            txtAtividade1.Location = new Point(248, 50);
            txtAtividade1.Name = "txtAtividade1";
            txtAtividade1.Size = new Size(100, 23);
            txtAtividade1.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtT2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtHAP2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtAtividade2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtHS2);
            groupBox2.Location = new Point(12, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(699, 79);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "ETEC - Outra Unidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(551, 29);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 9;
            label4.Text = "Subtotal Mensal x4,5 h/a";
            // 
            // txtT2
            // 
            txtT2.Enabled = false;
            txtT2.Location = new Point(550, 50);
            txtT2.Name = "txtT2";
            txtT2.Size = new Size(100, 23);
            txtT2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 29);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 7;
            label5.Text = "Hora Aula + 30%";
            // 
            // txtHAP2
            // 
            txtHAP2.Enabled = false;
            txtHAP2.Location = new Point(397, 50);
            txtHAP2.Name = "txtHAP2";
            txtHAP2.Size = new Size(100, 23);
            txtHAP2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 29);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 5;
            label6.Text = "Hora atividade";
            // 
            // txtAtividade2
            // 
            txtAtividade2.Enabled = false;
            txtAtividade2.Location = new Point(248, 50);
            txtAtividade2.Name = "txtAtividade2";
            txtAtividade2.Size = new Size(100, 23);
            txtAtividade2.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 29);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 3;
            label7.Text = "Horas Aulas Semanais";
            // 
            // txtHS2
            // 
            txtHS2.Location = new Point(75, 50);
            txtHS2.Name = "txtHS2";
            txtHS2.Size = new Size(100, 23);
            txtHS2.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtT3);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtHAP3);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtAtividade3);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtHS3);
            groupBox3.Location = new Point(12, 219);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(699, 79);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "ETEC - Outra Unidade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(551, 29);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 9;
            label8.Text = "Subtotal Mensal x4,5 h/a";
            // 
            // txtT3
            // 
            txtT3.Enabled = false;
            txtT3.Location = new Point(550, 50);
            txtT3.Name = "txtT3";
            txtT3.Size = new Size(100, 23);
            txtT3.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(398, 29);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 7;
            label9.Text = "Hora Aula + 30%";
            // 
            // txtHAP3
            // 
            txtHAP3.Enabled = false;
            txtHAP3.Location = new Point(397, 50);
            txtHAP3.Name = "txtHAP3";
            txtHAP3.Size = new Size(100, 23);
            txtHAP3.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(249, 29);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 5;
            label10.Text = "Hora atividade";
            // 
            // txtAtividade3
            // 
            txtAtividade3.BackColor = SystemColors.Window;
            txtAtividade3.Enabled = false;
            txtAtividade3.Location = new Point(248, 50);
            txtAtividade3.Name = "txtAtividade3";
            txtAtividade3.Size = new Size(100, 23);
            txtAtividade3.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(76, 29);
            label11.Name = "label11";
            label11.Size = new Size(123, 15);
            label11.TabIndex = 3;
            label11.Text = "Horas Aulas Semanais";
            // 
            // txtHS3
            // 
            txtHS3.Location = new Point(75, 50);
            txtHS3.Name = "txtHS3";
            txtHS3.Size = new Size(100, 23);
            txtHS3.TabIndex = 0;
            // 
            // lblSubistiuicao
            // 
            lblSubistiuicao.AutoSize = true;
            lblSubistiuicao.Location = new Point(87, 319);
            lblSubistiuicao.Name = "lblSubistiuicao";
            lblSubistiuicao.Size = new Size(138, 15);
            lblSubistiuicao.TabIndex = 13;
            lblSubistiuicao.Text = "Horas Aulas Substituição";
            // 
            // txtHoraSubstituicao
            // 
            txtHoraSubstituicao.Location = new Point(88, 337);
            txtHoraSubstituicao.Name = "txtHoraSubstituicao";
            txtHoraSubstituicao.Size = new Size(100, 23);
            txtHoraSubstituicao.TabIndex = 14;
            // 
            // txtTotalSemanal
            // 
            txtTotalSemanal.Enabled = false;
            txtTotalSemanal.Location = new Point(88, 428);
            txtTotalSemanal.Name = "txtTotalSemanal";
            txtTotalSemanal.Size = new Size(100, 23);
            txtTotalSemanal.TabIndex = 15;
            // 
            // txtTotalMensal
            // 
            txtTotalMensal.Enabled = false;
            txtTotalMensal.Location = new Point(260, 428);
            txtTotalMensal.Name = "txtTotalMensal";
            txtTotalMensal.Size = new Size(100, 23);
            txtTotalMensal.TabIndex = 16;
            // 
            // lblTotalSemanal
            // 
            lblTotalSemanal.AutoSize = true;
            lblTotalSemanal.Location = new Point(88, 410);
            lblTotalSemanal.Name = "lblTotalSemanal";
            lblTotalSemanal.Size = new Size(80, 15);
            lblTotalSemanal.TabIndex = 17;
            lblTotalSemanal.Text = "Total Semanal";
            // 
            // lblTotalMensal
            // 
            lblTotalMensal.AutoSize = true;
            lblTotalMensal.Location = new Point(260, 410);
            lblTotalMensal.Name = "lblTotalMensal";
            lblTotalMensal.Size = new Size(73, 15);
            lblTotalMensal.TabIndex = 18;
            lblTotalMensal.Text = "Total Mensal";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(txtTE1);
            groupBox4.Controls.Add(txtHSE1);
            groupBox4.Location = new Point(740, 49);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(488, 79);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Coordenação de Curso";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(343, 29);
            label15.Name = "label15";
            label15.Size = new Size(137, 15);
            label15.TabIndex = 3;
            label15.Text = "Subtotal Mensal x4,5 h/a";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(34, 29);
            label12.Name = "label12";
            label12.Size = new Size(123, 15);
            label12.TabIndex = 2;
            label12.Text = "Horas Aulas Semanais";
            // 
            // txtTE1
            // 
            txtTE1.Enabled = false;
            txtTE1.Location = new Point(343, 50);
            txtTE1.Name = "txtTE1";
            txtTE1.Size = new Size(100, 23);
            txtTE1.TabIndex = 1;
            // 
            // txtHSE1
            // 
            txtHSE1.Location = new Point(34, 50);
            txtHSE1.Name = "txtHSE1";
            txtHSE1.Size = new Size(100, 23);
            txtHSE1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(txtTE2);
            groupBox5.Controls.Add(txtHSE2);
            groupBox5.Location = new Point(740, 134);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(488, 79);
            groupBox5.TabIndex = 23;
            groupBox5.TabStop = false;
            groupBox5.Text = "Coord Projeto/Orientador Ed./Coord C.D./Convenio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(343, 29);
            label13.Name = "label13";
            label13.Size = new Size(137, 15);
            label13.TabIndex = 3;
            label13.Text = "Subtotal Mensal x4,5 h/a";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(34, 29);
            label14.Name = "label14";
            label14.Size = new Size(123, 15);
            label14.TabIndex = 2;
            label14.Text = "Horas Aulas Semanais";
            // 
            // txtTE2
            // 
            txtTE2.Enabled = false;
            txtTE2.Location = new Point(343, 50);
            txtTE2.Name = "txtTE2";
            txtTE2.Size = new Size(100, 23);
            txtTE2.TabIndex = 1;
            // 
            // txtHSE2
            // 
            txtHSE2.Location = new Point(34, 50);
            txtHSE2.Name = "txtHSE2";
            txtHSE2.Size = new Size(100, 23);
            txtHSE2.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label16);
            groupBox6.Controls.Add(label17);
            groupBox6.Controls.Add(txtTE3);
            groupBox6.Controls.Add(txtHSE3);
            groupBox6.Location = new Point(740, 219);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(488, 79);
            groupBox6.TabIndex = 24;
            groupBox6.TabStop = false;
            groupBox6.Text = "Horas Projeto/Laborat. - HAES semanais (sem GF)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(343, 29);
            label16.Name = "label16";
            label16.Size = new Size(137, 15);
            label16.TabIndex = 3;
            label16.Text = "Subtotal Mensal x4,5 h/a";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(34, 29);
            label17.Name = "label17";
            label17.Size = new Size(123, 15);
            label17.TabIndex = 2;
            label17.Text = "Horas Aulas Semanais";
            // 
            // txtTE3
            // 
            txtTE3.Enabled = false;
            txtTE3.Location = new Point(343, 50);
            txtTE3.Name = "txtTE3";
            txtTE3.Size = new Size(100, 23);
            txtTE3.TabIndex = 1;
            // 
            // txtHSE3
            // 
            txtHSE3.Location = new Point(34, 50);
            txtHSE3.Name = "txtHSE3";
            txtHSE3.Size = new Size(100, 23);
            txtHSE3.TabIndex = 0;
            // 
            // lblHorasPSubstituir
            // 
            lblHorasPSubstituir.AutoSize = true;
            lblHorasPSubstituir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHorasPSubstituir.ForeColor = SystemColors.ActiveCaptionText;
            lblHorasPSubstituir.Location = new Point(563, 430);
            lblHorasPSubstituir.Name = "lblHorasPSubstituir";
            lblHorasPSubstituir.Size = new Size(66, 21);
            lblHorasPSubstituir.TabIndex = 25;
            lblHorasPSubstituir.Text = "label18";
            lblHorasPSubstituir.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1239, 469);
            Controls.Add(lblHorasPSubstituir);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(lblTotalMensal);
            Controls.Add(lblTotalSemanal);
            Controls.Add(txtTotalMensal);
            Controls.Add(txtTotalSemanal);
            Controls.Add(txtHoraSubstituicao);
            Controls.Add(lblSubistiuicao);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSair);
            Controls.Add(btnCalcular);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculo de Horas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHS1;
        private Label lblTitulo;
        private Label lblHA;
        private Button btnCalcular;
        private Button btnSair;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtT1;
        private Label label2;
        private TextBox txtHAP1;
        private Label label1;
        private TextBox txtAtividade1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtT2;
        private Label label5;
        private TextBox txtHAP2;
        private Label label6;
        private TextBox txtAtividade2;
        private Label label7;
        private TextBox txtHS2;
        private GroupBox groupBox3;
        private Label label8;
        private TextBox txtT3;
        private Label label9;
        private TextBox txtHAP3;
        private Label label10;
        private TextBox txtAtividade3;
        private Label label11;
        private TextBox txtHS3;
        private Label lblSubistiuicao;
        private TextBox txtHoraSubstituicao;
        private TextBox txtTotalSemanal;
        private TextBox txtTotalMensal;
        private Label lblTotalSemanal;
        private Label lblTotalMensal;
        private GroupBox groupBox4;
        private Label label15;
        private Label label12;
        private TextBox txtTE1;
        private TextBox txtHSE1;
        private GroupBox groupBox5;
        private Label label13;
        private Label label14;
        private TextBox txtTE2;
        private TextBox txtHSE2;
        private GroupBox groupBox6;
        private Label label16;
        private Label label17;
        private TextBox txtTE3;
        private TextBox txtHSE3;
        private Label lblHorasPSubstituir;
    }
}
