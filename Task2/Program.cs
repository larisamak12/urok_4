// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

int Func (int number)
{
    int sum = 0;
    while (number>0)
    {
        sum = sum + number%10;
        number=number/10;
    }
    return sum;
}
Console.WriteLine("Сумма всех цифр рана" + Func (number));
