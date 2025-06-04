namespace SubstituiçãoAulas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHS1.Text) && string.IsNullOrWhiteSpace(txtHS2.Text) && string.IsNullOrWhiteSpace(txtHS3.Text))
            {
                MessageBox.Show("Pelo menos um dos campos precisa estar preenchido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHS1.Focus();
            }
            else
            {
                //definindo variaveis
                double horasETEC1;
                double horasETEC2;
                double horasETEC3;

                double horasEspeciais1;
                double horasEspeciais2;
                double horasEspeciais3;

                double atividade1;
                double atividade2;
                double atividade3;

                double horasAcrescimo1;
                double horasAcrescimo2;
                double horasAcrescimo3;

                double horasEspeciaisAcrescimo1;
                double horasEspeciaisAcrescimo2;
                double horasEspeciaisAcrescimo3;

                double subTotal1;
                double subTotal2;
                double subTotal3;
                double horasAulasSubstituidas;

                //Se os campos estiverem vazios, atribui 0
                horasETEC1 = string.IsNullOrWhiteSpace(txtHS1.Text) ? 0 : double.Parse(txtHS1.Text);
                horasETEC2 = string.IsNullOrWhiteSpace(txtHS2.Text) ? 0 : double.Parse(txtHS2.Text);
                horasETEC3 = string.IsNullOrWhiteSpace(txtHS3.Text) ? 0 : double.Parse(txtHS3.Text);

                horasEspeciais1 = string.IsNullOrWhiteSpace(txtHSE1.Text) ? 0 : double.Parse(txtHSE1.Text);
                horasEspeciais2 = string.IsNullOrWhiteSpace(txtHSE2.Text) ? 0 : double.Parse(txtHSE2.Text);
                horasEspeciais3 = string.IsNullOrWhiteSpace(txtHSE3.Text) ? 0 : double.Parse(txtHSE3.Text);

                horasAulasSubstituidas = string.IsNullOrWhiteSpace(txtHoraSubstituicao.Text) ? 0 : double.Parse(txtHoraSubstituicao.Text);

                //30% das horas em relação as horas de aula semanais
                atividade1 = horasETEC1 * 0.3;
                atividade2 = horasETEC2 * 0.3;
                atividade3 = horasETEC3 * 0.3;

                txtAtividade1.Text = atividade1.ToString("F2");
                txtAtividade2.Text = atividade2.ToString("F2");
                txtAtividade3.Text = atividade3.ToString("F2");

                //Horas acrescimo(Horas semanais + 30%)
                horasAcrescimo1 = horasETEC1 * 1.3;
                horasAcrescimo2 = horasETEC2 * 1.3;
                horasAcrescimo3 = horasETEC3 * 1.3;

                horasAulasSubstituidas = horasAulasSubstituidas * 1.3;

                txtHAP1.Text = horasAcrescimo1.ToString("F2");
                txtHAP2.Text = horasAcrescimo2.ToString("F2");
                txtHAP3.Text = horasAcrescimo3.ToString("F2");
                                
                //Total de horas mensais com o acrescimo de 30%
                subTotal1 = horasAcrescimo1 * 4.5;
                subTotal2 = horasAcrescimo2 * 4.5;
                subTotal3 = horasAcrescimo3 * 4.5;

                horasEspeciaisAcrescimo1 = horasEspeciais1 * 4.5;
                horasEspeciaisAcrescimo2 = horasEspeciais2 * 4.5;
                horasEspeciaisAcrescimo3 = horasEspeciais3 * 4.5;

                txtT1.Text = subTotal1.ToString("F2");
                txtT2.Text = subTotal2.ToString("F2");
                txtT3.Text = subTotal3.ToString("F2");

                txtTE1.Text = horasEspeciaisAcrescimo1.ToString("F2");
                txtTE2.Text = horasEspeciaisAcrescimo2.ToString("F2");
                txtTE3.Text = horasEspeciaisAcrescimo3.ToString("F2");

                //Total de horas semanais e mensais dentre todas as escolas
                double totalMensal = subTotal1 + subTotal2 + subTotal3 + horasAulasSubstituidas + horasEspeciaisAcrescimo1 + horasEspeciaisAcrescimo2 + horasEspeciaisAcrescimo3;
                txtTotalSemanal.Text = (horasETEC1 + horasETEC2 + horasETEC3 + horasEspeciais1 + horasEspeciais2 + horasEspeciais3).ToString("F2");
                txtTotalMensal.Text = (subTotal1 + subTotal2 + subTotal3 + horasAulasSubstituidas + horasEspeciaisAcrescimo1 + horasEspeciaisAcrescimo2 + horasEspeciaisAcrescimo3).ToString("F2");

                if (totalMensal > 200)
                {
                    MessageBox.Show("O total de horas mensais ultrapassou o limite de 200 horas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
