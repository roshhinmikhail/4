using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
 double x, y, z, a1, a2, d;
Console.WriteLine("X=");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y=");
y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z=");
z = Convert.ToInt32(Console.ReadLine());
if (y == 0)
{
    if (z > 0 && x > 0) { Console.WriteLine("Невозможно вычислить корень из отрицательного числа"); }
    else
    {
        Console.WriteLine("a1 =" + Convert.ToString(Math.Sqrt(z / x)));
        Console.WriteLine("a2 =" + Convert.ToString(-(Math.Sqrt(z / x))));
    }
}
else
{
    if (x == 0)
    { Console.WriteLine("a1=" + -(z / y)); }
    else
    {
        d = (y * y) - (4 * x * z);
        if (d > 0)
        {
            a1 = (-y + Math.Sqrt(d)) / (2 * x);
            a2 = (-y - Math.Sqrt(d)) / (2 * x);
            Console.WriteLine("a1=" + a1);
            Console.WriteLine("a2=" + a2);
        }
        else if (d == 0) { Console.WriteLine("a1=" + (-y) / (2 * x) + "\na2=" + (-y) / (2 * x)); }
        else
        {
            a1 = -y / 2 * x;
            Console.WriteLine("a1=" + a1 + "+" + (Math.Sqrt(-d)) / (2 * x) + "i");
            Console.WriteLine("a2=" + a1 + "-" + (Math.Sqrt(-d)) / (2 * x) + "i");
        }
    }
}
Console.ReadLine();
        }
    }
}
