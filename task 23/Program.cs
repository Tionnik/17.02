Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int i=1;
if (N<0)
{
    i=N;
    N=-1;
}
for (; i<=N; i++)
{
 
   Console.Write(i*i*i + ", ");
}