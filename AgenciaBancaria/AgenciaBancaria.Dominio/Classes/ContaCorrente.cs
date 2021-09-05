﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaCorrente : ContaBancaria
    {
        public decimal ValorTaxaManutencao { get; set; }
        public decimal Limite { get; set; }
        public ContaCorrente(Cliente cliente, int id, decimal limite) : base(cliente, id)
        {
            //5 centavos
            ValorTaxaManutencao = 0.05M;
            Limite = limite;
        }

        //Override por que sobre escreveu o método sacar da classe pai
        public override void Sacar(string senha, decimal valor)
        {
            //Vai verificar se a senha está correta
            if (Senha != senha)
            {
                Console.WriteLine("Senha incorreta");
            }
            //Vai verificar se existe saldo mais Limite na conta
            if ((Limite + Saldo) < valor)
            {
                Console.WriteLine("Seu saldo é insuficiente");
            }

            Saldo -= valor;

        }
    
    }
}
