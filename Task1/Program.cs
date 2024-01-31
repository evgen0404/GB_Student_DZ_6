using System;

class Program
{
   static void Main() 
   {
    // Ввод двухмерного массива
    char [,] Array = new char[,]{{'a','b'},{'e','f'}};

    // метод вывода массива в строку
    string result = Create_String_Array(Array);

    // Вывод результата
    Console.WriteLine(result);

   }
   // метод создания строки из массива
   public static string Create_String_Array(char[,]array)
   {
    string result = "";
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
           result += array[i,j]; 
        }
    }
        return result;  
   }
}

