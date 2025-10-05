class Program 
{
    static void Main(string[] args)
    {
        while (true)
        {
            
          


        }          
    }
    public static void VelcomeMessage()
    {
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Welcome to calculator");
        Console.WriteLine("Enter number of operation what do you want to do now:");
        Console.WriteLine("Type 1 to start calculating");
        Console.WriteLine("Type 2 to exit from program");
    }
    public static void EnterNumbersAndOperation()
    {
        Console.Write("Enter the fist number: ");
        double first_number = double.Parse(Console.ReadLine());

        Console.Write("\n Enter the operation(*, /, +, -)");
        char operation_type = Char.Parse(Console.ReadLine());

        Console.Write("\n Enter the second number: ");
        double second_number = double.Parse(Console.ReadLine());
    }
    public static void ErrorMessage(string message)
    {
        Console.WriteLine("You are made this eror:");
        Console.WriteLine(message);
    }
}