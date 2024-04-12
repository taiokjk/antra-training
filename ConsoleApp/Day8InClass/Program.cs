using Day8InClass;
using Day8InClass.Presentation;

MathDelegate mathDelegate = new MathDelegate(ArithmeticOperation.Sub);
Console.WriteLine(mathDelegate(30, 20));

PreDefinedDelegates preDefinedDelegates = new PreDefinedDelegates();
preDefinedDelegates.ActionExample();
preDefinedDelegates.PredicateDemo();
preDefinedDelegates.FuncExample();

var personAnonymousType = new
{
    Name = "Hi",
    Age = "27"
};

ManageEmployee manageEmployee = new ManageEmployee();
manageEmployee.Print();



ExceptionHandlingDemo exceptionHandlingDemo =  new ExceptionHandlingDemo();

try
{
    Console.Write("Enter first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    if (num1 < 0)
        throw new NumberException();

    Console.Write("Enter second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 < 0)
        throw new NumberException();

    Console.Write("Enter operation: ");
    string operation = Console.ReadLine();

    exceptionHandlingDemo.Calculate(num1, num2, operation);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NumberException ex)
{
    Console.WriteLine(ex.Message);
}