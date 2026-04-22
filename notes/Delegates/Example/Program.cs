/*

In C#, a delegate is a type-safe function pointer that allows methods to be referenced and invoked dynamically. It provides a way to treat methods as objects, enabling scenarios such as event handling, callbacks and functional-style programming.

Key Points
A delegate defines the signature of methods it can point to.
It can reference both static and instance methods.
Delegates are type-safe, meaning the method signature must match the delegate declaration.
They are the foundation of events and anonymous functions in C#.
When to Use Delegates
For implementing callbacks.
For handling events.
For writing flexible, reusable code where behavior can be passed as parameters.
For functional-style programming with LINQ and lambdas.
Declaration of Delegates
Delegate type can be declared using the delegate keyword.Once a delegate is declared, delegate instance will refer and call those methods whose return type and parameter-list matches with the delegate declaration.*/




/*Syntax:

[modifier] delegate [return_type][delegate_name]([parameter_list]);

modifier: Defines the accessibility of the delegate (public, private, internal, etc.). It is optional.
delegate: The keyword used to declare a delegate.
return_type: The type of value returned by the methods referenced by the delegate (can also be void).
delegate_name: The identifier you assign to the delegate.
parameter_list: Defines the parameters the delegate requires.The methods assigned must match this list exactly.*/


using System;

public class DelegateExample
{
    // Delegate declaration
    public delegate void MyDelegate(string message);

    // Method matching the delegate signature
    public static void DisplayMessage(string msg)
    {
        Console.WriteLine("Message: " + msg);
    }

    public static void Main()
    {
        // Instantiating delegate
        MyDelegate del = DisplayMessage;

        // Invoking delegate
        del("Hello from delegate!");
    }
}

///Actiity
///1)Create a simple winform application with example in simple C# 
///2)How to deploy code in dontet application
///3)Exception handling in C# with example
///4)Class to class method communication in C# with example
///5)Commucation between class and object in C# with example
///6)Reusability in C# with example
///7)Inbuild packages in C# with example
///8)How to work ddl in C# with example
///9)C# + ADO connectivity with example
