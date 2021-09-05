using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        //public int Id { get; set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public bool Excluido { get; private set; }
        public Endereco Endereco { get; private set; }


        public Cliente(string nome, string cPF, string rG, Endereco endereco)
        {
            
            Nome = nome.ValidarCampos();
            CPF = cPF.ValidarCampos();
            RG = rG.ValidarCampos();
            Excluido = false;
            Endereco = endereco;

        }

        public override string ToString()
        {
            string retornar = "";
            retornar += "Nome: " + Nome + Environment.NewLine;
            retornar += "CPF: " + CPF + Environment.NewLine;
            retornar += "RG: " + RG + Environment.NewLine;
            retornar += "Endereço: " + Endereco + Environment.NewLine;

            return retornar;
        }

        //Excluir cliente 
        public void ExcluirCliente()
        {
            Excluido = true;
        }

        //Retornar se cliente estiver excluído
        public bool RetornaClienteExcluido()
        {
            return Excluido;
        }

        //Retornar Nome do cliente
        public string RetornarNome()
        {
            return Nome;
        }
    
        //Retornar Endereço
        public Endereco RetornarEndereço()
        {
            return Endereco;
        }
    }
}
