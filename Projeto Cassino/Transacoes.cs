using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cassino
{
    internal class Transacoes
    {
        public Pessoa pessoa;
        public Transacoes(Pessoa pessoa)
        {
            this.pessoa = pessoa;

            int opcao = 1;
            while (opcao != 0)
            {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Depositar();
                }
                else if (opcao == 2)
                {
                    Sacar();
                }
                else if (opcao == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Saindo...");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                }
            }
        }

        public void Depositar()
        {
            Console.WriteLine("Digite o valor a ser depositado:");
            int valor = int.Parse(Console.ReadLine());
            pessoa.saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!!!");
            Console.WriteLine("Saldo atual: " + pessoa.saldo);
            Console.ReadKey();
        }
        public void Sacar()
        {
            Console.WriteLine("Digite o valor a ser sacado:");
            int valor = int.Parse(Console.ReadLine());
            if (valor > pessoa.saldo)
            {
                Console.WriteLine("Saldo insuficiente!!!");
                Console.ReadKey();
                return;
            }
            else
            {
                pessoa.saldo -= valor;
            }
            Console.WriteLine("Saque realizado com sucesso!!!");
            Console.WriteLine("Saldo atual: " + pessoa.saldo);
            Console.ReadKey();
        }
    }
}
