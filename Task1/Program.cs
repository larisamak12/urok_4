// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число, которое будем возводить в степень: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine(number + "в степени" + number2 + "=" + Func(number, number2)); 
// вызвали функцию

int Func(int a, int x)
// функция возводит в степень
{
    int result =1;
    for (int i=0; i<x; i++)
    {
        result *=a;
    }
    return result;
}