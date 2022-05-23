Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
int SumNum (int num)
{
    for (int n = num; n > 0; sum += n % 10, n /= 10 )
    {
        sum = sum * 1;
    }
    return sum;
}
int result = SumNum(num);
Console.WriteLine($"Сумма цифр числа = {result}");
