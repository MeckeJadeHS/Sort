using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    class Program
    {
        Program()
        {
            // Diese Methode ist der Konstruktor, der sofort bei der Objekterzeugung ausgeführt wird

            int[] unsortedIntArray = new int[] { 7, 3, 1, 2, 6, 9 }; // deklarieren und initialisieren einen Array von Integer Zahlen
            outArray(unsortedIntArray); // Ausgabe der Arrays - noch unsortiert

            int[] newIntArray = BubbleSort(unsortedIntArray); // Aufruf der Sortierfunktion - Übergabe und Rückgabe eines Integer Arrays
            outArray(newIntArray); // Ausgabe der Arrays - sortiert
            Console.ReadKey(); // warten auf einen Kopfdruck
        }

        static void Main(string[] args)
        {
            // Einstieg in das Programm
            Program p1 = new Program(); // Hier wird ein Objekt der Klasse "Program" erzeugt
                                        // sofort 
            Program p2 = new Program(); // ... und noch eins
        }

        private int[] BubbleSort(int[] intArray)
        {
            Boolean tausch = false;  // Wahr/Falsch Wert für hat in dieser Runde ein Ringtausch stattgefunden?
            int temp; // Zwischenspeicher für den Ringtausch

            do // Start der fußgesteuerten while Schleife
            {
                tausch = false; // Nach jedem Durchlauf muss die Variable zurück gesetzt werden
                // outArray(intArray); // Debug Ausgabe

                for (int ii = 0; ii < intArray.Length - 1; ii++) // Schleife über alle Elemente des Arrays
                {
                    if(intArray[ii] > intArray[ii+1]) // wenn der Nachbar links größer ist als der rechte, dann...
                    {
                        // ... dann Ringtausch
                        temp = intArray[ii];
                        intArray[ii] = intArray[ii + 1];
                        intArray[ii + 1] = temp;

                        tausch = true; // Wenn ein Ringtausch stattgefunden hat, speichere diese Information für die äussere Schleife 
                    }
                }

            } while (tausch); // Hat in dieser Runde ein Ringtausch stattgefunden? Dann weiter in der fußgesteuerten Schleife

            return intArray; // Rückgabe des sortierten Arrays
        }

        private void outArray(int[] intArray)
        {
            // Console.WriteLine(intArray); // Test-Ausgabe
            // Console.WriteLine(intArray.Length); // Test-Ausgabe

            // Schleife über alle Elemente 
            for (int ii=0; ii <= (intArray.Length - 1); ii++)
            {
                Console.Write(intArray[ii] + " ");
            }
            Console.WriteLine();
        }
    }
}
