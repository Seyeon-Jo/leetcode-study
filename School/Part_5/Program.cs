using System;

namespace Part_V
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //====================================================================

            //Q2
            //====================================================================

            //Q3
            //====================================================================

            //Q4
            //====================================================================

            //Q5
            //====================================================================

            //Q6
            //====================================================================
        }

        #region Q1_DisplayIntArray
        /*
        Write a method with header static void DisplayIntArray(int[] numbers).
        The first argument is an array of ints. There is no return value.
        This method displays all the elements of the argument on a single line.
        Each item will occupy three columns.
        Call this method from main with a suitable argument.
        */

        #endregion

        #region Q2_GenerateRandomIntArray
        /*
        Write a method with header static int[] GenerateRandomIntArray(int numberOfItems, int largestValue).
        The first argument is an int indicating the number of elements that will be present in the return array.
        The second argument is an int representing the largest item in the array.
        The returned value is an array of integers. This method does the following:
            a.	Declare and initialized a variable of type Random (Random generator = new Random();)
            b.	Declare an array of type int (you may call it result)
            c.	Allocate storage for the correct number of items
            d.	Using your favorite looping statement, assign a random integer to each element of the array (result[i] = generator.Next(largestValue);)
        In your main method, call the above method three times with arguments 15, 10 and 25, 10 and 30, 100.
        In each case assignment the results to a suitable variable and use the DisplayIntArray() method to display the value.
        */

        #endregion

        #region Q3_CountEvenOdd
        /*
        Write a method with header static int[] CountEvenOdd(int[] array).
        The argument is an int array. The returned value is an array of 2 integers.
        The elements of the return array will be a count of the odd and even items in the argument.
        The first element of the returned array represents the number of odds in the argument and the second element indicates the number of evens in the argument.
        The method will create an int array of 2 elements (call this the result).
        Each item of the argument is examined and the appropriate element of the result array is incremented.
        In your main method, call the GenerateRandomIntArray() method to create an int array using and assign it to a suitable variable.
        Using the DisplayIntArray() method display all the item of the return.
        Call the CountEvenOdd() method passing the above array as an argument and display the return value.
        Do a count to verify that your method is working correctly.
        */

        #endregion

        #region Q4_CalculateDigitFrequencies
        /*
        Write a method with header static int[] CalculateDigitFrequencies(int[] array).
        The argument is an int array with values ranging from 0 to 9.
        The returned value is an array of 10 integers.
        The elements of the return array will be a count of the frequencies of the items in the argument.
        The first element of the returned array represents the number of 0’s in the argument, the second element indicates the number of 1’s in the argument and the third element will indicate the number of 2’s in the argument.
        The method will create an int array of 10 elements (call this the result).
        Each item of the argument is examined and the appropriate element of the result array is incremented. 
        In your main method, create an int array using the GenerateRandomIntArray() method remember to use 10 as the second argument to the method and then print out the elements using the DisplayIntArray() method.
        Call the above method and display the return value.
        Do a count to verify that your method is working correctly.
        */

        #endregion

        #region Q5_CalculateLastDigitFrequencies
        /*
        Write a method with header static int[] CalculateLastDigitFrequencies(int[] array).
        The argument is an int array. The returned value is an array of 10 integers.
        The elements of the return array will be a count of the frequencies of the items in the argument.
        The first element of the returned array represents the number with last digit of 0’s in the argument, the second element indicates the number with last digit of 1’s in the argument and the third element will indicate the number with last digit of 2’s in the argument.
        The method will create an int array of 10 elements (call this the result).
        Each item of the argument is examined and the appropriate element of the result array is incremented. 
        In your main method, create an int array using the GenerateRandomIntArray() method and then print out the elements using the DisplayIntArray() method.
        Call the above method and display the return value. Do a count to verify that your method is working correctly.
        */

        #endregion

        #region Q6_CalculateNumberFrequencies
        /*
        Write a method with header static int[] CalculateNumberFrequencies(int[] array).
        The argument is an int array with values ranging from 0 to 99.
        The returned value is an array of 10 integers.
        The first element will indicate the number or unit values in the argument (i.e. values 0-9), the second element will indicate the number of 10 values (i.e. values 10-19), the third element will indicate the number of 20 values (i.e. values 20-29) etc.
        The method will create an int array of 10 elements (call this the result).
        Each item of the argument is examined and the appropriate element of the result array is incremented.
        In your main method, create an int array using the GenerateRandomIntArray() method and then print out the elements using the DisplayIntArray() method.
        Call the above method and display the return value. Do a count to verify that your method is working correctly.
        */

        #endregion
    }
}

