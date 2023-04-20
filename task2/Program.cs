// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.


int NumSum(int arg)
{
   int result = arg % 10;
   if (arg/10 > 0)
    {
        return result + NumSum(arg/10);
    }
    return result;
}
Console.WriteLine(NumSum(256));