class Program 
{
    static void Main(string[] args)
    {
        int program = 0;
        string inputString = "Enter first string";
        string secondInputString = "Enter second string";
        while (program == 0)
        {
            double firstValue = GetValidDoubleInput(inputString);
            Console.Clear();
            double secondValue = GetValidDoubleInput(secondInputString);
            Console.Clear();
            char operationType = GetValidOperationInput();
            Console.Clear();

            switch (operationType)
            {
                case '+' :
                    Console.WriteLine($"{firstValue} {operationType} {secondValue} = {firstValue + secondValue}",firstValue, operationType, secondValue);
                    break;
                case '-':
                    Console.WriteLine($"{firstValue} {operationType} {secondValue} = {firstValue - secondValue}", firstValue, operationType, secondValue);
                    break;
                case '*':
                    Console.WriteLine($"{firstValue} {operationType} {secondValue} = {firstValue * secondValue}", firstValue, operationType, secondValue);
                    break;
                case '/':
                    Console.WriteLine($"{firstValue} {operationType} {secondValue} = {firstValue / secondValue}", firstValue, operationType, secondValue);
                    break;

            }
            ContinueMessage();
            Console.WriteLine("Do you want to exit?");
            Console.WriteLine("If you want ot exit type \"Exit\"");
            if (Console.ReadLine() == "Exit")  program = 1;
            Console.Clear();
            


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
                continue;
             
            }
            else
            {
                isValid = true;
               
            }
           
        }
        while (isValid == false);

        return operationType;
    }
    public static double GetValidDoubleInput(string input)
    {
        double number;
        bool isValid = false;
        do
        {
            Console.WriteLine(input);
            if(double.TryParse(Console.ReadLine(),out number))
            {
                if (input.Contains("second"))
                {
                    if (number == 0)
                    {
                        Console.WriteLine("You trying to divide by zero ");
                        ContinueMessage();
                        continue;
                    }
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
        while (isValid == false);
        return number;
    } 
    
    public static void ContinueMessage()
    {
        Console.WriteLine("Press any buttun to continue");
        Console.ReadKey();
        Console.Clear();
    }
}