using System;

class Program
{
    static void Main() 
    {
        // Строка, содержащая латинские буквы в обоих регистрах.
        string str = "JsddKDjk1";

        // Преобразование всех заглавных букв в строчные 
        string result = str.ToLower();

        // Вывод результата
        Console.WriteLine(result);

    }
}