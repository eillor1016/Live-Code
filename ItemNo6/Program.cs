// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.Write("Please Enter First Number");
string first = Console.ReadLine();
Console.Write("Please Enter Divisible By:");
string second = Console.ReadLine();

double res = Compute(Convert.ToInt32(first), Convert.ToInt32(second));
if (Convert.ToInt32(second)==0 && res % 0 ==0)
{
    Console.Error.WriteLine("Divisible by 0");
}
else
{
    Console.Write(Convert.ToInt32(first) % Convert.ToInt32(second));
}


double Compute(int num1,int num2)
{
    double result = Convert.ToInt32(Convert.ToInt32(num1) / Convert.ToInt32(num2));
    return result;
}
