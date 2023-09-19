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
            setNome("");
            setPrezzo(0);
        }

        public Prodotto(string nomeVal, double prezzoVal)
        {
            setNome(nomeVal);
            setPrezzo(prezzoVal);
        }

        public void setNome(string nomeVal)
        {
            nome = nomeVal.ToUpper();
        }
        
        public void setPrezzo(double prezzoVal)
        {
            prezzo = prezzoVal;
        }

        public string getNome()
        {
            return nome;
        }
        public void getPrezzo()
        {
            return prezzo;
        }
    }
}
