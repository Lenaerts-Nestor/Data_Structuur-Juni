using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoorteerAlgoritme
{
    public class SelectionSort
    {

        public void listSort(int[] vsList)
        {
            int Pointer = 0; //we gaan de index van de Laagste nummer bewaren in deze variabele tijdelijk zetten.
            int FoundMinValue = 0; //als we de laagste nummer vinden steken we zij WAARDE hier;
            Console.WriteLine($"DIT IS DE LIJST DIE WE GAAN SORTEREN: {string.Join(",", vsList)}");
           

            for (int Main = 0; Main < vsList.Length - 1; Main++)
            {
                //we gaan nu de lijst overlopen
                Console.WriteLine($"Iteratie {Main+1}");
                Pointer = Main;


                for (int Remaining = Main + 1; Remaining < vsList.Length; Remaining++)
                {

                    //we overlopen het lijst.
                    //we vergelijken alle items en controleren welke het laagste is:
                    if (vsList[Remaining] < vsList[Pointer])
                    {
                        //we steken het tijdelijke laatste waarde index positie bij de pointer: 
                        Pointer = Remaining;
                    }
                    
                }
              
                //we zeggen de laagste waarde waar de pointer was, steken we het in gevonden laagste Value
                FoundMinValue = vsList[Pointer];
                //Nu doen we de swap:
                vsList[Pointer] = vsList[Main];
                vsList[Main] = FoundMinValue;
             
                Console.WriteLine($"{string.Join(",", vsList)}\n");
            }
            Console.WriteLine("\nEINDE\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{string.Join(",", vsList)}");
            Console.ResetColor();


        }
    }
}
