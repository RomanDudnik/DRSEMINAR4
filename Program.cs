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

//Вариант 1 (перевод отрицательных чисел в положительные перед запросом метода)

/*
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
*/

//Вариант 2 (работа с отрицательными числами в методе)

/*
int SumDigit(int number)
{
    int sum = 0;
    if (number > 0)
    {
        while (number > 0)
        {
            sum = sum + number % 10;
            number = number/10;
        }
        return sum;
    }
    else
    {
        while (number < 0)
        {
            sum = sum + number % 10;
            number = number/10;
        }
        return sum*-1;
    }
}

Console.WriteLine("Input your number: ");
int digits = Convert.ToInt32(Console.ReadLine());


int sum = SumDigit(digits);
Console.WriteLine($"The sum of the digits of your number {digits} is a {sum} ");
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//Вариант 1 (с методом создания массива только для 8 элементов)

int [] EightSizeArray (int min, int max)
{
    int [] array = new int [8];
    for (int index = 0; index < 8; index++)
        array[index] = new Random().Next(min, max + 1);
    return array;
}

void OutputArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.WriteLine("Enter the minimum segment of your array : ");
int minSegment = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Enter the maximum segment of your array : ");
int maxSegment = Convert.ToInt32 (Console.ReadLine());

int [] array1 = EightSizeArray(minSegment, maxSegment);
OutputArray(array1);

//Вариант №2 (с методом свободного выбора длинны и отрезка элементов заполнения массива)

/*
int [] NewMethArray (int size, int min, int max)
{
    int [] array = new int [size];
    for (int index = 0; index < size; index++)
        array[index] = new Random().Next(min, max + 1);
    return array;
}

void OutputArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.WriteLine("Enter your array size: ");
int lenght = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Enter the minimum segment of your array : ");
int minSegment = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Enter the maximum segment of your array : ");
int maxSegment = Convert.ToInt32 (Console.ReadLine());

int [] array1 = NewMethArray(lenght, minSegment, maxSegment);
OutputArray(array1);
*/