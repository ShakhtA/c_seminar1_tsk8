// Ввод числа

Console.WriteLine("Введите положительное целое число");

string Str = Console.ReadLine() ?? "";
int Num = int.Parse(Str);

// Печать четных чисел, не превышающих Num

int i = 2;
if (Num < 2)
    Console.Write($"{Num} -> ");
else
    {
        Console.Write($"{Num} -> {i}");
        while (i < Num)
            {
                Console.Write($", {i+=2}");
                i +=2;
            }
    }
//Console.Write($"{Num} -> {i}");
//while (i < Num + 1)
//  {
//        Console.Write($", {i+=2}");
//          i +=2;
//  }
