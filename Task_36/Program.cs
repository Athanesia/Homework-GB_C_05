// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Random rand = new Random();
int[] array = new int[4]; 
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(-9,99);
}

for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}

void SumEvenIndex(int[] array)
{
    int sumEven = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumEven = array[i] + sumEven;
    }
    Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях: {sumEven}");
}

Console.WriteLine();
SumEvenIndex(array);


