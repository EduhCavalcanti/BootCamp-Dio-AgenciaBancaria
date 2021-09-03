using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public Endereco Endereco { get; private set; }


        public Cliente(string nome, string cPF, string rG, Endereco endereco)
        {

            Nome = nome.ValidarCampos();
            CPF = cPF.ValidarCampos();
            RG = rG.ValidarCampos();
            Endereco = endereco;

        }

        public override string ToString()
        {
            string retornar = "";
            retornar += Nome + Environment.NewLine;
            retornar += CPF + Environment.NewLine;
            retornar += RG + Environment.NewLine;
            retornar += Endereco + Environment.NewLine;

            return retornar;
        }




    }
}
