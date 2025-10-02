using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EsSupermercato
{
    public class Catalogo
    {
        public Dictionary<Prodotto, int> Prodotti { get; set; }

        public Catalogo(Dictionary<Prodotto, int> v)
        {
            Prodotti = v;
        }

        public Catalogo()
        {
            Prodotti = new();
        }

        public Catalogo(List<(Prodotto prodotto, int quantita)> listaTuple)
        {
            Prodotti = new();
            foreach (var tupla in listaTuple)
            {
                Prodotti.Add(tupla.prodotto, tupla.quantita);
            }
        }

        public List<(Prodotto prodotto, int quantita)> ConvertiAListaTuple ()
        {
            List<(Prodotto prodotto, int quantita)> val = new();

            foreach (var pair in Prodotti)
            {
                val.Add((pair.Key, pair.Value)); 
            }
            return val;
        }

        public void AggiungiProdotto(Prodotto p, int n)
        {
            int q = OttieniQuantitaProdotto(p);
            if (q == 0)
            {
                Prodotti[p] = n;
            }
            else if (q < (-n))
            {
                throw new Exception("Non abbastanza");
            }
            else
            {
                Prodotti[p] += n;
                if (Prodotti[p] == 0)
                {
                    Prodotti.Remove(p);
                }

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
                if (keyValuePair.Key.Nome.ToLower() == n.ToLower())
                    return keyValuePair.Key;
            }
            return null;
        }
    }
}
