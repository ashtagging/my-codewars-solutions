// Create a function that gives a personalized greeting. This function takes two parameters: name and owner.

// Use conditionals to return the proper message:

// case	return
// name equals owner	'Hello boss'
// otherwise	'Hello guest'

public class Kata
{
  public static string Greet(string name, string owner)
  {
    return name == owner ? "Hello boss" : "Hello guest";
  }  
}

