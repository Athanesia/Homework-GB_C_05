// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Random rand = new Random(); 
int[] array = new int[4]; 
for (int i = 0; i < array.Length; i++) 
{ 
array[i] = rand.Next(100,999); 
} 
 
for(int i = 0; i < array.Length; i++) 
{ 
Console.Write(array[i] + " "); 
} 
 
int EvenCountInt(int[] array) 
{ 
    int count = 0; 
    foreach (int i in array) 
    { 
        if (i % 2 == 0) count++; 
    } 
    return count; 
} 
 
Console.WriteLine(); 
Console.WriteLine($"Количество чётных чисел = {EvenCountInt(array)}");