using Day5;

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
Console.WriteLine("\n\nProgram2:");
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
 * Q9: _ represetns default behavior
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