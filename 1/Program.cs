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


        //Семинар 2, Self, Self03
        /*
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        int maxVal, minVal, avVal;
        maxVal = x > y ? (x > z ? x : z) : (y > z ? y : z);
        minVal = x < y ? (x < z ? x : z) : (y < z ? y : z);
        avVal = x + y + z - maxVal - minVal;
        Console.WriteLine(minVal + " " + avVal + " " + maxVal);
        */


        //Семинар 2, Self, Self04, Solution№1
        /*
        char s = Convert.ToChar(Console.ReadLine());
        string output = char.IsDigit(s) == true ? "Это цифра" : char.IsLetter(s) == true ? "Это буква" : "Это ни буква, ни цифра";
        Console.WriteLine(output);
        */


        //Семинар 2, Self, Self04, Solution№2
        /*
        char s = Convert.ToChar(Console.ReadLine());
        char[] alf = {  'А', 'а', 'Б', 'б', 'В', 'в', 'Г', 'г', 'Д', 'д', 'Е', 'е', 'Ё', 'ё', 'Ж', 'ж', 'З', 'з',
                        'И', 'и', 'Й', 'й', 'К', 'к', 'Л', 'л', 'М', 'м', 'Н', 'н', 'О', 'о', 'П', 'п', 'Р', 'р',
                        'С', 'с', 'Т', 'т', 'У', 'у', 'Ф', 'ф', 'Х', 'х', 'Ц', 'ц', 'Ч', 'ч', 'Ш', 'ш', 'Щ', 'щ',
                        'Ъ', 'ъ', 'Ы', 'ы', 'Ь', 'ь', 'Э', 'э', 'Ю', 'ю', 'Я', 'я' };

        string output = char.IsDigit(s) == true ? "Это цифра" : alf.Contains(s) == true ? "Это буква русского алфавита" : "Это ни буква русского алфавита, ни цифра";
        Console.WriteLine(output);
        */


        //Семинар 2, Self, Self05
        /*
        double R = double.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine()), y = int.Parse(Console.ReadLine());
        string output = x * x + y * y <= R ? "Точка внутри круга!" : "Точка вне круга!";
        Console.WriteLine(output);
        */


        //Семинар 2, Self, Self06
        /*
        string str = Console.ReadLine();
        string s = int.Parse(str) >= 0 ? str : Convert.ToString(int.Parse(str) * -1);
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine(s[i]);
        }

        Console.ReadKey();
        */
        ///Примечание: для тестирования раскомментировать конкретную задачу
    }

}