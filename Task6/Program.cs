// See https://aka.ms/new-console-template for more information

/* Спробуй зробити свій клас список, типу динамічного списку MyList<T>, 
 * який має публічний інтерфейс з методами: Add, Contains, IndexOf, Remove, 
 * RemoveAt і пропою Count чи Length, поведінку спробуй підглядіти у МК реалізації
*/

using Task6;

MyList<int> newL = new MyList<int>();

newL.Add(1);
newL.Add(2);
newL.Add(3);
Console.WriteLine(newL.Contains(1));

newL.Remove(1);

Console.WriteLine(newL.Contains(1));
Console.ReadLine();
