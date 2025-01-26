using System;
using System.Diagnostics;
using System.Globalization;
class Program
{
public static void Main()
{


int number;
Console.Write("Enter a Number for check its even/odd: ");
 number=Convert.ToInt32(Console.ReadLine());

 if(number %2==0)
 {
     Console.WriteLine($"{number}  is even");
 }

else{
     Console.WriteLine($"{number}  is odd");






}
}
}