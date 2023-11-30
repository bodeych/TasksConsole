// See https://aka.ms/new-console-template for more information
using Task4._3;

// Перенеси 4.2 на класи, з урахуванням балів, підказую, що класів бажано має бути 2


var userChoice = "";
var possibleChoices = new[] { "камінь", "ножиці", "бумага" };
var bot = new Bot();
var game = new Game();
var botChoice = bot.Choice(possibleChoices);

while (true)
{
    do
    {
        Console.Write("Виберіть 'камінь', 'ножиці', чи 'бумага': ");
        userChoice = Console.ReadLine();
        if (userChoice == "q")
        {
            Console.WriteLine("Exit");
            Console.ReadLine();
            return -1;
        } else {
            game.Error(userChoice);
        }

    } while (!possibleChoices.Contains(userChoice));

    Console.WriteLine("Бот вибрав " + botChoice); 
    
    if (game.CheckWin(userChoice, botChoice))
    {
        game.WinUser();
        Console.WriteLine("Ви виграли!");
    }
    else
    {
        bot.Win();
        Console.WriteLine("Бот виграв");
    }
    Console.WriteLine($"Result: Bot - {bot.ResultBot()}, User - {game.ResultUser()}");
}



Console.ReadLine();



