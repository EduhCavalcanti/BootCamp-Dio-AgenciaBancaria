using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaPoupanca : ContaBancaria
    {
        public decimal PercentualRendimento { get; set; }

        public ContaPoupanca(Cliente cliente) : base(cliente)
        {
            //0,30%
            PercentualRendimento = 0.003M;
        }
    }
}
