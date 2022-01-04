using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2022 {
    class LinkedList {
        private Node _head;

        public void Add(object data) {
            if (_head == null) {
                //LIST EMPTY SO JUST ADD HEAD
                _head = new Node();
                _head.SetData(data);
            }else{
                //START AT HEAD OF LIST
                Node currentNode = _head;

                //REACH END OF LIST
                while(currentNode._next != null) {
                    currentNode = currentNode._next;
                }//end while

                //CREATE NEW NODE IN MEMORY
                Node newNode = new Node();
                newNode.SetData(data);

                //LINK NEW NODE ONTO END OF LIST
                currentNode._next = newNode;
            }//end if
        }//end method

        override public string ToString() {
            //todo print data of all nodes in the list
        }//end if
    }
}
