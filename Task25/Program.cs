Console.Write("Введите целое число А: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите натуральное число В: ");
int numB = int.Parse(Console.ReadLine());
int sum = 1;
for (int i = 0; i < numB; i++)
{
    sum *= numA;
}
Console.WriteLine($"А в степени В = {sum}");
