using System;

namespace ClassExample2022 {
    class Program {
        
        static void Main(string[] args) {
            LinkedList classList = new LinkedList();

            classList.Add("Andrew");
            classList.Add("Alex");
            classList.Add(7);
            classList.Add("Zach");
            classList.Add("Courtney");

            //Console.WriteLine(classList.Get(-3));
            Console.WriteLine(classList.Get(0));   
            Console.WriteLine(classList.Get(3));   
            Console.WriteLine(classList.Get(4));   
            Console.WriteLine(classList.Get(5));
                                                

            Console.WriteLine(classList.ToString());  
        }//end method

    }//end class

   
}
