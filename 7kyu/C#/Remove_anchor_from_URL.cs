// Complete the function/method so that it returns the url with anything after the anchor (#) removed.

// Examples
// "www.codewars.com#about" --> "www.codewars.com"
// "www.codewars.com?page=1" -->"www.codewars.com?page=1"

public static class Kata
{
  public static string RemoveUrlAnchor(string url)
  {
    int index1 = url.IndexOf('#');
    //  Case where there is no '#' in the string
      if (index1 == -1) 
      {
        return url;
      }
     return url.Substring(0,index1);
  }
}