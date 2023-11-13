class Checker
{
    static void Main()
    {
        double first = Convert.ToDouble(Console.ReadLine());
        double second = Convert.ToDouble(Console.ReadLine());
        double third = Convert.ToDouble(Console.ReadLine());

        int start = -5;
        int end = 5;

        if (first >= start && first <= end &&
            second >= start && second <= end &&
            third >= start && third <= end)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}