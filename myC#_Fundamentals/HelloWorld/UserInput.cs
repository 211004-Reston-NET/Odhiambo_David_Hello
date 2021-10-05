namespace HouseFunction
{
    public class UserInput
    {
        private string terminal;
       

        public House()
        {
        
            terminal = "junk";
            

    
        }

        public string TerminalInput { 
            get{
                return terminal;
                } 
                set{
                    terminal = value;
                    } 
            }
    }
}