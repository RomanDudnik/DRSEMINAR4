//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

// Вариант 1

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

//Вариант 2 (работает с отрицательными степенями)

/*
double NatDegree (double A, double B)
{
    if (B >= 0)
    {
        double power = A;
        for (int current = 1; current < B; current++)
        {
            power *= A;
        }
        return power;
    }
    else
    {
        double power = A;
        for (int current = 1; current < B*-1; current++)
        {
            power *= A;
        }
        return 1/power;
    }
}

Console.WriteLine("Input your first number: ");
double numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your second number: ");
double numberB = Convert.ToInt32(Console.ReadLine());

double degree = NatDegree(numberA, numberB);

Console.WriteLine($"The number {numberA} to raise by power {numberB} will be {degree} ");
*/

//Вариант 3 (работает с целыми числами и отрицательными степенями)

/*
int NatDegree (int A, int B)
{
    if (B >= 0)
    {
        int power = A;
        for (int current = 1; current < B; current++)
        {
            power *= A;
        }
        return power;
    }
    else
    {
        int power = A;
        for (int current = 1; current < B*-1; current++)
        {
            power *= A;
        }
        return power;
    }
}

Console.WriteLine("Input your first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int degree = NatDegree(numberA, numberB);

if (numberB >= 0)
    Console.WriteLine($"The number {numberA} to raise by power {numberB} will be {degree} ");
else
    Console.WriteLine($"The number {numberA} to raise by power {numberB} will be 1/{degree} ");
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

/*
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
*/

//Вариант 2 (программа сама определяет отрезки(рандом) в массиве из восьми элементов)

/*
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

int numberA = new Random().Next();
int numberB = new Random().Next();

if (numberA > numberB)
{
    int [] array1 = EightSizeArray(numberB, numberA);
    OutputArray(array1);
}
else
{
    int [] array1 = EightSizeArray(numberA, numberB);
    OutputArray(array1);    
}
*/

//Вариант 3 (программа сама определяет отрезки(рандом) в массиве 
//из восьми элементов и показывает заданный ей макс и мин отрезка)

/*
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

int numberA = new Random().Next();
int numberB = new Random().Next();

if (numberA > numberB)
{
    Console.WriteLine($"The random minimum value of the segment of the array will be {numberB} ");
    Console.WriteLine($"The random maximum value of the segment of the array will be {numberA} ");
    int minSegment = numberB;
    int maxSegment = numberA;
    int [] array1 = EightSizeArray(minSegment, maxSegment);
    OutputArray(array1);
}
else
{
    Console.WriteLine($"The random minimum value of the segment of the array will be {numberA} ");
    Console.WriteLine($"The random maximum value of the segment of the array will be {numberB} ");
    int minSegment = numberA;
    int maxSegment = numberB;
    int [] array1 = EightSizeArray(minSegment, maxSegment);
    OutputArray(array1);
}
*/

//Вариант №4 (с методом свободного выбора длинны и отрезка элементов заполнения массива)

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