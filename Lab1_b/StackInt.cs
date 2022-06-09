using System;
using System.Diagnostics;

namespace Lab1_b
{
    public class StackInt
    {
        //Peek:
        public int Peek = -1;
        public int[] arrayStack { get; set; } = new int[5]; //lengte 5;
        public int[] Push(int[] array)
        {
            //top positie [peek] weten en controleren als de peek == array.length

            int getall = 0;

            if (!IsFull(array))
            {
                Console.WriteLine("welke waarde wil je toevoegen: ");
                getall = Convert.ToInt32(Console.ReadLine());
                //waarde toevoegen aan array
                Peek++;
                array[Peek] = getall;
                ShowStack();

                return array;
            }
            else
            {
                //normaal moet ik dit niet tonen maar ik doe het om te controleren als de lijst all vol is enzo.
                //waarde negeren en array terug geven
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("array is all vol");
                Console.ResetColor();
                return array;
            }


        }
        public int[] Pop(int[] array)
        {
            //controleren als de array niet leeg is
            if (!IsEmpty(array))
            {
                Console.WriteLine("er werd een getal verwijderd");
                array[Peek] = 0;
                Peek--;
                ShowStack();
                return array;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("array is all leeg");
                Console.ResetColor();
                inhoud(array);
                return array;
            }


        }
        public void inhoud(int[] array)
        {

            Console.Write("\nArray inhoud: ");
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write($"{array[i]} ");
                Console.Write(", ");
            }
            Console.WriteLine($"Peek: {Peek}");
            Console.WriteLine("\n");
        }

        public bool IsEmpty(int[] array)
        {
            if (Peek == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull(int[] array)
        {
            if (Peek == array.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //dit is visuele stuening [hoeft niet]
        public void ShowStack()
        {
            Debug.WriteLine($"{ string.Join(",", arrayStack)}. Peek = {Peek}");
        }

    }





}
