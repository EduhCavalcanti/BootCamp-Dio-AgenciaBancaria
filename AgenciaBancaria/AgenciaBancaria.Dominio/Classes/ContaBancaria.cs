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
        public int Id { get; set; }
        public int NumeroConta { get; init; }
        public int DigitoVerificador { get; init; }
        public decimal Saldo { get; protected set; }
        public DateTime? DataAbertura { get; private set; }
        public DateTime? DataEncerramento { get; private set; }
        public SituacaoConta Situacao { get; private set; }
        public string Senha { get; private set; }
        public Cliente Cliente { get; init; }

        //Contructor
        public ContaBancaria(Cliente cliente, int id)
        {
            Id = id;
            //Vai gerar um número randômico quando a conta for aberta  
            Random random = new Random();

            NumeroConta = random.Next(1000,50000);
            DigitoVerificador = random.Next(0,9);
            
            Situacao = SituacaoConta.criada;

            //Se não passar o cliente vai disparar uma exception
            Cliente = cliente ?? throw new Exception("Cliente deve ser informado!");
        }

        public override string ToString()
        {
            string retornar = "";
            retornar += Cliente + Environment.NewLine;
            retornar += "Numero da conta: " + NumeroConta + Environment.NewLine;
            retornar += "Saldo da conta: " + Saldo + Environment.NewLine;
            retornar += "Situação da conta: " + Situacao + Environment.NewLine;

            return retornar;
        }

        //Abertura de conta
        public void AbrirConta(string senha)
        {
            Situacao = SituacaoConta.aberta;
            DataAbertura = DateTime.Now;

            SetarSenha(senha);
        }

        //Fechar conta
        public void FecharConta()
        {
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
        public virtual void Sacar(decimal valor)
        {
            //Vai verificar se existe saldo na conta
            if(Saldo < valor)
            {
                Console.WriteLine("Seu saldo é insuficiente");
            }
            else 
            { 
                Saldo -= valor;
            }
        }

        //Retornar saldo
        public decimal RetornarSaldo()
        {
            return Saldo;
        }

        //Depositar
        public decimal Depositar(decimal valor)
        {
            return Saldo += valor;
        }
        //Retorna nome do cliente
        public string RetornarCliente()
        {
            return Cliente.Nome;
        }
        //Retorna Id da conta
        public int RetornarIdConta()
        {
            return Id;
        }
        //Retornar Cpf do cliente
        public string RetornarCpf()
        {
            return Cliente.CPF;
        }

        public SituacaoConta retornarSituacaoDaConta()
        {
            return Situacao;
        }

        //Verifica o senha passada
        public bool VerificarSenha(string senha)
        {
            if(Senha != senha)
            {
                return false;
            }
            return true;
        }
    
    }
}
