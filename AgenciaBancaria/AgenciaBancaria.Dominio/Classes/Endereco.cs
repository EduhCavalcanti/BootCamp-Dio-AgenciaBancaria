using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Endereco
    {
        public string Logadouro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        public Endereco(string logadouro, string cEP, string cidade, string estado)
        {
            Logadouro = logadouro.ValidarCampos();
            CEP = cEP.ValidarCampos();
            Cidade = cidade.ValidarCampos();
            Estado = estado.ValidarCampos();
        }

        public override string ToString()
        {
            string retornar = "";
            retornar += Logadouro + Environment.NewLine;
            retornar += CEP + Environment.NewLine;
            retornar += Cidade + Environment.NewLine;
            retornar += Estado + Environment.NewLine;
            return retornar;
        }
    }
}
