using System;

namespace ScontoSupermercato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci l'importo totale");
            double importo = double.Parse(Console.ReadLine());
            double importotot = 0;
            double sconto = 0;
            if (importo < 50)
            {
                sconto = importo * 5 / 100;
                importotot = importo - sconto;
                Console.WriteLine($"l'importo scontato è {importotot:c}");
            }
            else if (importo > 50 && importo < 65)
            {
                sconto = importo * 6 / 100;
                importotot = importo - sconto;
                Console.WriteLine($"l'importo scontato è {importotot:c}");
            }
            else if (importo > 65 && importo < 80)
            {
                sconto = importo * 7 / 100;
                importotot = importo - sconto;
                Console.WriteLine($"l'importo scontato è {importotot:c}");
            }
            else if (importo > 80)
            {
                sconto = importo * 10 / 100;
                importotot = importo - sconto;
                Console.WriteLine($"l'importo scontato è {importotot:c}");
            }
            Console.ReadLine();
        }
        
    }
}
