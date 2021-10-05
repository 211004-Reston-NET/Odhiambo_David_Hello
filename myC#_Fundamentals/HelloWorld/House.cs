namespace HouseFunction
{

    public class House
    {
        //variabble
        //private makes this field belong to just this class and no other
        private string owner;
        private string ghost;
        private int roomcount;

        //constructor
        public House(){
            owner =  "odhi";
            ghost = "Casper";
            roomcount = 4;
        
        }
        //creating properties  for getters and setters
        public string owner{
            get{
                return owner;
            }

            //setter
            set{
                owner = value + "is an owner";
            }
        }
        public string DogName { get; set}

    }
}