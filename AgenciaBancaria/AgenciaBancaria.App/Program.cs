﻿using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco endereco = new Endereco("Rua", "Cep", "cidade", "estado");

            Cliente clientes = new Cliente("Eduardo", "123", "564", endereco);

            ContaBancaria conta = new ContaBancaria(clientes);
            
            
        }
    }
}