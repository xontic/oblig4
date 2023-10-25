using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace oblig_4
{
    internal class oppg2
    {
        // Lag et program som generer(og lagrer i et «passende» collection-objekt) 100 000 tilfeldige
        // heltall i området(-1000000, 1000000). Deretter skal programmet finne ut hvor mange
        // distinkte absoluttverdier finnes blant de genererte tallene.
        // Eksempel(for en samling med kun syv tall): dersom tallene er -3, 2, -3, 1, 3, 2, -2 bør vi få
        // svaret 3 (distinkte absoluttverdier).
        // • Tallene -3, -3 og 3 har 3 som absolutt verdi – det blir ett «absolutt tall verdi»
        // • Tallene 2, 2, -2 har 2 som absolutt verdi – det blir ett «absolutt tall verdi» til
        // • Tallet 1 har 1 som absolutt verdi – det blir ett «absolutt tall verdi» til
        // Altså: vi har totalt tre distinkte absoluttverdier.

        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> randomNumbers = new List<int>();
            for (int i = 0; i < 100000; i++)
            {
                int randomNumber = random.Next(-1000000, 1000000);
                randomNumbers.Add(randomNumber);
            }
            List<int> distinctNumbers = new List<int>();
            foreach (int number in randomNumbers)
            {
                if (!distinctNumbers.Contains(Math.Abs(number)))
                {
                    distinctNumbers.Add(Math.Abs(number));
                }
            }
            Console.WriteLine(distinctNumbers.Count);
        }   
    }
}
