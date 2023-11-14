class Solution
{
    public struct Dog
    {
        public string name;
        public string mark;
        public int age;

        public override string ToString()
        {
            return $"Name: {name}, mark: {mark}, age: {age}";
        }

    }
    public static void Main()
    {
        Dog myDog = new Dog();
        Console.Write("Enter dog name: ");
        myDog.name = Console.ReadLine();
        Console.Write("Enter mark: ");
        myDog.mark = Console.ReadLine();
        Console.Write("Enter age: ");
        myDog.age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(myDog.ToString());
    }
}
