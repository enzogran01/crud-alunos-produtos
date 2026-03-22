using MinhaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TP06_desktop
{
    public partial class ProdutoUIL : Form
    {
        Produto umProduto = new Produto();

        private void limpar()
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
        public ProdutoUIL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // INSERÇÃO

            umProduto.setCodigo(maskedTextBox1.Text);
            umProduto.setDescricao(textBox1.Text);
            umProduto.setFornecedor(textBox2.Text);
            umProduto.setEstoque(maskedTextBox2.Text);
            umProduto.setValorUnitario(maskedTextBox3.Text);

            BLL.validaDadosProduto(umProduto, 'i');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            } else
            {
                MessageBox.Show("Dados de produto inseridos.");
                limpar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // CONSULTA

            umProduto.setCodigo(maskedTextBox1.Text);

            BLL.validaCodigoProduto(umProduto, 'c');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            } else
            {
                maskedTextBox1.Text = umProduto.getCodigo();
                textBox1.Text = umProduto.getDescricao();
                textBox2.Text = umProduto.getFornecedor();
                maskedTextBox2.Text = umProduto.getEstoque();
                maskedTextBox3.Text = umProduto.getValorUnitario();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // DELEÇÃO

            umProduto.setCodigo(maskedTextBox1.Text);

            BLL.validaCodigoProduto(umProduto, 'd');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            } else
            {
                MessageBox.Show("Produto deletado.");
                limpar();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            // ALTERAÇÃO

            umProduto.setCodigo(maskedTextBox1.Text);
            umProduto.setDescricao(textBox1.Text);
            umProduto.setFornecedor(textBox2.Text);
            umProduto.setEstoque(maskedTextBox2.Text);
            umProduto.setValorUnitario(maskedTextBox3.Text);

            BLL.validaDadosProduto(umProduto, 'a');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                MessageBox.Show("Dados de produto altarados.");
                limpar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpar();
        }

    }
}
