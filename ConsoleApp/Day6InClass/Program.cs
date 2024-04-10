
using Day6InClass;

Customer firstCustomer = new Customer(id:1, customerName:"Hi", 
                     email:"something@mail.com");

Customer secondCustomer = new Customer(id: 1, customerName: "Hello",
                     email: "something@mail.com", phone:"511-231-4242");

FullTimeEmployee fte = new FullTimeEmployee(1);
fte.PerformWork();

PartTimeEmployee pte = new PartTimeEmployee(2);
pte.PerformWork();

Manager manager = new Manager(3);

Addition.AddNumbers(1, 2);

// Extension
int a = 3;
Console.WriteLine(a.EvenOrOdd());