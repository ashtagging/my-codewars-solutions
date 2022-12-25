//     Write function bmi that calculates body mass index (bmi = weight / height2).

// if bmi <= 18.5 return "Underweight"

// if bmi <= 25.0 return "Normal"

// if bmi <= 30.0 return "Overweight"

// if bmi > 30 return "Obese"

public class Kata
{
  public static string Bmi(double weight, double height)
  {
    double bmi = weight / (height*height);
    switch (bmi)
    {
      case double n when (n < 18.5):
        return "Underweight";
      case double n when (n >= 18.5 && n < 25):
        return "Normal";
      case double n when (n >= 25 && n < 30):
        return "Overweight";
      case double n when (n >= 30):
        return "Obese";
      default:
        return "Invalid BMI";
    }
  }
}