using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoorteerAlgoritme.LLS
{
    public class single_list
    {
        //deze private is het eerste element van de lijst van nodes
        private Node head;
       
        public void addFirst(int value)
        {
            //TODO: verwijsing van eerste node:
            //maak het eerste node aan
            Node startnode = new Node(value);
            //dan zeggen we dat de volgende node komt na de start/head  
            startnode.SetNextNode(this.head);
            this.head = startnode;
        }
        public void DeleteStart()
        {
            //met deze methode kunnen we de eerste node verwijderen en de volgende node zetten als eerste of het als null te refereren;
            //dus als we een lijst hadden die start als volgt:
            //n1 => n2 => n3; en we willen dat de eerste element stop met bestaand zeggen we dat de eerste element is gelijk aan de tweede element;
            //n2=>n3;
            head = head.GetNextNode();  
            //in het geval dat we 1 element hadden in onze lijst bv: N1 => niks;
            //dan zet deze methode de eerste element als null en onze list is leeg in deze geval
        }
        public void addEenNode(int value)
        {
            //TODO: toevoegen van element.
            //als de lijst leeg is zeggen we gewoon dat de toegevoegde waarde is gelijk aan de start:
            if (head == null)
            {
                head = new Node(value);
            }

            Node current = head; //kleine verwijsing naar het huidige node;

            //als de volgende node niet leeg is, zetten we een node daar:
            while (current.GetNextNode() != null)
            {
                current = current.GetNextNode();
            }

            //zet de volgende node in de list als de new node
            current.SetNextNode(new Node(value));
        }
      
        public int lengte()
        {

            int lengte = 0;
            Node current = head;

            //nu gaan we tellen hoeveel nodes derzijn
            while (current != null)
            {
                //we beginnen vanaf de eerste te controleren als er een waarde in zit
                lengte++;
                //als er een waarde derin zit bekijken we het volgende node:
                current = current.GetNextNode();
                //als de waarde = null dan stop de loop while en geven we de lengte terug
            }
            return lengte;


        }
      
        public Node Search(int gezochtewaarde)
        {
            Node current = head;
            //als de node niet leeg is: 
            while (current != null)
            {
                //controleer als het zelfde waarde is:
                if (current.GetValue() == gezochtewaarde)
                {
                    return current; //dit is de node die je zoekt (het heeft de waarde dat je vroeg)
                }
                current = current.GetNextNode();
            }
            //als die waarde niet in de lijst staat geef gewoon niks terug
            return null;
        }
        public void ToonList()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.GetValue() );
                current = current.GetNextNode();
            }

            Console.WriteLine($"\n{head.GetValue()} is the head");
            
        }
        public void nodeToevoegenNa(int gezochteNode, int value)
        {
            Node current = head;
            //zoek door de lijst:
            Node toevoegenvoor = new Node(value);
            while (current != null)
            {
                if (current.GetValue() == gezochteNode)
                {
                    toevoegenvoor.SetNextNode(current.GetNextNode());
                    current.SetNextNode(toevoegenvoor);
                    
                }
                current = current.GetNextNode();
            }
        }

        public void nodetoevoegenVoor(int gezochteNode, int value)
        {

            Node current = head;
            //als de node niet leeg is: 
            Node dervoor = current;
            int gevondenindex = 0;
            while (current != null)
            {
                dervoor = dervoor.GetNextNode();
                //controleer als het zelfde waarde is:
                if (dervoor.GetValue() == gezochteNode)
                {
                    //hier hebben we het waarde gevonden:
                    Console.WriteLine($"de nummer voor {gezochteNode} == {current.GetValue()}");
                    //we steken dit in de variabele
                    gevondenindex = current.GetValue();
                    //en we doent dit om geen error te krijgen:
                    dervoor = Search(head.GetValue());
                }

                current = current.GetNextNode();
            }
            //als die waarde niet in de lijst staat geef gewoon niks terug

            //nu hebben we de variabele gevonden die voor de gezochte nummer is
            nodeToevoegenNa(gevondenindex, value);
        }

        public void laatstevinden()
        {
            Node current = head;

            while (current.GetNextNode() != null)
            {
                current = current.GetNextNode();
            }
            Console.WriteLine($"laatste node is: {current.GetValue()}");
        }
    }

}

