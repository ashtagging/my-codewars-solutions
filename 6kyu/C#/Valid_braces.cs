// Write a function that takes a string of braces, and determines if the order of the braces is valid. It should return true if the string is valid, and false if it's invalid.

// This Kata is similar to the Valid Parentheses Kata, but introduces new characters: brackets [], and curly braces {}. Thanks to @arnedag for the idea!

// All input strings will be nonempty, and will only consist of parentheses, brackets and curly braces: ()[]{}.

// What is considered Valid?
// A string of braces is considered valid if all braces are matched with the correct brace.

// Examples
// "(){}[]"   =>  True
// "([{}])"   =>  True
// "(}"       =>  False
// "[(])"     =>  False
// "[({})](]" =>  False

public class Brace {

    public static bool validBraces(String braces) {
    Stack<char> stack = new Stack<char>();
    foreach (char c in braces)
    {
        if (c == '(' || c == '[' || c == '{')
        {
            stack.Push(c);
        }
        else if (stack.Count == 0)
        {
            return false;
        }
        else if (c == ')' && stack.Peek() == '(' || 
                 c == ']' && stack.Peek() == '[' || 
                 c == '}' && stack.Peek() == '{')
        {
            stack.Pop();
        }
        else
        {
            return false;
        }
    }
    return stack.Count == 0;
    }
}