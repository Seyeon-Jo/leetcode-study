using System;

namespace Part_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q2
            /*
            Write a method call CubeIt(int x, ref int cube) that takes two arguments and does not return a value.
            The method will cube the first argument and assign it to the second argument.
            In your main create two variables and print them,
            call this method and print the value of both of the parameters after the method call.
            Change the first parameter and repeat.
            */
            // int a = 2, b = 0;
            // Console.WriteLine($"{a}, {b}");
            // CubeIt(a, ref b);
            // Console.WriteLine($"{a}, {b}");
            // a = 3;
            // CubeIt(a, ref b);
            // Console.WriteLine($"{a}, {b}");
            //====================================================================

            //Q3
            /*
            Write a method with the following header: static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees).
            This method will calculate and assign the required fees amount to the third argument.
            [Fees = number of courses * cost per course + 15.25].
            [Use variable when invoking the method and when printing.]
            From your program Main() method,
            call the CalculateTuitionFee () method four times supplying different arguments each time and
            display the value of the third argument after each method call.
            */
            // double fees1 = 0, fees2 = 0, fees3 = 0, fees4 = 0;
            // CalculateTuitionFee(3, 500, ref fees1);
            // CalculateTuitionFee(4, 600, ref fees2);
            // CalculateTuitionFee(2, 450, ref fees3);
            // CalculateTuitionFee(5, 700, ref fees4);
            // Console.WriteLine($"Fees1: {fees1:C}");
            // Console.WriteLine($"Fees2: {fees2:C}");
            // Console.WriteLine($"Fees3: {fees3:C}");
            // Console.WriteLine($"Fees4: {fees4:C}");
            //====================================================================

            //Q4
            /*
            Write a method that takes four parameter of type int.
            The method will assign the sum of the first two arguments to the third and the difference of the first two to the fourth.
            This method should be coded so that the calling method will use the value of the third and fourth parameters. [Do not use the Math.Abs() method.]
            Call this method about three times and print out the value of the four parameters after each method call.
            */
            // int sum, dif;
            // ValueFourParameters(3, 5, out sum, out dif);
            // Console.WriteLine($"Sum: {sum}, Dif: {dif}");
            //====================================================================

            //Q5
            /*
            Write a method with header static void CalculateTrigValues
            (double degrees, out double sine, out double cosine, out double tangent).
            The method will use the first argument to compute the values of the other three arguments.
            Used the method Math.Sin, Math.Cos and Math.Tan to compute the second to fourth arguments respectively.
            [radians = degrees * Math.Pi /180].
            In the Main() method, invoke this method 20 times with the first argument taking the values 0, 5, 10, … 95 and display the four arguments in a professional tabular format.
            The argument is taken as degrees.
            */
            // double degrees = 0;
            // for (int i = 0; i < 20; i++)
            // {
            //     double sine, cosine, tangent;

            //     CalculateTrigValues(degrees, out sine, out cosine, out tangent);
            //     Console.WriteLine($"{degrees} | {sine:F4} | {cosine:F4} | {tangent:F4}");

            //     degrees += 5;
            // }
            //====================================================================

            //Q6
            /*
            Write a method that takes three parameters of type double: the first represents an angle, the other two represents the sine and cosine of the angle respectively.
            The method must be able to change the actual value of the second and third argument.
            In your Main() method, call this method ten times with values 0.50, 0.51, 0.52 … 0.59 and
            printout the values for angle, sine and cosine in a tabular format.

            The argument is taken as radians.
            */
            // double sine = 0, cosine = 0;
            // for (double i = 0.50; i < 0.60; i += 0.01)
            // {
            //     ValuesAngleSineCosine(i, ref sine, ref cosine);
            //     Console.WriteLine($"{i:F2} | {sine:F4} | {cosine:F4}");
            // }
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
        public static void CubeIt(int x, ref int cube)
        {
            cube = x * x * x;
        }
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
        public static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees)
        {
            fees = numberOfCourses * costPerCourse + 15.25;
        }
        #endregion

        #region Q4_ValueFourParameters
        /*
        Write a method that takes four parameter of type int.
        The method will assign the sum of the first two arguments to the third and the difference of the first two to the fourth.
        This method should be coded so that the calling method will use the value of the third and fourth parameters. [Do not use the Math.Abs() method.]
        Call this method about three times and print out the value of the four parameters after each method call.
        */
        public static void ValueFourParameters (int num1, int num2, out int sum, out int dif)
        {
            sum = num1 + num2;
            dif = num1 - num2;
        }
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
        public static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent)
        {
            double radians = degrees * Math.PI /180;
            sine = Math.Sin(radians);
            cosine = Math.Cos(radians);
            tangent = Math.Tan(radians);
        }
        #endregion

        #region Q6_ValuesAngleSineCosine
        /*
        Write a method that takes three parameters of type double: the first represents an angle, the other two represents the sine and cosine of the angle respectively.
        The method must be able to change the actual value of the second and third argument.
        In your Main() method, call this method ten times with values 0.50, 0.51, 0.52 … 0.59 and
        printout the values for angle, sine and cosine in a tabular format.

        The argument is taken as radians.
        */
        public static void ValuesAngleSineCosine(double angle, ref double sine, ref double cosine)
        {
            sine = Math.Sin(angle);
            cosine = Math.Cos(angle);
        }
        #endregion
    }
}

