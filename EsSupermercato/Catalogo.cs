using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSupermercato
{
    public class Catalogo
    {
        public Dictionary<Prodotto, int> Prodotti;

        public Catalogo(Dictionary<Prodotto, int> v)
        {
            Prodotti = v;
        }

        public Catalogo()
        {
            Prodotti = new();
        }

        public void AggiungiProdotto(Prodotto p, int n)
        {
            if (OttieniQuantitaProdotto(p) <= -n)
            {
                throw new Exception("Non abbastanza");
            }
            if (Prodotti.ContainsKey(p))
            {
                Prodotti[p] += n;
            }
            else
            {
                Prodotti[p] = n;
            }
        }

        public int OttieniQuantitaProdotto(Prodotto p)
        {
            foreach (KeyValuePair<Prodotto, int> keyValuePair in Prodotti)
            {
                if (keyValuePair.Key == p)
                    return keyValuePair.Value;
            }
            return 0;
        }

        public Prodotto? OttieniProdottoPerNome (string n)
        {
            foreach (KeyValuePair<Prodotto, int> keyValuePair in Prodotti)
            {
                if (keyValuePair.Key.Nome == n)
                    return keyValuePair.Key;
            }
            return null;
        }
    }
}
