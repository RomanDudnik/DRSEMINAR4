//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*
int NatDegree (int A, int B)
{
    int power = A;
    for (int current = 1; current < B; current++)
    {
        power *= A;
    }
    return power;
}

Console.WriteLine("Input your first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB <= 0)
Console.WriteLine("You entered not a natural number of degree!Input a POSITIVE second number");
else
{
    int degree = NatDegree(numberA, numberB);
    Console.WriteLine($"The number {numberA} to raise by power {numberB} will be {degree} ");
}
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int SumDigit(int number)
{
    int sum = 0;
    
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number/10;

    }
    return sum;
}

Console.WriteLine("Input your number: ");
int digits = Convert.ToInt32(Console.ReadLine());

if (digits > 0)
{
    int sum = SumDigit(digits);
    Console.WriteLine($"The sum of the digits of your number {digits} is a {sum} ");
}
else
{   
    int digitsNegative = digits*-1;
    int sum = SumDigit(digitsNegative);
    Console.WriteLine($"The sum of the digits of your number {digits} is a {sum} ");
}



//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]