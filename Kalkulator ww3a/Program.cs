using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Przechwytuje ile razy ma wykonać się pętla
            Console.WriteLine("Podaj ilośc zadań do wykonania:");
            string t = Console.ReadLine();
            int tests = int.Parse(t);
            int[] suma = new int[tests];
            for (int i = 0; i < tests; i++)
            {
                //Przechwytuje ile razy będzie trzeba dodać liczby
                Console.WriteLine("Podaj ilość liczb do dodania w zadaniu " + (i+1) + ":");
                string iloscLiczb = Console.ReadLine();
                int iloscLiczbInt = int.Parse(iloscLiczb);

                //Przechwytuje liczby do dodania i robi z nich array
                Console.WriteLine("Podaj oddzielone pojedyńczą spacją liczby które mam dodać:");
                string liczby = Console.ReadLine();
                string[] separated = liczby.Split(null);

                //Tworzy int array
                int[] liczbyInt = new int[iloscLiczbInt];
                int wartosc;

                //Zamienia string array na int array
                for (int j = 0; j < iloscLiczbInt; j++)
                {
                    wartosc = int.Parse(separated[j]);
                    liczbyInt[j] = wartosc;
                }
                
                //Sumuje wynik
                for (int k = 0; k < iloscLiczbInt; k++)
                {
                    suma[i] += liczbyInt[k];
                }
            }

            //Drukuje wyniki w konsoli
            for (int l = 0; l < tests; l++)
            {
                Console.WriteLine("Suma liczb " + (l + 1) + " działania wynosi:" + suma[l]);
            }
            
            //:)
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Mam nadzieję że pomogłem :)");
        }
    }
}