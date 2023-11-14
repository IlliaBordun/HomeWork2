class Checker
{
    public enum HTTPError
    {
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404
    }

    public static void Main()
    {
        int errorCode = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((HTTPError)errorCode);
    }
}
