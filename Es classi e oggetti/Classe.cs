using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_classi_e_oggetti
{
    internal class Classe
    {
        public class Prodotto
        {
            private string nome;
            private double prezzo;

            public Prodotto() { }

            public Prodotto(string nomeVal, double prezzoVal) 
            { 
                nome = nomeVal;
                prezzo= prezzoVal;
            }
        }
    }
}
