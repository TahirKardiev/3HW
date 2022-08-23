
int [] numbers = new int[4];
int i, count;
i = 0;
count = 0;
for (i = 0; i < numbers.Length;)
{        
    numbers [i] = new Random().Next(99, 1000);        
    Console.Write($"{numbers [i]} ");
        if ((numbers [i]% 2)<1)
        {
            count+=1;
        }  
 
    i++;
 }
 Console.Write ($"->{count}");  