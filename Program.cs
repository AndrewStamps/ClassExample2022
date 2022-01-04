using System;

namespace ClassExample2022 {
    class Program {
        
        static void Main(string[] args) {
            LinkedList classList = new LinkedList();

            classList.Add("Andrew");
            classList.Add("Alex");
            classList.Add("Jose");
            classList.Add("Zach");
            classList.Add("Courtney");

            Console.WriteLine(classList.Get(-3));//should return "Alex"  
            Console.WriteLine(classList.ToString());  
        }//end method

    }//end class

   
}
