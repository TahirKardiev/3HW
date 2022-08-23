// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Генерирует массив с размерностью size
int[] GenerateArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(99, 1000);
    }
    return numbers;
}

// Подсчитывает количество четных элементов
int CountEvenElements(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if ((numbers[i] % 2) < 1)
        {
            count += 1;
        }
    }
    return count;
}

// выводит на экран
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
}

// Сама программа
int[] numbers = GenerateArray(4);
int count = CountEvenElements(numbers);
PrintArray(numbers);
Console.WriteLine($"->{count}");