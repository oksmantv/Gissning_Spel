using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Här är ett exempel på hur dialogen mellan användaren och datorn kan se ut.
 
Gissa ett tal mellan 1 och 100.
Gissning 1: 50
Talet är större.
Gissning 2: 75
Talet är mindre.
Gissning 3: 60
Talet är mindre.
Gissning 4: Fyra
Du kan bara skriva ett tal med siffror. Försök igen!
Gissning 4: 55
Rätt! Du gissade rätt på 4 försök.
Vill du spela igen (Ja/Nej)? Nope
Vill du spela igen (Ja/Nej)? Nej
Tack för den här gången!
*/

namespace OKS_Gissning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool spela = true;
            while (spela)
            {

                Console.WriteLine("Gissa ett tal mellan 1 och 100.");
                Random rnd = new Random();
                int talet = rnd.Next(1, 101);  // creates a number between 1 & 100
                int index = 1;

                
                // Debug om du villl använda för testning.
                //Console.WriteLine("Debug: Rätta svaret är {0}", talet);

                while (true)
                {
                    Console.Write("Gissning {0}: ", index);
                    bool check = int.TryParse(Console.ReadLine(), out int answer);
                    if (!check) { Console.WriteLine("Du kan bara skriva ett tal med siffror. Försök igen!"); continue; }

                    if (answer > talet) { Console.WriteLine("Talet är mindre!"); index++; }
                    else if (answer < talet) { Console.WriteLine("Talet är större!"); index++; }
                    else if (answer == talet) { Console.WriteLine("Rätt! Du gissade rätt på {0} försök.", index); break; }

                }

                while (true)
                {

                    Console.WriteLine("Vill du spela igen? (Ja / Nej)");
                    string kör = Console.ReadLine().ToLower();

                    if (kör == "ja") { break; }
                    else if (kör == "nej") { Console.WriteLine("Tack för den här gången!"); spela = false; break; }

                }
            }

            Console.ReadLine();
        }
    }
}