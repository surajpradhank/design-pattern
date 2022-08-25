// See https://aka.ms/new-console-template for more information
using FactoryDesignPattern;

Console.WriteLine("Lets learn Design Pattern");

#region Factory Desin Pattern
EmployeeManagerFactory factory = new EmployeeManagerFactory();

IEmployeeManager getEmp1 = factory.GetEmployeeManager(1);
Console.WriteLine($"Pay money for {getEmp1.GetPay()}");
Console.WriteLine($"Bonus money for {getEmp1.GetBonus()}");

IEmployeeManager getEmp2 = factory.GetEmployeeManager(2);
Console.WriteLine($"Pay money for {getEmp2.GetPay()}");
Console.WriteLine($"Bonus money for {getEmp2.GetBonus()}");

#endregion

Console.ReadLine();