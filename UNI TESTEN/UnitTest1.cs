using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoorteerAlgoritme;
using System;
using System.Diagnostics;

namespace UNI_TESTEN
{
    [TestClass]
    public class UnitTest1
    {/*
        [TestMethod]
        public void TestListVan10()
        {
            RandomGenerator list1 = new RandomGenerator(10, 1, 11);
            BubbleSort eersteoefening = new BubbleSort();
            int[] ACTUALTESTLIJST = new int[10] { 10,9,6,3,4,8,7,5,1,2 }; //deze gaan we sorteren met Microsoft Sort functie:
            int[] expected = eersteoefening.orderdedList(list1.lijst);    //deze gaan we sorteren met onze klasse zelf:
           
            Array.Sort(ACTUALTESTLIJST); //dit is een syntax van microsoft om nummers in een list/array zelf te sorteren, dus deze moet 100% correct zijn denk ik.

            //we gebruiken hier CollectionAssert om te controleren als ze de zelfde waarden hebben op de zelfde positsie met dezelfde array lengte
            CollectionAssert.AreEqual(expected, ACTUALTESTLIJST);
            //we vergerlijke ONZE gesorteerde lijst met die van Microsoft
            
        }
        */
        [TestMethod]
        public void TestListVan100()
        {
            //we gaan nu met een langere lijst:
            RandomGenerator RNGLIST = new RandomGenerator(100, 1, 101); //tussen 1 - 100;
            //deze keer gaan we de random lijst met nummer direct laten sorteren met Syntax sort van microsoft 
            int[] ACTUALSORT = RNGLIST.lijst;
            Array.Sort(ACTUALSORT);

            //we gaan nu die random lijst zelf sorteren met onze eigen klasse:
            BubbleSort eigenSort = new BubbleSort();
            int[] expected = eigenSort.orderdedList(RNGLIST.lijst);

            CollectionAssert.AreEqual(expected, ACTUALSORT); //dit geeft geen errors en is correct


        }
    }
}
