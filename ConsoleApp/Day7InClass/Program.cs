
using Day7InClass;
using Day7InClass.Presentation;

//Console.WriteLine(GenericClass.AreEqual(2, 3));
//Console.WriteLine(GenericClass.AreEqual(2.0, 3.0));
//Console.WriteLine(GenericClass.AreEqual("string", "string"));

//Console.WriteLine(GenericClass<int>.AreEqualGeneric(2, 3));
//Console.WriteLine(GenericClass<double>.AreEqualGeneric(2.0, 3.0));
Console.WriteLine(GenericClass<string>.AreEqualGeneric("string", "string"));

ManageCustomer manageCustomer = new ManageCustomer();
manageCustomer.Run();