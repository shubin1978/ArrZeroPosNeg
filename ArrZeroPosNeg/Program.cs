// See https://aka.ms/new-console-template for more information
Console.Write("Введите размер массива : ");
var size = Convert.ToInt32(Console.ReadLine());
var arr = new List<int>();
var random = new Random();
for (int i = 0; i < size; i++)
{
    arr.Add(random.Next(-5,5));
}

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("[ ");
foreach (var item in arr)
{
    Console.Write($"{item} ");
}
Console.WriteLine("]");
var arrNegative = new List<int>();
foreach (var item in arr)
{
    if (item < 0)
    {
        arrNegative.Add(item);
    }
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Negative : [ ");
foreach (var item in arrNegative)
{
    Console.Write($"{item} ");
}
Console.WriteLine("]");

var arrPositive = new List<int>();
foreach (var item in arr)
{
    if (item > 0)
    {
        arrPositive.Add(item);
    }
}
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Positive : [ ");
foreach (var item in arrPositive)
{
    Console.Write($"{item} ");
}
Console.WriteLine("]");

var arrZero = new List<int>();
foreach (var item in arr)
{
    if (item == 0)
    {
        arrZero.Add(item);
    }
}
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write("ZEROS : [ ");
foreach (var item in arrZero)
{
    Console.Write($"{item} ");
}
Console.WriteLine("]");
Console.ResetColor();