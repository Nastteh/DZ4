// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-10, 100);
    }

    return result;
}

const int sizeArray = 8;
int[] array = GetArray(sizeArray);
Console.WriteLine($"[{String.Join(", ", array)}]");

