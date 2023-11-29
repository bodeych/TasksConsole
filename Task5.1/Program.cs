// See https://aka.ms/new-console-template for more information

var possibleChoices = new[] { "камінь", "ножиці", "бумага" };
var winningConditions = new Dictionary<string, string>
{
    {"камінь", "ножиці"},
    {"ножиці", "бумага"},
    {"бумага", "камінь"}
};

Console.Write("Виберіть 'камінь', 'ножиці', чи 'бумага': ");

var userChoice = Console.ReadLine();

if (!possibleChoices.Contains(userChoice))
{
    Console.WriteLine("Invalid input");
    Console.ReadLine();
    return;
}

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

Console.ReadLine();

