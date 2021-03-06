using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionFunction
{
    public class CollectionFunction
    {
        //Generic Collection

        List<string> myStrings = new List<string>();
        List<int> myNumbers = new List<int>();
        List<string> fruitList = new List<string>();

        /**
        the compiler will always give a default constructor for the class
        public Collection(){}


        but then you can create your own constructor then that will replace what compiler would 
        have generated

        public Collection(int someNumber)
        {
            myNumbers.add(someNumber)

        }
        **/

        public void CollectionMain()
        {
            Console.Writeline("###################this is the Collection Demo +++++++++++++++++++");
            Console.Writeline("**********List Demo********");

            //Adding new element to a collection   

            itemList.add("apples","Açaí","Acerola","Ackee", "African cucumber", 
            "Apple","Apricot"," Avocado", "Banana", "Bilberry", "Blackberry",
            "Blackcurrant", "Black sapote", "Blueberry" , "Boysenberry" ,"Breadfruit ",
            "Buddha's hand (fingered citron)", "Cactus pear", "Canistel" , "Cempedak",
            "Cherimoya (Custard Apple)", "Cherry", "Chico fruit" , "Cloudberry",
            "Coco De Mer", "Coconut", "Crab apple","Cranberry","Currant","Damson",
            "Date", "Dragonfruit (or Pitaya)", "Durian", "Egg Fruit", "Elderberry",
            "Feijoa","Fig");

            //going throu the list using a foreach 

            Console.Writeline("*******************Our Foreach*******************");
            foreach (string fruit in fruitList)
            {
                Console.Writeline(fruit);
            }

            Console.Writeline("********************** For loop Demo **************");/**for loop
            is more friendlier in customizing iterations of a list because then you can change the 
            the condidtions  */

            for (int i = 0; i<fruitList.count; i++)   {
                Console.Writeline("the currently available fruits are : ")
                
            }        
            
        }

        
    }
}