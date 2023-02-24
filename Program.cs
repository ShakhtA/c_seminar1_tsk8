// Ввод числа

Console.WriteLine("Введите число");

string Str = Console.ReadLine() ?? "";
int Num = int.Parse(Str);

// Печать четных чисел, не превышающих Num

int i = 2;
Console.Write($"{Num} -> {i}");
while (i < Num-1)
    {
        i +=2;
        Console.Write($", {i}");
        //i +=2;
    }
