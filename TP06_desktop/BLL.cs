using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace TP06_desktop
{
    internal class BLL
    {

        public static void conecta()
        {
            DAL.conecta();
        }

        public static void desconecta()
        {
            DAL.desconecta();
        }

        public static void validaDadosAluno(Aluno umAluno, Char ic)
        {
            Erro.setErro(false);
            if (umAluno.getRa().Length == 0)
            {
                Erro.setErro("O campo RA é de preenchimento obrigatório!");
                return;
            }
            if (umAluno.getNome().Length == 0)
            {
                Erro.setErro("O campo NOME é de preenchimento obrigatório!");
                return;
            }
            if (umAluno.getSexo().Length == 0)
            {
                Erro.setErro("O campo SEXO é de preenchimento obrigatório!");
                return;
            }
            if (umAluno.getDtNascimento().Length == 0)
            {
                Erro.setErro("O campo DATA DE NASCIMENTO é de preenchimento obrigatório!");
                return;
            }
            if (umAluno.getTelefone().Length == 0)
            {
                Erro.setErro("O campo TELEFONE é de preenchimento obrigatório!");
                return;
            }

            if (ic == 'i')
            {
                // insere
                DAL.insereAluno(umAluno);
            } else
            {
                // altera
                DAL.alteraAluno(umAluno);
            }
        }
        public static void validaCodigoAluno(Aluno umAluno, Char ic)
        {
            Erro.setErro(false);
            if (umAluno.getRa().Length == 0)
            {
                Erro.setErro("O campo RA é de preenchimento obrigatório!");
                return;
            }

            if (ic == 'd')
            {
                // deleta
                DAL.deletaAluno(umAluno);
            } else
            {
                // consulta
                DAL.consultaAluno(umAluno);
            }
        }

        public static void validaDadosProduto(Produto umProduto, Char ic)
        {
            Erro.setErro(false);
            if (umProduto.getCodigo().Length == 0)
            {
                Erro.setErro("O campo CODIGO é de preenchimento obrigatório!");
                return;
            }
            if (umProduto.getDescricao().Length == 0)
            {
                Erro.setErro("O campo DESCRICAO é de preenchimento obrigatório!");
                return;
            }
            if (umProduto.getFornecedor().Length == 0)
            {
                Erro.setErro("O campo FORNECEDOR é de preenchimento obrigatório!");
                return;
            }
            if (umProduto.getEstoque().Length == 0)
            {
                Erro.setErro("O campo ESTOQUE é de preenchimento obrigatório!");
                return;
            }
            if (umProduto.getValorUnitario().Length == 0)
            {
                Erro.setErro("O campo VALOR UNITARIO é de preenchimento obrigatório!");
                return;
            }

            if (ic == 'i')
            {
                // insere
                DAL.insereProduto(umProduto);
            }
            else
            {
                // altera
                DAL.alteraProduto(umProduto);
            }
        }
        public static void validaCodigoProduto(Produto umProduto, Char ic)
        {
            Erro.setErro(false);
            if (umProduto.getCodigo().Length == 0)
            {
                Erro.setErro("O campo CODIGO é de preenchimento obrigatório!");
                return;
            }

            if (ic == 'd')
            {
                // deleta
                DAL.deletaProduto(umProduto);
            } else
            {
                // consulta
                DAL.consultaProduto(umProduto);
            }
        }
    }
}
