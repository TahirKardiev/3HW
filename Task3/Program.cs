// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Генерирует массив с размерностью size
double[] GenerateArray(int size)
{
    double[] numbers = new double[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 99);
        numbers[i] = numbers[i] / new Random().Next(0, 99);
    }
    return numbers;
}

// выводит на экран
void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]:F2}\t");
    }
}

// Максимальный элемент
double GetMaxElement(double[] numbers)
{
    double max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}

// Минимальный элемент
double GetMinElement(double[] numbers)
{
    double min = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}

double[] numbers = GenerateArray(4);
PrintArray(numbers);
double max = GetMaxElement(numbers);
double min = GetMinElement(numbers);
Console.Write($"->{max - min:F2}");