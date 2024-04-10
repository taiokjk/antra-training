using Day5;
using static System.Net.Mime.MediaTypeNames;

/* Understanding Data Types
 * Test your knowledge
 * Q1: 
 *      A person's telephone numer: string
 *      A person's height: int
 *      A person's age: int
 *      A person's gender: sttring
 *      A person's salary: float
 *      A book's ISBN: string
 *      A book's price: float
 *      A book's shipping weight: float
 *      A country's population: uint
 *      A number of stars in the universe: ulong
 *      The number of employees in each of the small 
 *          or medium businesses in the United Kingdom: int
 * Q2: Value types hold the actual value of the variable
 *      Reference types hold the reference to the memory address 
 *          that has the value that variable represents
 *      Value types exist in the stack memory
 *      Reference types exist in the heap memory
 *      Value types are not deleted by the Garbage Collector
 *      Reference types get collected
 *      Value types cannot be null
 *      Value types can be declared by struct, enum
 *      Reference types can be declared by a class, interface, delegate, or array
 *      Boxing: converts value types to reference types
 *      Unboxing: converts reference types to value types
 * Q3: Managed resource is resource that managed under Garbage Collection
 *      Unmanaged resource is resource that will not be managed by Garbage
 *          Collection, thus must be called .Dispose() upon deletion
 * Q4: Garbage Collector is used to free up unused resources and increase
 *      performance.
 */
UnderstandingDataTypes understandingDataTypes = new UnderstandingDataTypes();

// Program 1:
Console.WriteLine("Understanding Data Types:");
Console.WriteLine("Program 1:");
understandingDataTypes.NumOfBytes();

// Program 2:
Console.WriteLine("\n\nProgram 2:");
understandingDataTypes.PrintCenteries(1);

/* Controlling Flow and Converting Types
 * Test your knowledge
 * Q1: An exception of Divide By Zero will be thrown.
 * Q2: The code will be executed normally because 0 in double is not
 *      exactly 0.
 * Q3: A compilation error will be shown.
 * Q4: x = y++ will set x = y, then increment y
 *      x = ++y will increment y first, then set x = y
 * Q5: break will break out of the loop
 *      continue will skip this iteration and continue on with the loop
 *      return will break and return the value
 * Q6: The initializer, the condition, and the iterator
 * Q7: = sets the value of the variable
 *      == compares the value of the variable(s)
 * Q8: Yes
 * Q9: _ represents default behavior
 * Q10: IEnumerable
 */
LoopsAndOperators loopsAndOperators = new LoopsAndOperators();

Console.WriteLine("\n\nUnderstanding Data Types:");
Console.WriteLine("Program 1:");
loopsAndOperators.FizzBuzz(100);

/* int max = 500;
 * for (byte i = 0; i < max; i++)
 * {
 *     Console.WriteLine(i);
 * }
 * 
 * The above code block will be an infinite loop because a byte will
 *  never reach the value of 500
 * An exception can be thrown as
 * if max > byte.MaxValue
 *      throw new OverflowException();
 */

Console.WriteLine("\n\nProgram 2:");
loopsAndOperators.PrintAPyramid(5);

Console.WriteLine("\n\nProgram 3:");
loopsAndOperators.GuessingGame();

Console.WriteLine("\n\nProgram 4:");
loopsAndOperators.BirthDay();

Console.WriteLine("\n\nProgram 5:");
loopsAndOperators.Greeting();

Console.WriteLine("\n\nProgram 6:");
loopsAndOperators.Counting();

/* Arrays
 * Test your knowledge
 * Q1: We use string for a simple value initilization of a string object
 *      We use StringBuilder if we need to perform a lot of string manipulations
 * Q2: The base class of all arrays is the abstract type Array
 * Q3: We can use Array.Sort for sorting an array
 * Q4: Property Length is to get the length of an array
 * Q5: Yes. We can declare an array of type Object
 * Q6: They are both shallow copy (copy the reference of the objects inside)
 *      CopyTo needs a destination, Clone returns a new array
 *      CopyTo is faster than Clone
 */
Arrays arrays = new Arrays();

// Program 1:
Console.WriteLine("Arrays:");
Console.WriteLine("Program 1:");
arrays.CopyArray();

// Program 2:
Console.WriteLine("\n\nProgram 2:");
arrays.GroceryList();

// Program 3:
Console.WriteLine("\n\nProgram 3:");
int[] primeArr = arrays.FindPrimesInRange(0, 100);
Console.Write("Prime numbers: [");
for  (int i = 0; i <  primeArr.Length; i++)
{
    if (i == 0)
        Console.Write(primeArr[i]);
    else
        Console.Write($", {primeArr[i]}");
}
Console.WriteLine("]");

// Program 4:
Console.WriteLine("\n\nProgram 4:");
int[] sumRotate = arrays.SumRotate([3, 2, 4, -1], 2);
Console.Write("sum: [");
for (int i = 0; i < sumRotate.Length; i++)
{
    if (i == 0)
        Console.Write(sumRotate[i]);
    else
        Console.Write($", {sumRotate[i]}");
}
Console.WriteLine("]");

sumRotate = arrays.SumRotate([1, 2, 3, 4, 5], 3);
Console.Write("sum: [");
for (int i = 0; i < sumRotate.Length; i++)
{
    if (i == 0)
        Console.Write(sumRotate[i]);
    else
        Console.Write($", {sumRotate[i]}");
}
Console.WriteLine("]");

// Program 5:
Console.WriteLine("\n\nProgram 5:");
arrays.LongestSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]);
arrays.LongestSequence([1, 1, 1, 2, 3, 1, 3, 3]);
arrays.LongestSequence([4, 4, 4, 4]);
arrays.LongestSequence([0, 1, 1, 5, 2, 2, 6, 3, 3]);

// Program 7:
Console.WriteLine("\n\nProgram 7:");
arrays.MostFrequent([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);
arrays.MostFrequent([7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10]);




// Program 1:
Console.WriteLine("Strings:");
Console.WriteLine("Program 1:");
StringPractice.ConvertReverse("sample");
StringPractice.PrintReverse("24tvcoi92");

// Program 2:
Console.WriteLine("\n\nProgram 2:");
StringPractice.ReverseWords("C# is not C++, and PHP is not Delphi!");
StringPractice.ReverseWords("The quick brown fox jumps over the lazy dog /Yes! Really!!!/.");

// Program 3:
Console.WriteLine("\n\nProgram 3:");
StringPractice.ExtractPalindromes("Hi,exe? ABBA! Hog fully a string: ExE. Bob");

// Program 4:
Console.WriteLine("\n\nProgram 4:");
StringPractice.ParseURL("https://www.apple.com/iphone");
StringPractice.ParseURL("ftp://www.example.com/employee");
StringPractice.ParseURL("https://google.com");
StringPractice.ParseURL("www.apple.com");
