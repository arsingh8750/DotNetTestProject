using System.Globalization;

namespace MauiApp3.IConverter
{
    public class RangeValidator : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is int day)
            {
                return day switch
                {
                    1 => "Sunday",
                    2 => "Monday",
                    3 => "Tuesday",
                    4 => "Wednesday",
                    5 => "Thursday",
                    6 => "Friday",
                    7 => "Saturday",
                    _ => "Invalid" // Handle cases where day is not 1-7
                };
            }
          return "Invalid"; // Handle cases where value is not an int
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
