using System;

namespace Lab1_b
{
    public class Program
    {
        public static int peek = -1;

        static void Main(string[] args)
        {
            //MET OO-structuur:

            //STACK***************************************************************************************************************************
            /*
             StackInt array1 = new StackInt();
             //hier gaan we de array doorlopen
             for (int i = 0; i < array1.arrayStack.Length+1; i++)
             {
                 array1.Push(array1.arrayStack);
             }
             Console.ReadKey();
             Console.Clear();
             //hier gaan we over het array om te testen wat er gebuert
             for (int i = 0; i < array1.arrayStack.Length+1; i++)
             {
                 array1.Pop(array1.arrayStack);
             }

             Console.WriteLine("\n\n");
             Console.WriteLine("EINDE");
             */
            //QUEUE **************************************************************************************************************************
            /*
            QueueInt queue1 = new QueueInt(5);

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("voeg een waarde");
                int getal = Convert.ToInt32(Console.ReadLine());
                queue1.EnQueue(getal);
                queue1.ShowQueue();
                
            }
            Console.WriteLine("\n\nDEQUEUE"); 
            //HAAL DE EERSTE 3 NUMMERS DERUIT
            queue1.DeQueue();
            queue1.DeQueue();
            queue1.DeQueue();
            queue1.ShowQueue();

            Console.WriteLine("\n\nENQUEUE OPNIEUW");

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("voeg een waarde");
                int getal = Convert.ToInt32(Console.ReadLine());
                queue1.EnQueue(getal);
                queue1.ShowQueue();

            }


            */




            //QUEUE Circle ********************************************************************************************************************

            QueueCircel queueCircel1 = new QueueCircel(5);



            string loopje = "";
            do
            {
                Console.WriteLine("wil je toevoegen of verwijderen? 1 of 2"); ;
                int antwoord = Convert.ToInt32(Console.ReadLine());
                switch (antwoord)
                {
                    case 1:
                        Console.WriteLine("het bedrag?");
                        int getal = Convert.ToInt32(Console.ReadLine());
                        queueCircel1.EnQueue(getal);
                        queueCircel1.ShowQueue();
                        break;
                    case 2:
                        queueCircel1.DeQueue();
                        queueCircel1.ShowQueue();
                        break;
                    default:
                        Console.WriteLine("er is iets fout geweest");
                        loopje = "iets";
                        break;

                }
                Console.WriteLine("wil je verder gaan");
                loopje = Console.ReadLine();

            } while (loopje == "");

        }




        ///deze hieronder is de stack zonder OO-Strucuur:
        /*
         In Main: 
            int[] arrayStack = new int[5];
            Push(arrayStack);       //voeg eerst  getal in het lijst
            Push(arrayStack);       //voeg tweede getal
            Push(arrayStack);       //voeg derde  getal 
            Push(arrayStack);       //....
            Push(arrayStack);       //....
            Pop(arrayStack);        //haal derde deruit
            Pop(arrayStack);        //haal tweede deruit
            Pop(arrayStack);        //haal eerste deruit
            Pop(arrayStack);        //...
            Pop(arrayStack);        //array terug leeg krijgen*/


        /*
         ///Methodes: Push en Pop
         static int[] Push( int[] array)
         {
                 //top positie [peek] weten en controleren als de peek == array.length
             Console.WriteLine("welke waarde wil je toevoegen: ");
                 ///om te controleren als het een type int is if:[getall is int]  of if (getal.GetType() == typeof(int)).
                 ///maar we hebben convert.to int gedaan dus systeem gaat zelf error geven als het geen int waarde word ingegeven.

             int getall = Convert.ToInt32(Console.ReadLine());

             if (peek < array.Length-1) 
             {
                 //waarde toevoegen aan array
                 peek++;
                 array[peek] = getall;
                 inhoud(array);

                 return array;
             }
             else
             {
                     //normaal moet ik dit niet tonen maar ik doe het om te controleren als de lijst all vol is enzo.
                     //waarde negeren en array terug geven
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("array is all vol");
                 inhoud(array);
                 Console.ResetColor();
                 return array;
             }


         }
         static int[] Pop(int[] array)
         {
                 //controleren als de array niet leeg is
             if (peek >= 0)
             {
                 Console.WriteLine("er werd een getal verwijderd");
                 array[peek] = 0;
                 peek--;
                 inhoud(array);
                 return array;
             }
             else
             {
                 Console.WriteLine("array is all leeg");
                 inhoud(array);
                 return array;
             }


         }

             //een methode om de Array inhoude eens te kijken [dees word niet gevraagd]:
         static void inhoud(int[] array)
         {

             Console.Write("\nArray inhoud: ");
             for (int i = 0; i < array.Length; i++)
             {

                 Console.Write($"{array[i]} ");
                 Console.Write(", ");
             }
             Console.WriteLine($"Peek: {peek}");
             Console.WriteLine("\n");
         }
        */
    }
}
