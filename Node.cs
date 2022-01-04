using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2022 {
    class Node {

        private object _data = null;
        public Node _next = null;

        public void SetData(object newData) {
            _data = newData;
        }//end method
        public object GetData() {
            return _data;
        }//end method

    }//end class
}
