using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSupermercato
{
    internal class Spesa
    {
        public Dictionary<Prodotto, int> Prodotti { get; private set; }

        public Spesa()
        {
            Prodotti = new Dictionary<Prodotto, int>();
        }

        public void AggiungiProdotto (Prodotto p, int n)
        {
            if (Prodotti.ContainsKey(p))
            {
                Prodotti[p] += n;
            }
            else
            {
                Prodotti[p] = n;
            }
        }
    }
}
