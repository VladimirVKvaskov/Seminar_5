/*

//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Random(numbers);
PrintArray(numbers);
int count = 0;
	
for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;
	
Console.WriteLine(count);
	
void Random(int[] numbers)
	{
        for(int i = 0; i < numbers.Length; i++)
	    {
	        numbers[i] = new Random().Next(100,1000);
	    }
	}
void PrintArray(int[] numbers)
	{
	    Console.Write("[ ");
	    for(int i = 0; i < numbers.Length; i++)
	    {
	        Console.Write(numbers[i] + " ");
	    }
	    Console.Write("]");
	    Console.WriteLine();
	}



//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
	
Console.Clear();

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Random(numbers);
//Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;
	
for (int z = 0; z < numbers.Length; z+=2)
sum = sum + numbers[z];
	
Console.WriteLine(sum);
	
void Random(int[] numbers)
	{
	    for(int i = 0; i < numbers.Length; i++)
	        {
	            numbers[i] = new Random().Next(1,10);
	        }
	}
void PrintArray(int[] numbers)
	{
	    Console.Write("[ ");
	    for(int i = 0; i < numbers.Length; i++)
	        {
	            Console.Write(numbers[i] + " ");
	        }
	    Console.Write("]");
	    Console.WriteLine();
	}



//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
Random(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;
	
for (int z = 0; z < numbers.Length; z++)
	{
	    if (numbers[z] > max)
	        {
	            max = numbers[z];
	        }
	    if (numbers[z] < min)
	        {
	            min = numbers[z];
	        }
	}
	
Console.WriteLine(max - min);
	
	void Random(double[] numbers)
	{
	    for(int i = 0; i < numbers.Length; i++)
	        {
	            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
	        }
	}
	void PrintArray(double[] numbers)
	{
	    Console.Write("[ ");
	    for(int i = 0; i < numbers.Length; i++)
	        {
	            Console.Write(numbers[i] + " ");
	        }
	    Console.Write("]");
	    Console.WriteLine();
	}

*/

