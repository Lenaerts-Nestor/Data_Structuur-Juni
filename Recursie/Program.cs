using System;

namespace Recursie
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region ROKET COUNTDOWN
            //Roket Countdown:
            /*
             Console.WriteLine("geef een getal in groter of gelijk aan 0");
             int getal = Convert.ToInt32(Console.ReadLine());
             Countdown(getal);
            */
            #endregion

            #region Upcounter / TELLER
            /*
            Upcounter(6);
            */
            #endregion

            #region faculteit
            /*
            Console.WriteLine(Faculteit(9));
            */
            #endregion

            #region reverse text en mischien  //LinearQUUESTRING REVERSE ook:
            /*
            string text = "aardgasreserves";
            Console.WriteLine($"reverse: {Reverse(text)}");
            string maybe = Reverse(text);
            maybe.ToCharArray(0, maybe.Length - 1);
            for (int i = 0; i < text.Length-1; i++)
            {
                Console.WriteLine(maybe[i]);
            }*/
            #endregion

            #region TORRENSPEL
            VerplaatsTorren(3, "A", "C", "B");

            #endregion


        }
        //Countdown raket:
        static void Countdown(int number)
        {

            if (number > 0)
            {
                Console.Write($"{number}..");
                Countdown(number - 1);

            }

            if (number == 0) Console.Write("Take-off !");
        }

        //Teller:
        static void Upcounter(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"Number waarde : {number}");
                Upcounter(number - 1);
                Console.WriteLine($"{number}");

            }

        }
        //Faculteit berekenen:
        static int Faculteit(int number)
        {

            Console.WriteLine(number);
            if (number == 1)
            {
                return 1;
            }
            else
            {

                int som = number * Faculteit(number - 1);
                Console.WriteLine($"{som}");
                return som;
            }
        }

        static string Reverse(string text)
        {
            //DIT IS SOORT VAN QUEUEU OOK DENK IK

            if (text.Length == 0) return text;
          
            
            return text[text.Length-1] + Reverse(text.Substring(0,text.Length-1));

          
        }

       //het doel is om alle disk naar C te brengen
        static void VerplaatsTorren(int DISKS, string bron, string doel , string hulp)
        {
            Console.WriteLine("START");
            /*
            bron = "A";
            doel = "C";
            hulp = "B";
            */
            if(DISKS == 1)
            {
                Console.WriteLine($"DISK: {DISKS}, wordt verplaats van {bron} naar {doel}");
            }
            else
            {
                //DISK 2
                VerplaatsTorren(DISKS - 1, bron, hulp, doel);
                Console.WriteLine($"DISK: {DISKS}, wordt verplaats van {bron} naar {doel}");

                //DISK 1 nu
                VerplaatsTorren(DISKS - 1,doel,hulp,bron);

            }
            


        }


    }
}
