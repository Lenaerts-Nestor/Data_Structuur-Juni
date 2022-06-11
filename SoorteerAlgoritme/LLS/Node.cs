using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoorteerAlgoritme.LLS
{
    public class Node
    {

        #region Private fields

        private int value;
        private Node nextNode;

        #endregion

        #region Public fields
        //Value's zetten in de node
        public int GetValue() { return value; } //toon de value van de node
        public void SetValue(int value) { this.value = value; } //dit zet de aangevraagde value in de node, handig als je de value van een node wilt veranderen;

        //Nodes
        public Node GetNextNode() { return nextNode; }
        public void SetNextNode(Node nextNode) { this.nextNode = nextNode; }
        #endregion

        public Node(int value)
        {
            this.value = value;
        }
    }
}
