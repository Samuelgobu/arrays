using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1
            // Erzeugen Sie ein Array mit 4 Zeilen und 4 Spalten.
            // Die Einträge sollen mit Zufallszahlen von 1-99 befüllt werden.
            // Geben Sie das Array in der Console aus.
            // Geben Sie nur Diagonale des Arrays in der Console aus.

            int[,] Tabelle = new int[4, 4];
            Random rnd = new Random();

            //Erzeugen
            for (int i = 0; i < Tabelle.GetLength(0); i++)
            {
                for (int j = 0; j < Tabelle.GetLength(1); j++)
                {
                    Tabelle[i, j] = rnd.Next(0, 100);
                }
            }
            //Ausgabe im die Console
            for (int i = 0; i < Tabelle.GetLength(0); i++)
            {

                for (int j = 0; j < Tabelle.GetLength(1); j++)
                {
                    Console.Write(Tabelle[i, j] + "\t");
                }
                Console.Write("\n");
            }

            Console.Write("\n");
            for (int i = 0; i < Tabelle.GetLength(0); i++)
            {
                //for (int j = 0; j < Tabelle.GetLength(1); j++)
                //{
                //    if (i == j)
                //    {
                //        Console.Write(Tabelle[i, j] + "\t");
                //    }

                //}
                Console.Write(Tabelle[i, i] + "\t");

            }


            //--------------------------------------------------------------

            //Aufgabe 2:
            //Erzeugen Sie ein eindimansionales Array mit sieben Enträgen von Zahle 1-99.
            //Geben Sie die Summe aller Einträge aus und die Größte Zahl des Array.
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            int[] array = new int[7];
            int summe = 0;
            int Gnum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 100);
                Console.Write(array[i] + "\t");
                summe += array[i];
                
            }
            Console.WriteLine("");
            Console.WriteLine("summe="+summe);
            int max =0 ;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }
            Console.WriteLine("max="+ max);
            //------------------------------------------------------------------
            //Geben Sie das Array in umgekehrter Reihenfolge aus.
            for (int i = array.Length-1; i>=0; i--)
            {
                Console.Write(array[i] + "\t");
            }
            Console.Write("\n");
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }

            //Geben Sie das Array von klein nach groß sortiert aus.

            Array.Sort(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + "\t");
            //}
            ArrayZuKonsole(array);

            //Bestimmen Sie den Mittelwert der Einträge des Array und geben Sie diesen aus.
            Console.WriteLine("der Mittelwert von array ist = " + (Convert.ToDouble(summe) / Convert.ToDouble(array.Length)));

            //TeilerListe
            Console.WriteLine("Die Teiler einer Zahl sollen bestimmt werden");
            Console.Write("Zahl eingeben:");
            int zahl = Convert.ToInt32(Console.ReadLine());

            


            //Ausgbe der Teiler Liste:

            ArrayZuKonsole(TeilerListeErstellen(zahl).ToArray());

            


        }
        // Schreiben sie eine Methode, die (int) Arrays in die Konsole ausgibt.
        
        static void ArrayZuKonsole(int[] intArray)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + "\t");
            }
            Console.WriteLine("\n");


            
        }

        //Schreiben Sie eine Methode, die eine ganze Zahl entgegen nimmt, die Teiler dieser Zahl bestimmt und diese in einer Liste zuzück gibt

        static List<int> TeilerListeErstellen(int zahl)
        {
            List<int> Teiler = new List<int>(); //Teiler.Add(..) hinzufügen von Elementen
            for (int i = 1; i <= zahl; i++)
            {
                if (zahl % i == 0)
                {
                    Teiler.Add(i);
                }
                
            }
            

            return Teiler;
        }

    } 

}

