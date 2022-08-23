// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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

// выводит на экран
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
}

int SumOddElements(int[] numbers)
{
    int sum = 0; // название count не очень подходит для суммы
    for (int i = 0; i < numbers.Length; i++)
    {
        if ((i % 2) > 0)
        {
            sum += numbers[i];
        }
    }
    return sum;
}

// Сама программа
int[] numbers = GenerateArray(4);
int sum = SumOddElements(numbers);
PrintArray(numbers);
Console.Write($"->{sum}");