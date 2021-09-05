using AgenciaBancaria.Dominio;
using AgenciaBancaria.Dominio.Repositorio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        //conta corrente
        public static CorrenteRepositorio novaContaCorrente = new CorrenteRepositorio();
        
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
                            var listaContas = novaContaCorrente.Lista();

                            if(listaContas.Count != 0) { 

                                foreach(var contas in listaContas)
                                {
                                    Console.WriteLine("ID:{0} - {1}", contas.RetornarIdConta() ,contas.RetornarCliente());
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
                        try
                        {
                            var informacaoCliente = InformeDadosPessoais();
                            InformeTipoConta(informacaoCliente);
                            
                        }catch(Exception e)
                        {
                            throw new Exception(e.Message);
                        }      
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

            var endereco = InformeEndereco();

            Cliente cliente = new Cliente
                (
                    nome: entradaNome,
                    cPF: entradaCpf,
                    rG: entradaRg,
                   (Endereco)endereco

                ) ;

            return cliente;

        }

        private static Endereco InformeEndereco()
        {
            Console.WriteLine("Informe o nome da sua rua: ");
            string entradaLogadouro = Console.ReadLine();

            Console.WriteLine("Informe seu CEP: ");
            string entradaCEP = Console.ReadLine();

            Console.WriteLine("Informe o nome da sua cidade: ");
            string entradaCidade = Console.ReadLine();

            Console.WriteLine("Informe o seu estado: ");
            string entradaEstado = Console.ReadLine();

            Endereco novoEndereco = new Endereco(entradaLogadouro,entradaCEP,entradaCidade,entradaEstado);

            return novoEndereco;
        }

        private static void InformeTipoConta(Cliente cliente)
        {
            Console.WriteLine("Informe qual tipo de conta você deseja: ");
            Console.WriteLine("1 - Conta Corrente");
            Console.WriteLine("2 - Conta Poupança");

            int decisaoCorrente = int.Parse(Console.ReadLine());

            if (decisaoCorrente == 1)
            {
                try
                {
                    Console.WriteLine("Digite o limite da sua conta");
                    int limite = int.Parse(Console.ReadLine());

                    ContaCorrente correnteConta = new ContaCorrente
                        (
                        cliente:cliente,
                        id: novaContaCorrente.ProximoId(), 
                        limite :limite
                        );

                    Console.WriteLine("Crie sua senha para abrir uma conta corrente!");
                    string senha = Console.ReadLine();

                    correnteConta.AbrirConta(senha);

                    novaContaCorrente.Criar(correnteConta);

                    Console.WriteLine("Parabéns, sua conta Corrente foi criada com sucesso!");
                }catch(Exception e)
                {
                    throw new Exception(e.Message);
                }
               
            }
            else
            {
                try
                {
                    ContaPoupanca poupanca = new ContaPoupanca
                        (
                        cliente,
                        123
                        );

                    Console.WriteLine("Crie sua senha para abrir uma conta Poupança!");
                    string senha = Console.ReadLine();

                    //poupanca.AbrirConta(senha);

                    Console.WriteLine("Parabéns, sua conta Popança foi criada com sucesso!");
                }
                catch (Exception e){
                    throw new Exception(e.Message);
                }
                
            }
        }

        private static void FecharConta()
        {
            Console.WriteLine("Entre com sua conta. Digite o numero da conta: ");
            string entradaUsuario = Console.ReadLine();

            
            
        }
    }
}
