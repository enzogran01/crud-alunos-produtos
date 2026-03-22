using MinhaBiblioteca;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP06_desktop
{
    internal class DAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setErro("Problemas ao se conectar ao Banco de Dados");
            }
        }

        public static void desconecta()
        {
            conn.Close();
        }

        public static void insereAluno(Aluno umAluno)
        {
            String aux = "INSERT INTO aluno (RA, nome, sexo, dt_nascimento, tel_aluno) VALUES (@RA, @nome, @sexo, @dt_nascimento, @tel_aluno)";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@RA", OleDbType.VarChar).Value = umAluno.getRa();
            strSQL.Parameters.Add("@nome", OleDbType.VarChar).Value = umAluno.getNome();
            strSQL.Parameters.Add("@sexo", OleDbType.VarChar).Value = umAluno.getSexo();
            strSQL.Parameters.Add("@dt_nascimento", OleDbType.VarChar).Value = umAluno.getDtNascimento();
            strSQL.Parameters.Add("@tel_aluno", OleDbType.VarChar).Value = umAluno.getTelefone();
            strSQL.ExecuteNonQuery();
        }

        public static void consultaAluno(Aluno umAluno)
        {
            String aux = "SELECT * FROM aluno WHERE RA = @RA";
            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@RA", OleDbType.VarChar).Value = umAluno.getRa();
            result = strSQL.ExecuteReader();
            Erro.setErro(false);
            if (result.Read())
            {
                umAluno.setRa(result[0].ToString());
                umAluno.setNome(result[1].ToString());
                umAluno.setSexo(result[2].ToString());
                umAluno.setDtNascimento(result[3].ToString());
                umAluno.setTelefone(result[4].ToString());
            }
            else
                Erro.setErro("Aluno não cadastrado.");
        }

        public static void deletaAluno(Aluno umAluno)
        {
            String aux = "DELETE * FROM aluno WHERE RA = @RA";
            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@RA", OleDbType.VarChar).Value = umAluno.getRa();

            int linhasAfetadas = strSQL.ExecuteNonQuery();

            if (linhasAfetadas == 0)
                Erro.setErro("Aluno não cadastrado.");
            else
                Erro.setErro(false);
        }

        public static void alteraAluno(Aluno umAluno)
        {
            String aux = "UPDATE aluno SET nome = @nome, sexo = @sexo, dt_nascimento = @dt_nascimento, tel_aluno = @tel_aluno WHERE RA = @RA";
            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@nome", OleDbType.VarChar).Value = umAluno.getNome();
            strSQL.Parameters.Add("@sexo", OleDbType.VarChar).Value = umAluno.getSexo();
            strSQL.Parameters.Add("@dt_nascimento", OleDbType.VarChar).Value = umAluno.getDtNascimento();
            strSQL.Parameters.Add("@tel_aluno", OleDbType.VarChar).Value = umAluno.getTelefone();
            strSQL.Parameters.Add("@RA", OleDbType.VarChar).Value = umAluno.getRa();

            int linhasAfetadas = strSQL.ExecuteNonQuery();

            if (linhasAfetadas == 0)
                Erro.setErro("Aluno não encontrado para alterar.");
            else
                Erro.setErro(false);
        }

        public static void insereProduto(Produto umProduto)
        {
            String aux = "INSERT INTO produto (codigo, descricao, fornecedor, qtEstoque, valorUnitario) VALUES (@codigo, @descricao, @fornecedor, @qtEstoque, @valorUnitario)";
            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value = umProduto.getCodigo();
            strSQL.Parameters.Add("@descricao", OleDbType.VarChar).Value = umProduto.getDescricao();
            strSQL.Parameters.Add("@fornecedor", OleDbType.VarChar).Value = umProduto.getFornecedor();
            strSQL.Parameters.Add("@qtEstoque", OleDbType.VarChar).Value = umProduto.getEstoque();
            strSQL.Parameters.Add("@valorUnitario", OleDbType.VarChar).Value = umProduto.getValorUnitario();
            strSQL.ExecuteNonQuery();
        }

        public static void consultaProduto(Produto umProduto)
        {
            String aux = "SELECT * FROM produto WHERE codigo = @codigo";
            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value = umProduto.getCodigo();
            result = strSQL.ExecuteReader();
            Erro.setErro(false);
            if (result.Read())
            {
                umProduto.setCodigo(result[0].ToString());
                umProduto.setDescricao(result[1].ToString());
                umProduto.setFornecedor(result[2].ToString());
                umProduto.setEstoque(result[3].ToString());
                umProduto.setValorUnitario(result[4].ToString());
            }
            else
                Erro.setErro("Produto não cadastrado.");
        }

        public static void deletaProduto(Produto umProduto)
        {
            String aux = "DELETE * FROM produto WHERE codigo = @codigo";
            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value = umProduto.getCodigo();
            int linhasAfetadas = strSQL.ExecuteNonQuery();
            if (linhasAfetadas == 0)
                Erro.setErro("Produto não cadastrado.");
            else
                Erro.setErro(false);
        }

        public static void alteraProduto(Produto umProduto)
        {
            String aux = "UPDATE produto SET descricao = @descricao, fornecedor = @fornecedor, qtEstoque = @qtEstoque, valorUnitario = @valorUnitario WHERE codigo = @codigo";
            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@descricao", OleDbType.VarChar).Value = umProduto.getDescricao();
            strSQL.Parameters.Add("@fornecedor", OleDbType.VarChar).Value = umProduto.getFornecedor();
            strSQL.Parameters.Add("@qtEstoque", OleDbType.VarChar).Value = umProduto.getEstoque();
            strSQL.Parameters.Add("@valorUnitario", OleDbType.VarChar).Value = umProduto.getValorUnitario();
            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value = umProduto.getCodigo();
            int linhasAfetadas = strSQL.ExecuteNonQuery();
            if (linhasAfetadas == 0)
                Erro.setErro("Produto não encontrado para alterar.");
            else
                Erro.setErro(false);
        }
    }
}
