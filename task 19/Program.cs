Console.Clear();
Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine());
if (a<10000 || a > 100000)
{
    Console.WriteLine("введено неверное число");
    return;
}
if ((a%10 == a/10000)&&((a%100)/10)==((a%10000)/1000))
{
    Console.WriteLine("число является палиндромом");
}
else Console.WriteLine("число не является палиндромом");