﻿// See https://aka.ms/new-console-template for more information

/*Спробуй переписати 5 задачу, на клас.
 * У тебе має вийти якийсь класс PasswordGenerator, 
 * який приймає на вхід оці всі параметри генерації (чи юзати цифри, спец символи, 
 * регістри) і має один публічний метод GenerateNext, 
 * який вертає тобі унікальний генерований пароль
 */
 

class PasswordGenerator
{
    private const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
    private const string upperChars = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
    private const string numberChars = "0123456789";
    private const string specChars = "!@#$%^&*?_-";
    
    

    public static string GenerateNext(int length, bool includeLowercase, bool includeUppercase, bool includeDigits, bool includeSpecChar)
    {
        if (length <= 0)
        {
            return "Error";
        }

        if(!includeLowercase && !includeUppercase && !includeDigits && !includeSpecChar)
        {
            return "Error";
        }

        var validChars = "";

        if (includeLowercase)
        {
            validChars += lowerChars;
        }

        if (includeUppercase)
        {
            validChars += upperChars;
        }

        if (includeDigits)
        {
            validChars += numberChars;
        }

        if (includeSpecChar)
        {
            validChars += specChars;
        }

        Random random = new Random();

        char[] chars = new char[length];

        for (int i = 0; i < length; i++)
        {
            chars[i] = validChars[random.Next(0, validChars.Length)];
        }

        return chars.ToString();
    }
}

// ?
var password1 = PasswordGenerator.GenerateNext(8, true, false, true, false);


// tuple?
