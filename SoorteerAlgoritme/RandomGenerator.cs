using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoorteerAlgoritme
{
    public class RandomGenerator
    {
        public int[] lijst;
        public RandomGenerator(int Amount,int Min,int Max)
        {
            lijst = new int[Amount];
            Random vsRandom = new Random();
            int getal = 0;
            //controleren als het niet in het lijst zit:
            for (int i = 0; i < lijst.Length; i++) //zonder -1
            {
                getal = vsRandom.Next(Min, Max);
                if (!lijst.Contains(getal)) //ALS HET NIET IN DE LIJST ZIT
                {
                    lijst[i] = getal;
                }
                else
                {
                    i--;
                }
            }

        }


    }
}
