// See https://aka.ms/new-console-template for more information
// Usage


using DecoratorDesignPattern;

ICoffee coffee = new BlackCoffee();  // ✅ Declare as ICoffee
coffee = new Milk(coffee);
coffee = new WhippedCream(coffee);

Console.WriteLine(coffee.GetDescription()); // Output: Black Coffee, Milk, Whipped Cream
Console.WriteLine(coffee.GetCost());       // Output: 3.2

