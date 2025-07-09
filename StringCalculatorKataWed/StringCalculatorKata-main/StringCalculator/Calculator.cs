
using System.Text.RegularExpressions;

namespace StringCalculator;

public class Calculator
{
    private static int _sumTotal = 0;

    public void Add(string numbers)
    {
        _sumTotal = 0;

        if (!String.IsNullOrEmpty(numbers))
        {

            if (numbers.Contains('-'))
            {
                throw new ArgumentException("Negative Numbers are not allowed");
            }


            string[] numArray = Regex.Split(numbers, "[^0-9]");
            Console.WriteLine(numArray[0]);

            if (numArray.Length < 2)
            {
                _sumTotal = int.Parse(numArray[0].Trim());
            }
            else
            {
                for (int i = 0; i < numArray.Length; i++)
                {
                    _sumTotal += int.Parse(numArray[i].Trim());
                }
            }
        }
    }

    public int ReturnResult()
    {
        return _sumTotal;
    }
}
