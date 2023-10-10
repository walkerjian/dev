using System;
using System.Collections.Generic;

public class StackPup
{
    private Stack<char> stack = new Stack<char>();
    private const char NullChar = '\0';  // Representing our null character

    public char Pup
    {
        get 
        {
            return (stack.Count > 0) ? stack.Pop() : NullChar;
        }
        set 
        {
            if (value != NullChar)
                stack.Push(value);
        }
    }
}

public class Program
{
    public static void Main()
    {
        StackPup stackPup = new StackPup();
        
        // Pushing characters onto the stack
        stackPup.Pup = 'A';
        stackPup.Pup = 'B';
        stackPup.Pup = 'C';

        // Popping characters from the stack
        Console.WriteLine(stackPup.Pup);  // Outputs: C
        Console.WriteLine(stackPup.Pup);  // Outputs: B
        Console.WriteLine(stackPup.Pup);  // Outputs: A
    }
}
