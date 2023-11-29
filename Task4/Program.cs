// See https://aka.ms/new-console-template for more information

/*Зробити шось подібне на камінь-ножиці-бумага. 
 * Дати можливість вводити один з трьох можливих варіантів, 
 * а (мікро) бот має давати свою відповідь, на основі цього 
 * обирається переможець
 */



var botChoice = "";
var userChoice = "";

Console.Write("Виберіть 'камінь', 'ножиці', чи 'бумага': ");
userChoice = Console.ReadLine();


Random rnd = new Random();
int botNumber = rnd.Next(3);



switch (botNumber)
{
    case 0:
        botChoice = "камінь";
        Console.WriteLine("Бот вибрав " + botChoice);
        break;
    case 1:
        botChoice = "ножиці";
        Console.WriteLine("Бот вибрав " + botChoice);
        break;
    case 2:
        botChoice = "бумага";
        Console.WriteLine("Бот вибрав " + botChoice);
        break;
    default:
        break;

}

switch (userChoice)
{
    case "камінь":
        if(botChoice == "ножиці")
        {
            Console.WriteLine("Ви виграли!");
        }
        else
        {
            Console.WriteLine("Бот виграв");
        }
        break;
    case "ножиці":
        if (botChoice == "бумага")
        {
            Console.WriteLine("Ви виграли!");
        }
        else
        {
            Console.WriteLine("Бот виграв");
        }
        break;
    case "бумага":
        if (botChoice == "камінь")
        {
            Console.WriteLine("Ви виграли!");
        }
        else
        {
            Console.WriteLine("Бот виграв");
        }
        break;
}

Console.ReadLine();




