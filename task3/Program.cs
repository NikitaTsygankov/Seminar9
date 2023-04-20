//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую
 //степень B с помощью рекурсии.


 int NumPow(int a, int b)
{
   if (b>0)
    {
        return a * NumPow(a, b-1);
    }
    return 1;

}
Console.WriteLine(NumPow(4,16));