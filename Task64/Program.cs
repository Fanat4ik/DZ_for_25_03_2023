// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//запрос int из консоли
int GetIntFromConsole(string name)
{
    System.Console.Write($"Введите {name}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNaturalNumbersFromNto1(int numbN)
{
    System.Console.Write(numbN + " ");
    if (numbN >= 2)
        ShowNaturalNumbersFromNto1(numbN-1);
}

int numberN = GetIntFromConsole("N");
ShowNaturalNumbersFromNto1(numberN);