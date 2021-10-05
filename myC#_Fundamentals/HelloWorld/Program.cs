using System;
using HouseFunction;

/*
    Will be a comment
    - We use PascelCase for the most part and that means naming artifcats as EverythingWillBeCapitalized
    - We use camelCase for naming fields and that means naming artifacts as onlyOnceYouHaveALowerCaseWordAtTheBeginning
*/

namespace HelloWorld
{
    class Program
    {
        /*compiler look for the main method
        static means you dont have to instantiate the program class to use that method.
        void means that the method does not return anything
        
        */

        static void Main(string[] args)
        {
        
            Console.WriteLine("Hello World!");


            Program.Example();

            //instanciate a class
            House DeesHouse = new House();
            UserInput UserInput1 = new UserInput();

            //we set the properties of the house to some value
            DeesHouse.DogName = "Mike";
            DeesHouse.owner = "Jeffrey";

            //display those to the consoel

            Console.WriteLine(DeesHouse.DogName);
            Console.WriteLine(DeesHouse.owner);
            Console.WriteLine(DeesHouse.owner);
            Console.WriteLine("type something");
            UserInput1.TerminalInput = Console.ReadLine();
            Console.WriteLine(UserInput1.TerminalInput);
            

        }
        public static int Example(){
            return 10;
        }
    }
}
