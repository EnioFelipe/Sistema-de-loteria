using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
                Console.Clear();
                Console.WriteLine($"Selecione uma opção \t Saldo R${pessoa.Saldo}");
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
            pessoa.Saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!!!");
            Console.WriteLine("Saldo atual: " + pessoa.Saldo);
            Console.WriteLine("Pressione ENTER para retornar");
            Console.ReadKey();
        }
        public void Sacar()
        {
            Console.WriteLine("Digite o valor a ser sacado:");
            int valor = int.Parse(Console.ReadLine());
            if (valor > pessoa.Saldo)
            {
                Console.WriteLine("Saldo insuficiente!!!");
                Console.WriteLine("Pressione ENTER para retornar");
                Console.ReadKey();
                return;
            }
            else
            {
                pessoa.Saldo -= valor;
            }
            Console.WriteLine("Saque realizado com sucesso!!!");
            Console.WriteLine("Saldo atual: " + pessoa.Saldo);
            Console.WriteLine("Pressione ENTER para retornar");
            Console.ReadKey();
        }
    }
}
