using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaBiblioteca;

namespace TP06_desktop
{
    public partial class AlunoUIL : Form
    {
        Aluno umAluno = new Aluno();
        public AlunoUIL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void limpar()
        {
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            radioButton1.Checked = true;
            maskedTextBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // INSERÇÃO

            umAluno.setRa(maskedTextBox1.Text);
            umAluno.setNome(textBox1.Text);
            umAluno.setSexo(radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            umAluno.setDtNascimento(dateTimePicker1.Text);
            umAluno.setTelefone(maskedTextBox2.Text);

            BLL.validaDadosAluno(umAluno, 'i');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            } else
            {
                MessageBox.Show("Dados inseridos.");
                limpar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // CONSULTA

            umAluno.setRa(maskedTextBox1.Text);

            BLL.validaCodigoAluno(umAluno, 'c');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                limpar();
            } else
            {
                maskedTextBox1.Text = umAluno.getRa();
                textBox1.Text = umAluno.getNome();
                if (umAluno.getSexo() == "M")
                {
                    radioButton1.Checked = true;
                } else
                {
                    radioButton2.Checked = true;
                }
                dateTimePicker1.Text = umAluno.getDtNascimento();
                maskedTextBox2.Text = umAluno.getTelefone();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // DELEÇÃO

            umAluno.setRa(maskedTextBox1.Text);

            BLL.validaCodigoAluno(umAluno, 'd');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                MessageBox.Show("Aluno deletado.");
                limpar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ALTERAÇÃO

            umAluno.setRa(maskedTextBox1.Text);
            umAluno.setNome(textBox1.Text);
            umAluno.setSexo(radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            umAluno.setDtNascimento(dateTimePicker1.Text);
            umAluno.setTelefone(maskedTextBox2.Text);

            BLL.validaDadosAluno(umAluno, 'a');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                limpar();
            }
            else
            {
                MessageBox.Show("Dados de aluno alterados.");
            }
        }
    }
}
