using System;
using System.Linq;

namespace SoorteerAlgoritme
{
    public class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator lijst2 = new RandomGenerator(5,10,70); //lijst van 5 nummers 10 tot 20

            #region BUBBLE SORT
            /*
            BubbleSort test12 = new BubbleSort();
            Console.WriteLine("DIT IS BUBBLE SORT: ");
            test12.orderdedList(lijst2.lijst);
            */
            #endregion

            #region SELECTION SORT
            SelectionSort test2 = new SelectionSort();
            Console.WriteLine("DIT IS SELECTION SORT");
            test2.listSort(lijst2.lijst);
            #endregion

            #region InserSort

            #endregion

        }


    }
}
