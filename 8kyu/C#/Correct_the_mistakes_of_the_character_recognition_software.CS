// Character recognition software is widely used to digitise printed texts. Thus the texts can be edited, searched and stored on a computer.

// When documents (especially pretty old ones written with a typewriter), are digitised character recognition softwares often make mistakes.

// Your task is correct the errors in the digitised text. You only have to handle the following mistakes:

// S is misinterpreted as 5
// O is misinterpreted as 0
// I is misinterpreted as 1
// The test cases contain numbers only by mistake.

public class Kata
{
  public static string Correct(string text)
  {
    char[] result = text.ToCharArray();
    
    for (int i = 0; i < result.Length; i++)
    {
      if (result[i] == '0')
      {
        result[i] = 'O';
      }
      if (result[i] == '5')
      {
        result[i] = 'S';
      }
      if (result[i] == '1')
      {
        result[i] = 'I';
      }
    }
    return new string(result);
  }
}