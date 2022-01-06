using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2022 {
    class LinkedList {
        private Node _head;
        private int _length = 0;

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

            _length += 1;
        }//end method

        public object Get(int index) {
            Node currentNode = _head;
            int currentIndex = 0;

            if (index < 0 || index >= _length) {
                throw new Exception($"Out of bounds. List has indicies [0 to {_length - 1}], a {index} was sent");      
            }//end if


            while(currentIndex != index) {      
                currentNode = currentNode._next;
                currentIndex += 1;
            }//end while
            
            return currentNode.GetData();

        }//end method

        override public string ToString() {
            string listContents = "[";

            //START AT HEAD OF LIST
            Node currentNode = _head;

            //REACH END OF LIST AND BUILD STRING ALONG THE WAY
            while(currentNode != null) {
   
                if (currentNode._next != null){
                    listContents += currentNode.GetData().ToString() + ", ";
                }else{
                    listContents += currentNode.GetData().ToString() ;
                }//end if
          
                currentNode = currentNode._next;
            }//end while

            listContents += "]";

            return listContents;
        }//end if
    }
}
