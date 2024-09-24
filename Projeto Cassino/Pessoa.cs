using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Projeto_Cassino
{
    internal class Pessoa
    {
        private string nome;
        private int saldo;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                else if (value.Any(char.IsDigit))
                {
                    throw new ArgumentException("O nome não pode conter números.");
                }
                else
                {
                    nome = value;
                }
            }
        }

        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
    }
}