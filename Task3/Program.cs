using System;

class Program
{
    static void Main(string[]args)
    {
        
        string input = "шалаш";

        // Проверяем, является ли введенная строка палиндромом
        if (IsPalindrome(input))
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }

    // Функция для проверки, является ли строка палиндромом
    static bool IsPalindrome(string str)
    {
       
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}