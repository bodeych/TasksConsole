// See https://aka.ms/new-console-template for more information

/* Приняти список цифр одним рядком у вигляді 1,4,3,6,5, 
 * дати вибір в яку сторону сортувати і вивести список 
 * у вибраному порядку у вигляді 1,3,4,5,6
 */

var inputString = "";

Console.Write("Type: ");
inputString = Console.ReadLine();

int[] numsArray = inputString.Split(',').Select(int.Parse).ToArray();



Console.Write("Choose '<' or '>': ");
inputString = Console.ReadLine();



switch(inputString)
{
    case "<":
        Array.Sort(numsArray);
        foreach(int i in numsArray)
        {
            Console.Write(i + ",");
        }
        break;
    case ">":
        Array.Sort(numsArray);
        Array.Reverse(numsArray);
        foreach (int i in numsArray)
        {
            Console.Write(i + ",");
        }
        break;
    default:
        Console.WriteLine("Error");
        break;

}

Console.ReadLine();



