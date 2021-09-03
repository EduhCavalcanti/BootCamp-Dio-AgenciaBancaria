﻿using AgenciaBancaria.Dominio;
using AgenciaBancaria.Dominio.Repositorio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        public static ClienteRepositorio novoCliente = new ClienteRepositorio();
        
        static void Main(string[] args)
        {

            string entradaOpcao = OpcaoUusuario();

            while (entradaOpcao != "X")
            {
                switch(entradaOpcao)
                {
                    //Listar conta
                    case "0":
                        try { 
                            var listaContas = novoCliente.Lista();

                            if(listaContas.Count != 0) { 

                                foreach(var contas in listaContas)
                                {
                                    Console.WriteLine(contas);

                                }
                            }
                            else
                            {
                                Console.WriteLine("Nenhuma conta foi encontrada!");
                            }
                        }catch(Exception e)
                        {
                            throw new Exception(e.Message);
                        }

                        break;

                    //Abri conta
                    case "1":
                        var informacaoCliente = InformeDadosPessoais();

                        novoCliente.Criar(informacaoCliente);

                        break;
                    //Fecha conta
                    case "2":

                        break;
                    //Verificar se existe saldo na conta
                    case "3":

                        break;
                    //Depositar 
                    case "4":

                        break;
                    //Sacar
                    case "5":

                        break;

                }

                entradaOpcao = OpcaoUusuario();
            }
            Console.WriteLine("Programa encerrado");
        }


        private static string OpcaoUusuario()
        {
            Console.WriteLine("Oque você deseja fazer?");
            Console.WriteLine("0 - Listar Contas");
            Console.WriteLine("1 - Abri uma conta: ");
            Console.WriteLine("2 - Fechar uma conta: ");
            Console.WriteLine("3 - Verificar se existe saldo na conta: ");
            Console.WriteLine("4 - Depositar: ");
            Console.WriteLine("5 - Sacar: ");
            Console.WriteLine("X - Sair: ");

            string entradaOpcao = Console.ReadLine().ToUpper();
            return entradaOpcao;

        }

        private static Cliente InformeDadosPessoais()
        {
            Console.WriteLine("Digite seu nome completo: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite seu CPF: ");
            string entradaCpf = Console.ReadLine();

            Console.WriteLine("Digite seu RG: ");
            string entradaRg = Console.ReadLine();

            Cliente cliente = new Cliente
                (
                    id:213,
                    nome: entradaNome,
                    cPF: entradaCpf,
                    rG: entradaRg

                ) ;
            return cliente;

        }

        private static Endereco InformeEndereco()
        {
            Endereco novoEndereco = new Endereco("rua","123","cidade","Estado");
            return novoEndereco;
        }
    }
}
