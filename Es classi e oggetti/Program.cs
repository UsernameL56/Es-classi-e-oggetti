using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

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

            Prodotto prodotto = new Prodotto(valore1, valore2);

            var output = prodotto.Ris();
            Console.WriteLine("Il nome è: " + output.Item1 + "\nIl prezzo è: " + output.Item2);
        }
    }
}
