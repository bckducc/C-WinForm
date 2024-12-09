int a;
int b;
try
{
    Console.Write("A = ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("B - ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(a / b);
}

catch (FormatException e)
{
    Console.WriteLine("Loi " + e.ToString());
}

catch (DivideByZeroException)
{
    Console.WriteLine("Loi chia cho 0");
}