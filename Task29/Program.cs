Console.Write("Введите размер массива: ");
int lenght = int.Parse(Console.ReadLine());
int[] array = new int [lenght];
Console.Write("Введите диапазон массива: от нуля до  ");
int diapazon = int.Parse(Console.ReadLine());
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(0, diapazon);
        index++;   
    }
}
void PrintArray(int[] col)
{
    Console.Write($"Массив [");
    int size = col.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{col[i]}" + $",");
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);

