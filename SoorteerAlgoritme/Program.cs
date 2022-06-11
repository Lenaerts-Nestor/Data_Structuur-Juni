using System;
using System.Linq;
using SoorteerAlgoritme.LLS;
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
            /*
            SelectionSort test2 = new SelectionSort();
            Console.WriteLine("DIT IS SELECTION SORT");
            test2.listSort(lijst2.lijst);
            */
            #endregion

            #region InserSort
            /*
            InsertionSort test3 = new InsertionSort();
            Console.WriteLine("DIT IS INSTERTION SORT");
            test3.sorteren(lijst2.lijst);
            */
            #endregion
            #region LINKED LIST SORT

            //we creeren eerst 5 nummers/nodes

            single_list lijst1 = new single_list();

            lijst1.addFirst(1);
            lijst1.addEenNode(5);
            lijst1.addEenNode(3);
            lijst1.addEenNode(7);
            lijst1.addEenNode(19);
            lijst1.addFirst(78);
            lijst1.addFirst(9);
            lijst1.ToonList();

            Console.WriteLine("deel 2");

            lijst1.nodeToevoegenNa(19, 8);
            lijst1.nodetoevoegenVoor(8, 6);
            lijst1.addFirst(2);
            lijst1.ToonList();

            #endregion

        }




    }
}
