// Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

// HH = hours, padded to 2 digits, range: 00 - 99
// MM = minutes, padded to 2 digits, range: 00 - 59
// SS = seconds, padded to 2 digits, range: 00 - 59
// The maximum time never exceeds 359999 (99:59:59)

// You can find some examples in the test fixtures.
using System;

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
      string hs = "";
      string ms = "";
      string ss = "";
      
      if(seconds < 60){
        int sr = seconds % 60;
        if(seconds < 10){
          ss = $"0{sr}";
      } else {
        ss = $"{sr}";
      }
        return $"00:00:{ss}";
      } else{
              
      int hr = seconds % 3600;
      
      int hours = Convert.ToInt32(seconds/3600);
      if(hours < 10){
        hs = $"0{hours}";
      } else {
        hs = $"{hours}";
      }
      
      int minutes = Convert.ToInt32(hr/60);
      if(minutes < 10){
        ms = $"0{minutes}";
      } else{
        ms = $"{minutes}";
      }
      
      int mr = minutes % 60;
      Console.WriteLine(mr);
      
      if(mr < 10){
        ss = $"0{mr}";
      } else {
        ss = $"{mr}";
      }
      
      return $"{hs}:{ms}:{ss}";
      }

    }
}