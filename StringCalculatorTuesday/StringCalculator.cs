
using System.Text.RegularExpressions;

namespace StringCalculator;

public class StringCalculator
{
    //String list for numbers separated by delimiter
    private string[] values, negNumbers, temp;
    //char list for delimiters
    private char[] delimiter = new char[] { ',', '\n', ';', '/', '-', '*'};
    //Sum to add the numbers within the string together
    private int sum = 0;

    
   
    public int Add(string numbers)
    {
        // Handles if there's no entry
        if (numbers == "") return 0;

        //Handles if there's only one number
        if (numbers.Length == 1) return int.Parse(numbers);

        if(numbers.Contains('-'))
        {
            negNumbers = numbers.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            //negNumbers = negNumbers.Split(delimiter);
            Console.WriteLine("Negatives are not allowed. You entered: ");
            foreach (string neg in negNumbers)
            {
                
                Console.Write("\"-" + neg + " \"");
                return 0;
            }
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
