//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*int CutNumber(int number)
{
    int ed = number % 10; 
    int sot = number / 100;

    number = sot * 10 + ed;
    return number;
}

int num = new Random().Next(100, 1000);
int result = CutNumber(num);
Console.WriteLine($"New version of a number {num} is {result}");

//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
*/

/*int MaxNum(int randNum)
{
    int ed = randNum % 10; 
    int doz = randNum / 10;
    int max = 0;
    if( ed >  doz)
    {
        max = ed;
    }
    else
    {
        max = doz;
    }
    return max;
}
int number = new Random().Next(10, 100);
int result = MaxNum(number);
Console.WriteLine($"Max of a number {number} is {result}");
*/

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*
bool Multiplicity(int FirstNum, int secondNum)
{
    if(secondNum % FirstNum == 0)
    {
        return true;
    }
    else{
        return false;
    }
}
Console.WriteLine("Input first number ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number ");
int second = Convert.ToInt32(Console.ReadLine());

bool res = Multiplicity(first, second);
Console.WriteLine(res);
*/
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*bool Square(int first, int second)
{
    if(first == second * second || second == first * first)
    {
        return true;
    }
    else
    {
        return false;
    }
}
*/