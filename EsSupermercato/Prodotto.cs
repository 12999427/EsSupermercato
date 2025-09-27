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
        public float Prezzo
        {
            get
            {
                return Prezzo;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Prezzo invalido");
                }
                else
                {
                    Prezzo = value;
                }
            }
        }
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

        public Prodotto(string nome, float prezzo)
        {
            Nome = nome;
            Prezzo = prezzo;
        }
    }
}
