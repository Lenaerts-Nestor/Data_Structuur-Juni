using System;
using System.Linq;

namespace Lab1_b
{
    public class QueueInt
    {
        #region Private Sector
        private int Front = 0;
        private int Rear = -1;
        private int[] VS1;
        #endregion

        #region Public Sector
        public QueueInt(int size)
        {
            VS1 = new int[size];
        }
        public int[] EnQueue(int getal)  //toevoegen
        {
            if (!IsFull())
            {
                VS1[++Rear] = getal;
                return VS1;

            }
            else
            {

                int[] VS2 = new int[VS1.Length * 2];
                VS1.CopyTo(VS2, 0);
                VS1 = VS2;
                //het getal nogsteed toevoegen nadat de lengte is verhoogd
                VS1[++Rear] = getal;
                return VS1;
            }
        }

        public int[] DeQueue()
        {
            if (!IsEmpty())
            {
                VS1 = VS1.Skip(Front).ToArray();
                Front++;
                Rear--;
                return VS1;
            }
            else
            {
                return null;
            }
        }


        public bool IsEmpty()
        {
            if (Front != -1)
            {
                return false;
            }
            return true;
        }

        public bool IsFull()
        {
            if (Rear >= VS1.Length - 1)
            {
                return true;
            }
            return false;
        }


        public void ShowQueue()
        {
            Console.WriteLine($"Array: {string.Join(",", VS1)} FRONT:{Front},REAR: {Rear} ");
        }
        #endregion
    }
}
