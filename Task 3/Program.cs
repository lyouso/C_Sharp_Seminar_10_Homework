/* 3. Дано натуральное число n > 1. Вывести все простые множители данного числа.
10 >> 5, 2.
12 >> 2, 2, 3. */

int number = 12;
Console.WriteLine("Решение через цикл:");
Cycle(number);
Console.WriteLine("Решение через рекурсию:");
Recursion(number);

void Cycle(int num, int count = 2)
{
    while (count * count <= num)
    {
        while (num % count == 0)
        {
            Console.Write(count + " ");
            num /= count;
        }
        count++;
    }
    Console.Write(num);
    Console.WriteLine();

}

void Recursion(int num, int count = 2)
{
    if (count * count > num)
    {
        Console.Write(num);
        return;
    }
    else
    {
        while (num % count == 0)
        {
            Console.Write(count + " ");
            num/=count;
        }
        Recursion(num, ++count);
    }
}