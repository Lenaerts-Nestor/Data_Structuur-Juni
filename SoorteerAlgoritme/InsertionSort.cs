using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoorteerAlgoritme
{
    internal class InsertionSort
    {

        public void sorteren(int[] vslist)
        {

            int I = 1; //deze gebruiken we om naar achter te gaan
            int J = 1; //deze is om de index van de element die we proberen te swapen

            int temp = 0; //temp gebruiken we voor het swap 

            //ga van 1 tot de einde van de lijst
            while (I < vslist.Length)
            {
                J = I; //zet de index van het huidige element dat we zijn aan het zoeken.
                //zolang er een nummer groter is aan de rechter kant dat we nog niet gegaan zijn
                //elke element die we veranderen van positie zetten we ze naar links

                while (J > 0 && vslist[J-1] > vslist[J])
                {
                    //bewaar het nummer tijdelijk met temp:
                    temp = vslist[J];
                    //NU SWAPEN:
                    vslist[J] = vslist[J - 1];
                    vslist[J - 1] = temp;

                    //verlaag J om te vergergelijken met de linkse element sebiet:
                    J--;

                    //HERINER DAT DIT IS EEN WHILE. zolang J > 0 gaat die elke keer controleren
                }
                I++;

            }



        }
    }
}
