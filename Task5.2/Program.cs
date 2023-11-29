// See https://aka.ms/new-console-template for more information

/*Спробуй переписати 5 задачу, на клас.
 * У тебе має вийти якийсь класс PasswordGenerator, 
 * який приймає на вхід оці всі параметри генерації (чи юзати цифри, спец символи, 
 * регістри) і має один публічний метод GenerateNext, 
 * який вертає тобі унікальний генерований пароль
 */

using Task5._2;

var choiseBool1 = false;
var choiseBool2 = false;
var choiseBool3 = false;
var choiseBool4 = false;

Console.Write("Довжина паролю: ");
var lengthPassword = Int32.Parse(Console.ReadLine());

Console.Write("Використовувати числа?('+' або '-') ");
var userChoise = Console.ReadLine();
if (userChoise == "+")
{
    choiseBool1 = true;
}


Console.Write("Використовувати спецсимволи?('+' або '-') ");
userChoise = Console.ReadLine();
if (userChoise == "+")
{
    choiseBool2 = true;
}


Console.Write("Використовувати букви верхнього регістру?('+' або '-') ");
userChoise = Console.ReadLine();
if (userChoise == "+")
{
    choiseBool3 = true;
}


Console.Write("Використовувати букви нижнього регістру?('+' або '-') ");
userChoise = Console.ReadLine();
if (userChoise == "+")
{
    choiseBool4 = true;
}


var password1 = PasswordGenerator.GenerateNext(lengthPassword, choiseBool1, choiseBool2, choiseBool3, choiseBool4);

Console.WriteLine($"Your password: {password1}");
Console.ReadLine();