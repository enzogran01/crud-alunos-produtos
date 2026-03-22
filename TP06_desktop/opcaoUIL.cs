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
    public partial class opcaoUIL : Form
    {
        public opcaoUIL()
        {
            InitializeComponent();
        }

        private void cadastroDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeAlunosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlunoUIL alunoUIL = new AlunoUIL();
            alunoUIL.Show();
        }

        private void cadastroDeProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoUIL produtoUIL = new ProdutoUIL();
            produtoUIL.Show();
        }

        private void opcaoUIL_Load(object sender, EventArgs e)
        {
            BLL.conecta();
            if (Erro.getErro()) MessageBox.Show(Erro.getMens());
        }

        private void opcaoUIL_FormClosing(object sender, FormClosingEventArgs e)
        {
            BLL.desconecta();
        }
    }
}
