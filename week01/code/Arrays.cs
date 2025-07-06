
using System.Security.Claims;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // this function returns the multiples of a number
        // for example, if multiple of a numer is 3 and the lenght is 2, it return [3, 6]

        // create a list to store the multiples
        List<double> results = [];

        // loop from 1 to the specified length
        for (int i = 1; i <= length; i++)
        {
            // for each loop, multiply it by the number and store it the list
            results.Add(i * number);
        }

        // convert the list to an array and return it
        return [.. results];
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // determin the index where rotation begins 
        int splitIndex = data.Count - amount;

        // split the list into two sets "first and second"
        List<int> firstSet = data.GetRange(0, splitIndex);
        List<int> secondSet = data.GetRange(splitIndex, amount);

        // clear the old data list
        data.Clear();

        // join first and second lists together with second list rotated to the first
        data.AddRange(secondSet);
        data.AddRange(firstSet);

    }
}


