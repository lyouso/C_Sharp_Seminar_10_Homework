/* Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз: 
1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... Дано число m. Выведите первые m членов этой последовательности.
m = 5 >> 1, 2, 2, 3, 3 */

int count = 7;
Recursion(count);


void Recursion(int count, int number = 0, int start = 1)
{

    if (count == 0)
    {
        return;
    }

    number++;

    if (start < number)
    {
        start++;
        number = 1;
    }
    Console.Write(start + " ");
    Recursion(--count, number, start);

}



