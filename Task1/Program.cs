class Program 
{
    static void Main(string[] args)
    {
        bool isProgramRun = true;

        while (isProgramRun)
        {
            double firstValue = GetValidDoubleInput("Enter first string", false);
            Console.Clear();
            char operationType = GetValidOperationInput();
            Console.Clear();
            double secondValue = GetValidDoubleInput("Enter second string", operationType =='/');
            Console.Clear();

            PrintCalculateResult(firstValue, operationType, secondValue);
           
            ContinueMessage();
            Console.WriteLine("Do you want to exit?");
            Console.WriteLine("If you want ot exit type \"Exit\"");
            if (Console.ReadLine() == "Exit") isProgramRun = false;
            Console.Clear();
            


        }          
    }
    public static void PrintCalculateResult(double firstValue, char  operationType, double secondValue)
    {
        
        switch (operationType)
        {
            case '+':
                Console.WriteLine($"{firstValue} {operationType} {secondValue} = {firstValue + secondValue}");
                break;
            case '-':
                Console.WriteLine($"{firstValue} {operationType} {secondValue} = {firstValue - secondValue}");
                break;
            case '*':
                Console.WriteLine($"{firstValue} {operationType} {secondValue} = {firstValue * secondValue}");
                break;
            case '/':
                Console.WriteLine($"{firstValue} {operationType} {secondValue} = {firstValue / secondValue}");
                break;

        }
    
    }
    public static char GetValidOperationInput()
    {
        char[] validOperations = { '+', '-', '*', '/' };
        bool isValid = false;
        char operationType;
        do
        {
            Console.WriteLine("Enter the type of operation:");
            char.TryParse(Console.ReadLine(), out  operationType);
            
            if(!validOperations.Contains(operationType)){
                Console.WriteLine("Error: invalid operation. Please enter one of +, -, *, /.");
                ContinueMessage();
            }
            else
            {
                isValid = true;
            }
           
        }
        while (!isValid);

        return operationType;
    }
    public static double GetValidDoubleInput(string input, bool check_zero)
    {
        double number;
        bool isValid = false;
        do
        {
            Console.WriteLine(input);
            if(double.TryParse(Console.ReadLine(),out number))
            {
                if (check_zero == true && number == 0)
                {
                    
                        Console.WriteLine("You trying to divide by zero ");
                        ContinueMessage();
                        continue;
                   
                }
            }
            else
            {
                Console.WriteLine("Eror: incorrect input");
                ContinueMessage();
                continue;
            }
            isValid = true;
        }
        while (!isValid);
        return number;
    } 
    
    public static void ContinueMessage()
    {
        Console.WriteLine("Press any buttun to continue");
        Console.ReadKey();
        Console.Clear();
    }
}