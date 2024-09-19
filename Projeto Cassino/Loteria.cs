using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cassino
{
    internal class Loteria
    {
        public Loteria()
        {
            int numeroApostas = 0;

            while (numeroApostas < 1000 || numeroApostas > 10000)
            {
               
                Console.WriteLine("Bem-Vindo ao sistema de loteria!!!");
                Console.WriteLine("Digite o seu número da sorte (Mínimo:1000 | Máximo: 10000):");
                numeroApostas = int.Parse(Console.ReadLine());
                if (numeroApostas < 1000 || numeroApostas > 10000)
                {
                    Console.Clear();
                    Console.WriteLine("Número da sorte inválido!!!");
                }
                else
                {
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
                Console.WriteLine("Parabéns, você acertou todos os números e ganhou 1ºPRÊMIO !!!");
                Console.ReadKey();
            }
            else if (numeroApostas%1000 == numeroSorteado%1000)
            {
                Console.WriteLine("Parabéns, você acertou os 3 últimos números e ganhou 2ºPRÊMIO !!!");
                Console.ReadKey();
            }
            else if (numeroApostas% 100 == numeroSorteado % 100)
            {
                Console.WriteLine("Parabéns, você acertou os 2 últimos números e ganhou 3ºPRÊMIO !!!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Não foi dessa vez, jogue novamente!!!");
                Console.ReadKey();
            }
        }
    }
}
