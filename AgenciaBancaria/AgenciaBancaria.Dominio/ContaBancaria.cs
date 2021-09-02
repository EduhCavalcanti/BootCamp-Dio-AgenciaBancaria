using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    //Protected só as classe flhas podem setar
    //Init só pode setar com o construtor, não pode setar fora dele com um método
    //Private só pode setar na própria classe através de algum método

    public class ContaBancaria
    {
        public int NumeroConta { get; init; }
        public int DigitoVerificador { get; init; }
        public decimal Saldo { get; protected set; }
        public DateTime? DataAbertura { get; private set; }
        public DateTime? DataEncerramento { get; private set; }
        public SituacaoConta Situacao { get; private set; }
        public string Senha { get; private set; }
        public Cliente Cliente { get; init; }

        public ContaBancaria(Cliente cliente)
        {
            //Vai gerar um número randômico quando a conta for aberta  
            Random random = new Random();

            NumeroConta = random.Next(1000,50000);
            DigitoVerificador = random.Next(0,9);
            
            Situacao = SituacaoConta.criada;
            
            Cliente = cliente;
        }
    }
}
