﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Projeto_Cassino
{
    internal class Program
    {
        static void Main()
        {
            Pessoa pessoa = new Pessoa();
            
            int opcao = 1;

            Console.WriteLine("Bem-Vindo ao Cassino");
            Console.WriteLine("Digite seu nome:");
            pessoa.Nome = Console.ReadLine(); 

            while (opcao != 0)
            {
                Console.WriteLine($"Seja Bem-Vindo {pessoa.Nome} \t Saldo: R$ {pessoa.Saldo} \n");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Loteria");
                Console.WriteLine("2 - Raspadinha");
                Console.WriteLine("3 - Depositar/Sacar");
                Console.WriteLine("4 - Relatório JSON");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Clear();
                    Loteria loteria = new Loteria(pessoa);
                }
                else if (opcao == 2)
                {
                    Console.Clear();
                    Raspadinha raspadinha = new Raspadinha(pessoa);
                }
                else if (opcao == 3)
                {
                    Console.Clear();
                    Transacoes transacoes = new Transacoes(pessoa);
                }
                else if (opcao == 4)
                {
                    Console.Clear();
                    Relatorio relatorio = new Relatorio(pessoa);
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
    }
}
