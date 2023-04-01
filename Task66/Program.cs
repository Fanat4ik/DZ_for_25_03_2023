// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//запрос int из консоли
int GetIntFromConsole(string name)
{
    System.Console.Write($"Введите {name}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void SumOfNumbersAmongst(int numbM, int numbN, int sumMN)
{
    if(numbM > numbN)
    {
        System.Console.WriteLine("М должно быть меньше N!");
    }
    else
    {
        sumMN += numbN;  
        if (numbM < numbN)
        {
            SumOfNumbersAmongst(numbM, numbN-1, sumMN);
        }
        else
        System.Console.WriteLine("Сумма натуральных элементов от М до N = " + sumMN);
    }
}

int numberM = GetIntFromConsole("M");
int numberN = GetIntFromConsole("N");
int sumMN = 0;
SumOfNumbersAmongst(numberM , numberN, sumMN);
