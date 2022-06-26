//Задача 1: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее

 int a, b;
 
Console.WriteLine("Введите два числа : ");
 a = Convert.ToInt32(Console.ReadLine());
 b = Convert.ToInt32(Console.ReadLine());
 
 if (a > b)
     {
 Console.WriteLine("{0} наибольшее число", a);
     }
 else
         {
 Console.WriteLine("{0} наибольшее число ", b);
        }
 Console.ReadLine()


//Задача 2: Напишите программу, 
//которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("a b c: ");
var s = Console.ReadLine().Split(" ");
a = Convert.ToDouble(s[0]);
b = Convert.ToDouble(s[1]);
c = Convert.ToDouble(s[2]);
max = Math.Max(a, Math.Max(b, c));
Console.WriteLine(max)


//Задача 3: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Введите число : ");
                int a = Convert.ToInt32(Console.Read());
                if (a % 2 == 0) Console.WriteLine("Четное");
                else Console.WriteLine("Нечетное");
                Console.ReadKey()



//Задача 4: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N

Console.Write("Write number 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write number 2: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey()
