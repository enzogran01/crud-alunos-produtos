using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP06_desktop
{
    internal class Produto
    {
        private String codigo;
        private String descricao;
        private String fornecedor;
        private String qtEstoque;
        private String valorUnitario;

        public void setCodigo(String codigo)
        {
            this.codigo = codigo;
        }
        public void setDescricao(String descricao)
        {
            this.descricao = descricao;
        }
        public void setFornecedor(String fornecedor)
        {
            this.fornecedor = fornecedor;
        }
        public void setEstoque(String qtEstoque)
        {
            this.qtEstoque = qtEstoque;
        }
        public void setValorUnitario(String valorUnitario)
        {
            this.valorUnitario = valorUnitario;
        }

        public String getCodigo()
        {
            return codigo;
        }
        public String getDescricao()
        {
            return descricao;
        }
        public String getFornecedor()
        {
            return fornecedor;
        }
        public String getEstoque()
        {
            return qtEstoque;
        }
        public String getValorUnitario()
        {
            return valorUnitario;
        }
    }
}
