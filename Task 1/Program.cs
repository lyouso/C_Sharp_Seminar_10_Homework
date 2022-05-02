/* 1. Дано число n. Получите число, записанное в обратном порядке.
345 >> 543
81 >> 18 */

Console.WriteLine("Enter your number:");
int number = Convert.ToInt32(Console.ReadLine());
string nmbr = number.ToString();
int[] numberArray = new int[nmbr.Length];
Console.WriteLine("Решение через массив:");
NumberToArray();
Reverse();
Console.WriteLine();
Console.WriteLine("Решение через рекурсию:");
Recursion(number);

void NumberToArray()
{
    
    for (int i = 0; i < numberArray.Length; i++)
        {
            numberArray[i] = Int32.Parse(nmbr[i].ToString());
            Console.Write(numberArray[i] + " ");
        }
    Console.WriteLine();

}
void Reverse()
{
    int middle = numberArray.Length / 2;
    int lastIndex = numberArray.Length - 1;
    
    for (int i = 0; i < middle; i++)
    {
        int change = numberArray[i];
        numberArray[i] = numberArray[lastIndex - i];
        numberArray[lastIndex - i] = change;
    }
    for (int i = 0; i < numberArray.Length; i++)
    {
        Console.Write(numberArray[i] + " ");
    }
}
void Recursion(int num, int result = 0)
{
    if (num == 0)
    {
        Console.Write(result);
        return;
    }
    else
    {
        result = result*10 + num%10;
        Recursion(num/10, result);
    }
}