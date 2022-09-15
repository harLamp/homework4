// 26. Возведите число А в натуральную степень B используя цикл
Console.Clear();
Console.WriteLine();

int number = 3;
int exponent = 5;
int count = 1;
int result = number;

while (count < exponent)
{
    result = result * number;
    count++;
}

Console.WriteLine($"{number} ^ {exponent} = {result}");
Console.WriteLine();