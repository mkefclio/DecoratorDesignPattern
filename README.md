# Decorator Design Pattern - Coffee Customization Console App

Welcome to the **Decorator Design Pattern - Coffee Customization Console App**! This project demonstrates the implementation of the Decorator Design Pattern in .NET Core through a simple and practical example.

## Overview

This console application illustrates how the Decorator Design Pattern can be utilized to dynamically add functionalities to objects—in this case, customizing a coffee order—without modifying their structure.

The aim of this project is to provide a clear and accessible explanation of the Decorator Design Pattern, enabling developers of all experience levels to understand and apply it effectively.

I have also elaborated on this pattern in my LinkedIn article: [Let's Play With: Design Patterns - Decorator Design Pattern](https://www.linkedin.com).

This project was created by **Manos Kefalas** to assist developers in learning and effectively using the Decorator Design Pattern.

## How It Works

The project is organized into the following components:

1. **Component Interface (`ICoffee`)**: Defines the methods `GetDescription()` and `GetCost()` that all coffee types and decorators must implement.

2. **Concrete Component (`BlackCoffee`)**: Implements the `ICoffee` interface, representing the base coffee.

3. **Decorator Abstract Class (`CoffeeDecorator`)**: Implements the `ICoffee` interface and contains a reference to an `ICoffee` object. It serves as a base class for all decorators.

4. **Concrete Decorators (`Milk`, `WhippedCream`)**: Extend the `CoffeeDecorator` to add specific functionalities, such as milk or whipped cream, to the base coffee.

## Code Structure

**Step 1: Define the Component Interface**

```csharp
public interface ICoffee
{
    string GetDescription();
    double GetCost();
}
```

**Step 2: Implement the Concrete Component**

```csharp
public class BlackCoffee : ICoffee
{
    public string GetDescription() => "Black Coffee";
    public double GetCost() => 2.0;
}
```

**Step 3: Create the Decorator Abstract Class**

```csharp
public abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee ?? throw new ArgumentNullException(nameof(coffee));
    }

    public virtual string GetDescription() => _coffee.GetDescription();
    public virtual double GetCost() => _coffee.GetCost();
}
```

**Step 4: Implement Concrete Decorators**

```csharp
public class Milk : CoffeeDecorator
{
    public Milk(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => base.GetDescription() + ", Milk";
    public override double GetCost() => base.GetCost() + 0.5;
}

public class WhippedCream : CoffeeDecorator
{
    public WhippedCream(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => base.GetDescription() + ", Whipped Cream";
    public override double GetCost() => base.GetCost() + 0.7;
}
```

**Step 5: Utilize the Decorators in the Program**

```csharp
using System;

class Program
{
    static void Main()
    {
        ICoffee coffee = new BlackCoffee();
        coffee = new Milk(coffee);
        coffee = new WhippedCream(coffee);

        Console.WriteLine(coffee.GetDescription()); // Output: Black Coffee, Milk, Whipped Cream
        Console.WriteLine(coffee.GetCost());       // Output: 3.2
    }
}
```

## Getting Started

**Prerequisites**

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your system.
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/).

**Run the Application**

1. **Clone the Repository:**

    ```bash
    git clone https://github.com/mkefclio/DecoratorDesignPattern.git
    cd DecoratorDesignPattern
    ```

2. **Build and Run the Project:**

    ```bash
    dotnet run
    ```

**Expected Output**

```
Black Coffee, Milk, Whipped Cream
3.2
```

## Explanation

**Key Components**

- **Component Interface (`ICoffee`)**: Establishes the contract for components and decorators.
- **Concrete Component (`BlackCoffee`)**: The base object to be decorated.
- **Decorator Abstract Class (`CoffeeDecorator`)**: Provides a base for all decorators, holding a reference to an `ICoffee` object.
- **Concrete Decorators (`Milk`, `WhippedCream`)**: Add specific functionalities to the base coffee.

This structure adheres to the Decorator Design Pattern, promoting flexibility and reusability by allowing behavior to be added to individual objects dynamically.

## Article Link

Read my detailed article on LinkedIn: [Let's Play With: Design Patterns - Decorator Design Pattern](https://www.linkedin.com).

## About the Author

This project was created by **Manos Kefalas** as part of the series "Let's Play With: Design Patterns," aiming to provide practical examples for developers to learn and apply design patterns effectively.

Connect with me on LinkedIn: https://www.linkedin.com/in/manos-kefalas-96b1a3121/.

## License

This project is licensed under the MIT License. Feel free to use and modify it for learning or other purposes.

Happy coding! 🎉 
