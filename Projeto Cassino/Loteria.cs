using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Projeto_Cassino
{
    internal class Loteria
    {
        public Pessoa pessoa;
        public Loteria(Pessoa pessoa)
        {
            this.pessoa = pessoa;
            int numeroApostas = 0;
            int custo = 2;

            while (numeroApostas < 1000 || numeroApostas > 10000)
            {
               
                Console.WriteLine("Bem-Vindo ao sistema de loteria!!! (R$ 2,00)");
                Console.WriteLine("Digite o seu número da sorte (Mínimo:1000 | Máximo: 10000):");
                numeroApostas = int.Parse(Console.ReadLine());
                if (numeroApostas < 1000 || numeroApostas > 10000)
                {
                    Console.Clear();
                    Console.WriteLine("Número da sorte inválido!!!");
                }
                else if (pessoa.Saldo < custo)
                {
                    Console.WriteLine("Saldo insuficiente!!!");
                    Console.WriteLine("Pressione ENTER para retornar");
                    Console.ReadKey();
                }
                else 
                { 
                    pessoa.Saldo -= custo;
                    Console.WriteLine($"Saldo atual R$ {pessoa.Saldo}");
                    Jogar(numeroApostas);
                }
            }
        }
        

        public void Jogar(int numeroApostas)
        {
            int numeroSorteado = new Random().Next(1000, 10000);
            Console.Clear();
            Console.WriteLine($"Seu numero da sorte: {numeroApostas}");
            Console.WriteLine($"O número sorteado foi: {numeroSorteado}");
            Console.WriteLine("Aguarde o resultado...");
            if(numeroApostas == numeroSorteado)
            {
                Console.WriteLine("Parabéns, você acertou todos os números e ganhou R$ 200,00 !!!");
                pessoa.Saldo += 200;
                Console.WriteLine($"Saldo atual R$ {pessoa.Saldo}");
                Console.WriteLine("Pressione ENTER para retornar");
                Console.ReadKey();
            }
            else if (numeroApostas%1000 == numeroSorteado%1000)
            {
                Console.WriteLine("Parabéns, você acertou os 3 últimos números e ganhou R$ 100,00 !!!");
                pessoa.Saldo += 100;
                Console.WriteLine($"Saldo atual R$ {pessoa.Saldo}");
                Console.WriteLine("Pressione ENTER para retornar");
                Console.ReadKey();
            }
            else if (numeroApostas% 100 == numeroSorteado % 100)
            {
                Console.WriteLine("Parabéns, você acertou os 2 últimos números e ganhou R$ 50,00 !!!");
                pessoa.Saldo += 50;
                Console.WriteLine($"Saldo atual R$ {pessoa.Saldo}");
                Console.WriteLine("Pressione ENTER para retornar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Não foi dessa vez, jogue novamente!!!");
                Console.WriteLine($"Saldo atual R$ {pessoa.Saldo}");
                Console.WriteLine("Pressione ENTER para retornar");
                Console.ReadKey();
            }
        }
    }
}
