class Checker
{
    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int[] numbers = { a, b, c };
        Console.WriteLine(numbers.Max());
        Console.WriteLine(numbers.Min());
    }
}