// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World! 3");

static void Main(string[] args)
{
    int[] arr = { 1, 3, 2, 9, 1, 2 };
    Console.WriteLine("Average = " + Average(arr));
    Console.WriteLine("Max = " + Max(arr));
}

static double Average(int[] ints)
{
    return ints.Sum() / (double)ints.Length;
}

static double Max(int[] ints)
{
    return ints.Max();
}