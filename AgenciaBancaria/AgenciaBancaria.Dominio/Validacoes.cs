using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    //Classe para validações
    public static class Validacoes
    {
        //Método para validar campos
        public static string ValidarCampos(this string text) 
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new Exception("Atributo obrigatório");
            }

            return text;
        }


    }
}
