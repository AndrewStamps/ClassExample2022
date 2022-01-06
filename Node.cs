using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2022 {
    class Node {

        //PRIVATE FIELDS
        private object _data = null;
        private Node _next = null;
             
        public object Data { 
            get { return _data; }
            set { _data = value;}
        }//end property

        public Node Next {
            get { return _next;}
            set { _next = value;}
        }//end property

    }//end class
}
