// See https://aka.ms/new-console-template for more information


/* 1. Приняти список цифр одним рядком у вигляді 1,4,3,6,5, вивести їх сумму,
 * найбільше, найменше, середнє, яке найчастіше зустрічається, якщо найчастішого 
 * нема виведи мінус '-'
 */

var inputString = "";
double average = 0.0;
int count = 1;

Console.Write("Type: ");
inputString = Console.ReadLine();

// last comma?
int[] numsArray = inputString.Split(',').Select(int.Parse).ToArray();

//1
Console.WriteLine(numsArray.Sum());

//2
Console.WriteLine("Max: " + numsArray.Max());

//3
Console.WriteLine("Min: " + numsArray.Min());

//4
average = ((double)numsArray.Sum() / (double)numsArray.Length);
Console.WriteLine("Average value: " + average);

//5 easy way?

    for(int i = 0; i < numsArray.Length - 1; i++)
    {
        if (numsArray[i] == numsArray[i + 1])
            count = count + 1;
    }

if (count == 1)
{
    Console.WriteLine("-");
}
else
{
    Console.WriteLine("Repeating: " + count);
}



Console.ReadLine();


