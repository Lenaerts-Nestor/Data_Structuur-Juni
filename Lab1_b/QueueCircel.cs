using System;

namespace Lab1_b
{
    public class QueueCircel
    {
        #region Private

        private int Front = 0;
        private int Rear = 0;
        private int[] VS1;

        #endregion


        #region Public
        //de lengte geven:
        public QueueCircel(int size)
        {
            VS1 = new int[size];
        }

        //ENQUEUE & DEQUEUE
        public int[] EnQueue(int getal)  //toevoegen
        {
            if (!IsFull())
            {

                VS1[Rear] = getal;
                Rear = (Rear + 1) % VS1.Length;
                return VS1;
            }
            else
            {
                return null; //geef niks terug
            }
        }

        public int[] DeQueue()
        {
            if (!IsEmpty())
            {
                VS1[Front++] = -99;
                if (Front == VS1.Length - 1)
                {
                    Front = 0;
                }
                return VS1;
            }
            else
            {
                Console.WriteLine("NULL");
                return null;
            }
        }


        public bool IsEmpty()
        {
            if (Front == -1)
            {
                return true;
            }
            return false;
        }

        public bool IsFull()
        {

            if ((Rear + 1) % VS1.Length == Front)
            {
                return true;
            }
            return false;
        }
        #endregion
        public void ShowQueue()
        {
            Console.WriteLine($"Array: {string.Join(",", VS1)} FRONT:{Front},REAR: {Rear} ");
        }
    }
}
