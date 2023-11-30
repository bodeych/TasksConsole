// See https://aka.ms/new-console-template for more information

/*Спробуй також переписати 4 задачу на класИ.
 * Зроби міні гру, яка продовжується поки юзер не 
 * вимкне консоль, чи введе 'q'. 
 */

var userChoice = "";

while (true)
{
   
    var possibleChoices = new[] { "камінь", "ножиці", "бумага" };
    
    var winningConditions = new Dictionary<string, string>
{
    {"камінь", "ножиці"},
    {"ножиці", "бумага"},
    {"бумага", "камінь"}
};
    do
    {
        Console.Write("Виберіть 'камінь', 'ножиці', чи 'бумага': ");

        userChoice = Console.ReadLine();

          
        if (userChoice == "q")
        {
            Console.WriteLine("Exit");
            Console.ReadLine();
            return;
        }
        else if (!possibleChoices.Contains(userChoice))
        {
            Console.WriteLine("Invalid input");
            
        }
} while (!possibleChoices.Contains(userChoice));
       
var rnd = new Random();
    var botNumber = rnd.Next(possibleChoices.Length);

    var botChoice = possibleChoices[botNumber];

    Console.WriteLine("Бот вибрав " + botChoice);

    if (winningConditions[userChoice] == botChoice)
    {
        Console.WriteLine("Ви виграли!");
    }
    else
    {
        Console.WriteLine("Бот виграв");
    }

}

