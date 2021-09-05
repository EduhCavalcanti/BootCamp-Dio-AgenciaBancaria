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

    public abstract class ContaBancaria
    {
        public int NumeroConta { get; init; }
        public int DigitoVerificador { get; init; }
        public decimal Saldo { get; protected set; }
        public DateTime? DataAbertura { get; private set; }
        public DateTime? DataEncerramento { get; private set; }
        public SituacaoConta Situacao { get; private set; }
        public string Senha { get; private set; }
        public Cliente Cliente { get; init; }

        //Contructor
        public ContaBancaria(Cliente cliente)
        {
            //Vai gerar um número randômico quando a conta for aberta  
            Random random = new Random();

            NumeroConta = random.Next(1000,50000);
            DigitoVerificador = random.Next(0,9);
            
            Situacao = SituacaoConta.criada;

            //Se não passar o cliente vai disparar uma exception
            Cliente = cliente ?? throw new Exception("Cliente deve ser informado!");
        }

        //Abertura de conta
        public void AbrirConta(string senha)
        {
            Situacao = SituacaoConta.aberta;
            DataAbertura = DateTime.Now;

            SetarSenha(senha);
        }

        //Fechar conta
        public void FecharConta(string senha, Cliente cliente)
        {
            if(Cliente != cliente)
            {
                throw new Exception("Digite um cliente válido");
            }
            if(Senha != senha)
            {
                throw new Exception("Digite uma senha válida");
            }
            Situacao = SituacaoConta.encerrada;
            DataEncerramento = DateTime.Now;
        }
        
        //Usuário vai digitar uma senha 
        private void SetarSenha(string senha)
        {
            Senha = senha.ValidarCampos();
        }
    
        //Método para sacar
        //Virtual por que vai ser sob escrita por contra classe filha
        public virtual void Sacar(string senha, decimal valor)
        {
            //Vai verificar se a senha está correta
            if(Senha != senha)
            {
                Console.WriteLine("Senha incorreta");
            }
            //Vai verificar se existe saldo na conta
            if(Saldo < valor)
            {
                Console.WriteLine("Seu saldo é insuficiente");
            }

            Saldo -= valor;

        }

        //TESTE 
        public Cliente RetornarCliente()
        {
            return Cliente;
        }
    
    
    }
}
