// See https://aka.ms/new-console-template for more information


/* Приняти речення на вхід, дати вибір пошуку по слову чи
 * по букві і вивести кількість вибраних елементів у речені. 
 * Спробувати провернути те саме прийнявши на вхід тхт файл
 */



//????
using Microsoft.VisualBasic;



 string contents = File.ReadAllText(@"/Users/bodeych/Projects/Console tasks/Task3.1/text.txt");



var inputSelect = "";
var inputSearch = "";

Console.Write("Choose 'word' or 'char': ");
inputSelect = Console.ReadLine();

Console.Write("Search: ");
inputSearch = Console.ReadLine();

if (inputSelect == "char")
{
    char character = char.Parse(inputSearch);
    Console.WriteLine(contents.Count(t => t == character));
}
else
{

    string[] source = contents.Split('.', '?', '!', ' ', ';', ':', ',').ToArray();

    var matchQuery = from word in source
                     where word.Equals(inputSearch)
                     select word;

    int wordCount = matchQuery.Count();

    Console.WriteLine("Result: " + wordCount);
}



Console.ReadLine();

