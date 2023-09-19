using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classeProva;

namespace Es_classi_e_oggetti
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il nome: ");
            string valore1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Inserisci il prezzo: ");
            double valore2 = Convert.ToDouble(Console.ReadLine());

            classeProva.Prodotto prodottoP = new Prodotto(valore1, valore2);
            classeProva.Prodotto prodottoV = new Prodotto();

            var output1 = prodottoP.Ris();
            Console.WriteLine("Costruttore, Il nome è: " + output1.Item1 + "     Il prezzo è: " + output1.Item2);

            var output2 = prodottoV.Ris();
            Console.WriteLine("Costruttore vuoto, nome: " + output2.Item1 + "   prezzo: " + output2.Item2);
        }
    }
}
