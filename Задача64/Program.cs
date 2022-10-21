// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""

int M = 1;
int N = 5;
Console.Write("\"\"");
 for (M = 1; M <= N-1;M++)
 {
    Console.Write(M);
    Console.Write(", ");
 }
Console.Write(N);
Console.Write("\"\"");