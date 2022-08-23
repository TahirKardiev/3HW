double [] numbers = new double[4];
int i; double max, min;
i = 0;
max = 0;
min = new Random().Next(0, 99);
for (i = 0; i < numbers.Length;)
{        
    numbers [i] = new Random().Next(0, 99);
    numbers[i]=numbers[i]/new Random().Next(0, 99);        
    Console.Write($"{numbers [i]} ");
        if (numbers [i]>max)
        {
            max=numbers [i];
        }
        if (numbers [i]<min)
        {
            min=numbers [i];
        } 
 
    i++;
 }
 Console.Write($"->{max-min}");