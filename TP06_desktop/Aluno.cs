using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP06_desktop
{
    internal class Aluno
    {
        private String ra;
        private String nome;
        private String sexo;
        private String dtNascimento;
        private String telefone;

        public void setRa(String ra)
        {
            this.ra = ra;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public void setSexo(String sexo)
        {
            this.sexo = sexo;
        }
        public void setDtNascimento(String dtNascimento)
        {
            this.dtNascimento = dtNascimento;
        }
        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }

        public String getRa()
        {
            return ra;
        }
        public String getNome()
        {
            return nome;
        }
        public String getSexo()
        {
            return sexo;
        }
        public String getDtNascimento()
        {
            return dtNascimento;
        }
        public String getTelefone()
        {
            return telefone;
        }
    }
}
