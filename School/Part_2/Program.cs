using System;

namespace Part_II
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

            //Q7
            //====================================================================

            //Q8
            //====================================================================
        }

        #region Q1_DisplayHorizontalStars
        /*
        Write a method called DisplayHorizontalStars(int numberOfStars).
        This method will output the number of stars horizontally specified by its argument.
        Call the DisplayHorizontalStars() method three times from your program Main() method,
        supplying 0, 5 and 10 respectively for the number of stars.

        When you invoke these kinds of methods,
        the value of the parameter is placed within the pair of brackets and the types are omitted.
        If there are multiple parameters, than they are separated by commas.
        */

        #endregion

        #region Q2_DisplayVerticalStars
        /*
        Write a method similar to the one above that displays a vertical line of stars.
        Call this method three times with arguments 0, 5 and 10 respectively.
        */

        #endregion

        #region Q3_DisplayVolumeSphere
        /*
        Write a method that accepts an argument of type double.
        The method will calculate and display the volume of a sphere with radius specified by its argument.
        [V = 4/3 πr^3].
        Call this method from your main three times, with arguments 1, 2, and 10 respectively.
        The answers are 4.1888, 33.5103 and 4188.7902 respectively.
        Use Math.PI for the value of π
        */

        #endregion

        #region Q4_DisplaySellingPrice
        /*
        Write a method that takes two arguments: a cost price and a two-letter province code.
        It will calculate and display the selling price.
        (If province is Ontario a tax of 13% is added to the price, if the province is Quebec a tax of 17% is added to the cost price. There is no tax for the rest of the provinces and territories).
        In your main, call this method enough times to fully test it.
        */

        #endregion

        #region Q5_DisplayCelsiusFahrenheit
        /*
        Write a method that takes a single argument of type double.
        The will display a Celsius to Fahrenheit conversion table.
        The starting temperature is indicated by the argument and it will display 10 lines in increments of 1.
        [Fahrenheit = 9/5 Celsius + 32]. 
        In your main call this method two times, each time with a different start value.
        */

        #endregion

        #region Q6_DisplayKilometerMiles
        /*
        Write a method that takes the following arguments: a starting km value of type double, an increment size of type double and the number of lines of type int.
        The display a kilometer to miles conversion table. [miles = km * 0.621371].
        In your main call this method three times, each time with different values.
        */

        #endregion

        #region Q7_ModifyDisplaySineTable
        /*
        Modify the DisplaySineTable() method in the previous section to accept the start value,
        the step size and number of rows as argument to the method.
        */

        #endregion

        #region Q8_ConvertCmToMcm
        /*
        Write a method that converts a person’s height from centimeter to meters and centimeters and display the result on the console.
        In your main method, you should call this method three times with argument 90, 120 and 275.

        | Input	  | Result   |
        | 90cm	  | 0m 90cm  |
        | 120cm	  | 1m 20 cm |
        | 275cm	  | 2m 75cm  |
        */

        #endregion
    }
}

