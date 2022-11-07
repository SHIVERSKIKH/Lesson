//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*int FindSum(int number)
{
    int sum = 0;

    for(int current = 1; current <= number; current++)
        sum += current;
    return sum;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers between 1 and {a} is {FindSum(a)}");
*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*int Find(int number)
{
    int digit = 0;
    while(number != 0)
    {
        number = number / 10;
        digit++;
    }
    return digit;
}
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {Find(a)}");
*/
//Написать программу, которая определит произведение чисел от 1 до N
int Work(int number)
{
    int prod = 1;
    for(int current = 1; current <= number; current++)
        prod = prod * current;
    return prod;
}
Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Произведение чисел равно  {Work(N)}");


