using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Diskrimant.exe XD");
        Console.WriteLine("Калькулятор Дискримінанту");
        Console.WriteLine("Совєтніков О.І ІПЗ 21");
        Console.WriteLine("                       ");

        int a, b, c, diskriminant, x1, x2, sqrtD;
        string str, str2;

        //введення 1-го числа
        do
        {
            Console.WriteLine("Введіть перше число (а)");
            str = Console.ReadLine();
            if (!int.TryParse(str, out a))
                Console.WriteLine("Будь ласка, введіть Число!");
        } while (!int.TryParse(str, out a));

        //введення 2-го числа
        do
        {
            Console.WriteLine("Введіть друге число (b)");
            str = Console.ReadLine();
            if (!int.TryParse(str, out b))
                Console.WriteLine("Будь ласка, введіть Число!");
        } while (!int.TryParse(str, out b));

        //введення 3-го числа
        do
        {
            Console.WriteLine("Введіть третє число (c)");
            str = Console.ReadLine();
            if (!int.TryParse(str, out c))
                Console.WriteLine("Будь ласка, введіть Число!");
        } while (!int.TryParse(str, out c));

        //Дискримінант
        diskriminant = (b * b) - (4 * a * c);
        //Перевірка дискримінанту 
        Console.WriteLine("Дискримінант = " + diskriminant);
        if (diskriminant < 0)
        {
            Console.WriteLine("Дискримінат менше або дорівнює нулю, що означає відсутність коренів");
            Environment.Exit(0);
        }
        else
        {
            //Пошук коренів та їх виведення
            sqrtD = (int)Math.Sqrt(diskriminant);
            Console.WriteLine("Дискримінант sqrt = " + sqrtD);
            x1= (-b + sqrtD)/2*a;
            Console.WriteLine("X1 = " + x1);
            x2 = (-b - sqrtD)/2*a;
            Console.WriteLine("X2 = "+ x2);
        }
        
    }
}
