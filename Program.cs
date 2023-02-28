// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.WriteLine("Введите m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int NatSum(int m, int n)
{
    if (m > n) return 0;
    if (m==n) return m + NatSum(m+1,n-1);
    return m + n + NatSum(m+1,n-1);
}
int x = NatSum(m,n);
Console.WriteLine(x);
