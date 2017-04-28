namespace _02_BadExamples
{
  using System;
  using System.Globalization;

  public static class Example04
  {
    public static double TwoDecimalPlaces_Comments(double number)
    {
      // Get the string equivalent of the number
      string numberString = number.ToString(CultureInfo.InvariantCulture);

      // Get the index of the number after the 2nd decimal place
      int removeFromStartIndex = numberString.LastIndexOf(".") + 3;

      // Get the number of remaining decimal places
      int remainingPlacesCount = numberString.Length - removeFromStartIndex;

      // Get the formatted number with only 2 decimal places
      string formattedNumber = numberString.Remove(removeFromStartIndex, remainingPlacesCount);

      // Return the formatted number
      return Double.Parse(formattedNumber);
    }
  }
}