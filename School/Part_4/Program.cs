using System;

namespace Part_IV
{
    class Program
    {
        static void Main(string[] args)
        {
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

        #region Q2_CubeIt
        /*
        Write a method call CubeIt(int x, ref int cube) that takes two arguments and does not return a value.
        The method will cube the first argument and assign it to the second argument.
        In your main create two variables and print them,
        call this method and print the value of both of the parameters after the method call.
        Change the first parameter and repeat.
        */

        #endregion

        #region Q3_CalculateTuitionFee
        /*
        Write a method with the following header: static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees).
        This method will calculate and assign the required fees amount to the third argument.
        [Fees = number of courses * cost per course + 15.25].
        [Use variable when invoking the method and when printing.]
        From your program Main() method,
        call the CalculateTuitionFee () method four times supplying different arguments each time and
        display the value of the third argument after each method call.
        */

        #endregion

        #region Q4_ValueFourParameters
        /*
        Write a method that takes four parameter of type int.
        The method will assign the sum of the first two arguments to the third and the difference of the first two to the fourth.
        This method should be coded so that the calling method will use the value of the third and fourth parameters. [Do not use the Math.Abs() method.]
        Call this method about three times and print out the value of the four parameters after each method call.
        */

        #endregion

        #region Q5_CalculateTrigValues
        /*
        Write a method with header static void CalculateTrigValues
        (double degrees, out double sine, out double cosine, out double tangent).
        The method will use the first argument to compute the values of the other three arguments.
        Used the method Math.Sin, Math.Cos and Math.Tan to compute the second to fourth arguments respectively.
        [radians = degrees * Math.Pi /180].
        In the Main() method, invoke this method 20 times with the first argument taking the values 0, 5, 10, … 95 and display the four arguments in a professional tabular format.

        The argument is taken as degrees.
        */

        #endregion

        #region Q6_ValuesAngleSineCosine
        /*
        Write a method that takes three parameters of type double: the first represents an angle, the other two represents the sine and cosine of the angle respectively.
        The method must be able to change the actual value of the second and third argument.
        In your Main() method, call this method ten times with values 0.50, 0.51, 0.52 … 0.59 and
        printout the values for angle, sine and cosine in a tabular format.

        The argument is taken as radians.
        */

        #endregion
    }
}

