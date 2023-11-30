namespace Task4._3;

public class Game
{

    readonly Dictionary<string, string> winningConditions = new Dictionary<string, string>
    {
        { "камінь", "ножиці" },
        { "ножиці", "бумага" },
        { "бумага", "камінь" }
    };

   
    protected int countUser = 0;

    

    internal bool CheckWin(string user, string bot)
    {
        if (winningConditions[user] == bot)
        {
            
            return true;
         
            
        }
       
        return false;
        

    }

    internal void WinUser()
    {
        countUser++;
    }
    
    internal int ResultUser()
    {
        return countUser;
    } 
    
    
    /*internal int Quit(string value)
    {
        if (value == "q")
        {
            Console.WriteLine("Exit");
            Console.ReadLine();
        }

        return -1;
    }*/

    internal void Error(string choice)
    {
        if (!winningConditions.Equals(choice))
        {
            Console.WriteLine("Invalid input");
        }
    }

    
}

        
    

    
        
