using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EsSupermercato
{
    public class Prodotto
    {
        private float prezzo;
        public float Prezzo
        {
            get
            {
                return prezzo;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Prezzo invalido");
                }
                else
                {
                    prezzo = value;
                }
            }
        }

        private string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Nome invalido");
                }
                else
                {
                    nome = value;
                }
            }
        }

        public Prodotto(string nome, float prezzo)
        {
            Nome = nome;
            Prezzo = prezzo;
        }
    }
}
