using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace oblig_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Oppgave 1
            //Lag et program som leser 10 tekststrenger(fra tastatur) og lagrer disse i et «passende»
            //collection - objekt). Deretter skal programmet vise(skrive ut til skjerm) alle tekststrenger på to
            //forskjellige måter:
            //• i alfabetiske rekkefølge(først),
            //• sortert pga. antall av bokstaver ‘a’ (deretter).

            //            Du skal bruke passende Collections - datatype(r) i hver oppgave.Det er ikke lov å bruke ‘vanlige
            //tabeller’ (med[])

            List<string> inputStrings = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Skriv inn en tekststreng");
                string input = Console.ReadLine();
                inputStrings.Add(input);
            }

            // siden dette er en liste kan vi bruke sort det er og et alternativ å bruke boble sortering kansje 


        //for (int i = 0; i < 10; i++)
        //    {
        //    Console.WriteLine("Skriv inn en tekststreng");
        //    string input = Console.ReadLine();
        //        string[] inputArray = new string[10];
        //        inputArray[i] = input;
        //    }

        }
    }
}