/* 
 * Aufgabe:
 * 
 *   Erzeugen Sie innerhalb einer Schleife pro Durchlauf jeweils 
 *   3 Gleitkommazufallszahlen. Ihre Schleife soll abbrechen, 
 *   wenn die folgenden 3 Bedingungen alle erfüllt sind:
 * 
 *     - Bedingung A lautet, dass a grösser ist als b
 *     - Bedingung B lautet, dass c zwischen a und b liegt
 *     - Bedingung C lautet, dass der Mittelwert 
 *                           von a, b und c grösser als 0.6 ist
 * 
 *   Geben Sie innerhalb der Schleife die Werte für a, b und c 
 *   jeweils zur Kontrolle aus und stellen Sie fest, wieviele 
 *   Durchläufe notwendig waren, um die Schleife zu beenden, 
 *   d.h. bis die Schleifenbedingung zu 'false' ausgewertet wurde.
 */

using System;

namespace Uebung03Zufallsbedingungen
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("");
            Console.WriteLine("Uebung03 Zufallsbedingungen");
            Console.WriteLine("---------------------------");

            double[] zahlen = new double[3];
            bool[] abbruchBedingnung = new bool[3];
            bool schleifenAbbruch = false;
            int index = 0;
            Random rng = new Random();

            while(!schleifenAbbruch)
            {
                index++;
                Console.WriteLine();
                Console.WriteLine("{0}. Durchlauf", index);
                Console.WriteLine("----------------", index);
                zahlen[0] = rng.NextDouble();
                zahlen[1] = rng.NextDouble();
                zahlen[2] = rng.NextDouble();

                Console.WriteLine("A: {0}\tB: {1}\tC: {2}", zahlen[0], zahlen[1], zahlen[2]);

                abbruchBedingnung[0] = zahlen[0] > zahlen[1];
                abbruchBedingnung[1] = (zahlen[2] > zahlen[0]) && (zahlen[2] < zahlen[1]);
                abbruchBedingnung[2] = ((zahlen[0] + zahlen[1] + zahlen[2]) / 3.0) > 0.6;

                if (abbruchBedingnung[0] || abbruchBedingnung[1] || abbruchBedingnung[2])
                {
                    schleifenAbbruch = true;
                    Console.WriteLine("\nAbbruch ...");
                }
            }

            Console.WriteLine("Grund fuer Schleifenabbruch ...");

            if(abbruchBedingnung[0])
            {
                Console.WriteLine("Bedingung A: A ist groesser B => {0} > {1}", zahlen[0], zahlen[1]);
            }

            if (abbruchBedingnung[1])
            {
                Console.WriteLine("Bedingung B: C liegt zwischen A und B => {0} < {1} < {2}", zahlen[0], zahlen[2], zahlen[1]);
            }

            if (abbruchBedingnung[2])
            {
                Console.WriteLine("Bedingung C: Mittelwert von A, B und C ist groesser als 0.6 => {0} > 0.6", ((zahlen[0] + zahlen[1] + zahlen[2]) / 3.0));
            }

            Console.ReadKey();

        }
    }
}
