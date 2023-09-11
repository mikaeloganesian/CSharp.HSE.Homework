using System;

class Program
{
    static void Main()
    {
        //Семинар 1, Self, Task01-04
        /*
        string? lastname = Console.ReadLine();
        string? firstname = Console.ReadLine();
        string? fathername = Console.ReadLine();

        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(string.Format("Здравствуйте, {0} {1} {2}!", lastname, firstname, fathername));
        Console.ReadKey();
        */


        //Семинар 1, Self, Task05
        /*
        double U = double.Parse(Console.ReadLine());
        double R = double.Parse(Console.ReadLine());
        Console.WriteLine(string.Format("I = {0}", Convert.ToDouble(U/R)));
        Console.WriteLine(string.Format("P = {0}", Convert.ToDouble((U * U) / R)));
        Console.ReadKey();
        */


        //Семинар 1, Self, Task06
        /*
        try
        {
            double firstKat = double.Parse(Console.ReadLine());
            double secondKat = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(firstKat * firstKat + secondKat * secondKat));
            Console.ReadKey();
        }
        catch
        {
            Console.WriteLine("Incorrect value!");
            Console.ReadKey();
        }
        */


        //Семинар 2, Self, Self01
        /*
        int a = 10;
        double b = 11.5;
        char c = 'j';
        Console.WriteLine(a + " " + a.GetType());
        Console.WriteLine(b + " " + b.GetType());
        Console.WriteLine(c + " " + c.GetType());
        */


        //Семинар 2, Self, Self02
        /*
        double firstNum = double.Parse(Console.ReadLine().Replace(",", "."));
        double secondNum = double.Parse(Console.ReadLine().Replace(",", "."));
        Console.WriteLine(string.Format("Сумма целых частей чисел {0} и {1} равна {2}", firstNum, secondNum, (int)firstNum + (int)secondNum));
        Console.WriteLine(string.Format("Сумма дробных частей чисел {0} и {1} равна {2:N2}", firstNum, secondNum, firstNum - (int)firstNum + secondNum - (int)secondNum));
        */

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        int maxVal, minVal, avVal;
        maxVal = x > y ? (x > z ? x : z) : (y > z ? y : z);
        minVal = x < y ? (x < z ? x : z) : (y < z ? y : z);
        avVal = x + y + z - maxVal - minVal;
        Console.WriteLine(minVal + " " + avVal + " " + maxVal);

        Console.ReadKey();
    }

}