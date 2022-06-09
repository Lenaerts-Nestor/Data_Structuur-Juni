using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoorteerAlgoritme
{
    public class BubbleSort
    {
        //lijst met unique random nummers aanroepen:
        RandomGenerator lijst1 = new RandomGenerator(10, 1, 11);

        public int[] orderdedList(int[] vslist)
        {   //DIT IS HET LIJST DIE WE MOETEN ORDEREN
            /*
            Console.WriteLine($"DIT IS HET LIJST DIE WE MOETEN SORTEREN: {string.Join(",", vslist)}");
            */
            for (int j = 1; j <= vslist.Length - 1; j++) //loop voor de iteraties
            {
                for (int i = 0; i < vslist.Length - j; i++)     //1 iteratie
                {
                    if (vslist[i] > vslist[i + 1])
                    {
                        int temp = vslist[i];           //temp = aan de grootste 
                        vslist[i] = vslist[i + 1];      //we doen een swap;
                        vslist[i + 1] = temp;

                    }
                    /*
                    Console.WriteLine(string.Join(",", vslist) + $"\t[i]: {i}, [j]: {j}");
                    */
                }

            }


            Console.WriteLine($"LIJST: {string.Join(",", vslist)}");
            return vslist;;
        }

    }

}
