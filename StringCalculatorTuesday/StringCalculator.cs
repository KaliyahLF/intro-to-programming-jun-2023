
using System.Text.RegularExpressions;

namespace StringCalculator;

public class StringCalculator
{
    private string[] values;
    private char[] delimiter = new char[] { ',', '\n', ';', '/'};
    private int sum = 0;

    private char[] negative = new char[] { '-' };
    private string[] negNumbers;
    public int Add(string numbers)
    {
        // Handles if there's no entry
        if (numbers == "") return 0;

        //Handles if there's only one number
        if (numbers.Length == 1) return int.Parse(numbers);

        try
        {
            numbers.Contains('-');
            negNumbers = numbers.Split(negative);
        } catch { 
            Console.WriteLine("Negatives are not allowed. You entered: ");
            return 0;
        }
        
        //If there are multiple numeric values separated by a delimiter,
        // then they are treated as separate numbers that will be summed together.
        values = numbers.Split(delimiter, StringSplitOptions.RemoveEmptyEntries); //RemoveEmptyEntries
        foreach (string number in values)
        {
           sum += int.Parse(number);
                
        }
           return sum;
        
    }
}   
