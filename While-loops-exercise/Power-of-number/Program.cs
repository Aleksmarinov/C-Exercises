﻿int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

int result = 1;
int time = 1;

while (time <= power)
{
    time++;
    result = result * number;
}
Console.WriteLine(result);