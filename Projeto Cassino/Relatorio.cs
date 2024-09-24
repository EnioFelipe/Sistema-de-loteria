using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Projeto_Cassino
{
    internal class Relatorio
    {

        public Relatorio(Pessoa pessoa)
        {
            string serializado = JsonConvert.SerializeObject(pessoa, Formatting.Indented);

            File.WriteAllText("relatorio.json", serializado);

            Console.WriteLine("Gerando Relatório . . .");
            Console.WriteLine(serializado);
            Console.WriteLine("Pressione ENTER para retornar");
            Console.ReadKey();
            Console.Clear();

        }
    }
}