using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EsSupermercato
{
    internal class Prodotto
    {
        public string Nome
        {
            get
            {
                return Nome;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(Nome))
                {
                    throw new Exception("Nome invalido");
                }
                else
                {
                    Nome = value;
                }
            }
        }

        public Prodotto(string nome)
        {
            Nome = nome;
        }
    }
}
