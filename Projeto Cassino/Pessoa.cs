using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cassino
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public int saldo { get; set; }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string value)
        {
            nome = value;
        }

        public int GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(int value)
        {
            saldo = value;
        }

    }
}
