using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cassino
{
    internal class Raspadinha
    {
        static Random random = new Random();
        public Pessoa pessoa;
        public Raspadinha(Pessoa pessoa)
        {
            this.pessoa = pessoa;

            int tipo = 1;
            while (tipo != 0)
            {
                Console.Clear();
                Console.WriteLine("Bem-Vindo ao sistema de Raspadinha!!!");
                Console.WriteLine("Selecione o tipo de Raspadinha:");
                Console.WriteLine("1 - Raspadinha de 5 números (R$ 5,00)");
                Console.WriteLine("2 - Raspadinha de 10 números (R$ 10,00)");
                Console.WriteLine("0 - Sair");
                tipo = int.Parse(Console.ReadLine());

                if (tipo == 1)
                {
                    if (pessoa.saldo >= 5)
                    {
                        Raspadinha5();
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente!!!");
                        Console.ReadKey();
                    }

                }
                else if (tipo == 2)
                {
                    Raspadinha10();
                }
                else if (tipo == 0)
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

        public void Raspadinha5()
        {
            int numeroPrincipal = 0;
            int premioTotal = 0;

            int[] sorteios = new int[5];
            int[] premios = new int[5];

            for (int i = 0; i < 5; i++)
            {
                sorteios[i] = random.Next(1, 10);
                premios[i] = random.Next(1, 10);
            }

            while (numeroPrincipal < 1 || numeroPrincipal > 10)
            {
                Console.Clear();
                Console.WriteLine("Digite o número principal (Mínimo:1 | Máximo: 10):");
                numeroPrincipal = int.Parse(Console.ReadLine());
                if (numeroPrincipal < 1 || numeroPrincipal > 10)
                {
                    Console.WriteLine("Número inválido!!!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Número principal: " + numeroPrincipal);
                    Console.WriteLine("Aguarde o resultado...");

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"{i + 1}º Número: {sorteios[i]}, Prêmio R$ {premios[i]}");
                        if (sorteios[i] == numeroPrincipal)
                        {
                            premioTotal += premios[i];
                        }
                    }

                    if (premioTotal > 0)
                    {
                        Console.WriteLine("Parabéns você ganhou!!!");
                        pessoa.saldo += premioTotal;
                        Console.WriteLine("Saldo atual: " + pessoa.saldo);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Que pena, não foi dessa vez, jogue novamente!");
                        Console.ReadKey();
                }
            }

        }

        public void Raspadinha10()
        {
            int numeroPrincipal = 0;
            int premioTotal = random.Next(1, 100);
            int contador = 0;

            int[] sorteios = new int[10];
            
            for (int i = 0; i < 10; i++)
            {
                sorteios[i] = random.Next(1, 10);
            }

            while (numeroPrincipal < 1 || numeroPrincipal > 10)
            {
                Console.Clear();
                Console.WriteLine("Digite o número principal (Mínimo:1 | Máximo: 10):");
                numeroPrincipal = int.Parse(Console.ReadLine());
                if (numeroPrincipal < 1 || numeroPrincipal > 10)
                {
                    Console.WriteLine("Número inválido!!!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Número principal: " + numeroPrincipal);
                    Console.WriteLine("Aguarde o resultado...");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"{i + 1}º Número: {sorteios[i]}");
                        if (sorteios[i] == numeroPrincipal)
                        {
                            contador++;
                        }
                    }

                    if (contador == 3)
                    {
                        Console.WriteLine("Parabéns o seu número apareceu 3 Vezes");
                        Console.WriteLine($"Prêmio total: R$ {premioTotal}");
                        Console.ReadKey();
                    }
                    else if (contador == 5)
                    {
                        Console.WriteLine("Parabéns o seu número apareceu 5 Vezes");
                        Console.WriteLine($"Prêmio total: R$ {premioTotal*2}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Que pena, não foi dessa vez, jogue novamente!");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
