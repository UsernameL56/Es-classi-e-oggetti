using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeProva
{
    public class Class1
    {
        
    }
    public class Prodotto
    {
        //attributi
        private string nome;
        private double prezzo;


        public (string, double) Ris()
        {
            return (nome, prezzo);
        }

        // costruttore vuoto
        public Prodotto() 
        {
            nome = "";
            prezzo= 0;
        }

        // costruttore
        public Prodotto(string nomeVal, double prezzoVal)
        {
            nome = nomeVal;
            prezzo = prezzoVal;
        }
    }
}
