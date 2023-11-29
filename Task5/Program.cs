// See https://aka.ms/new-console-template for more information

/* Зробити генератор рандомних паролів. 
 * Приймати на вхід довжину паролю, задати ряд питань по типу: 
 * чи використовувати числа, чи використовувати спецсимволи, 
 * чи використовувати букви верхнього і нижнього регістру 
 * і на основі введених даних згенерувати пароль.
 */

var validChars = "";
Random random = new Random();
var numberChars = "0123456789";
var specChars = "!@#$%^&*?_-";
var upperChars = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
var lowerChars = "abcdefghijklmnopqrstuvwxyz";

Console.Write("Довжина паролю: ");
var lengthPassword = Int32.Parse(Console.ReadLine());

Console.Write("Використовувати числа?('+' або '-') ");
var userChoise = Console.ReadLine();
if (userChoise == "+")
{
    validChars += numberChars;
}

Console.Write("Використовувати спецсимволи?('+' або '-') ");
userChoise = Console.ReadLine();
if (userChoise == "+")
{
    validChars += specChars;
}

Console.Write("Використовувати букви верхнього регістру?('+' або '-') ");
userChoise = Console.ReadLine();
if (userChoise == "+")
{
    validChars += upperChars;
}

Console.Write("Використовувати букви нижнього регістру?('+' або '-') ");
userChoise = Console.ReadLine();
if (userChoise == "+")
{
    validChars += lowerChars;
}

char[] chars = new char[lengthPassword];

for (int i = 0; i < lengthPassword; i++)
{
    chars[i] = validChars[random.Next(0, validChars.Length)];
}

var newStr = new string(chars);

Console.WriteLine("Your password: " + newStr);

Console.ReadLine();



