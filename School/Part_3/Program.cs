using System;

namespace Part_III
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //Q9
            //====================================================================

            //10
            //====================================================================

            //11
            //====================================================================
        }

        #region Q3_CaculateTuitionFee
        /*
        Write a method called CaculateTuitionFee(int numberOfCourses, double costPerCourse = 449.99).
        This method will calculate and return the required fees amount.
        [Fees = number of courses * cost per course + 15.25].
        Call the CaculateTuitionFee() method four times from your program Main() method supplying different arguments each time.
        */

        #endregion

        #region Q4_CalculateCommission
        /*
        Write a method called CalculateCommission(double saleAmount).
        This method will calculate and return a sales representation’s commission.
        [over $1000 the commission will be 1%].
        Call the CalculateCommission() method three times from your program Main() method, supplying arguments 900, 1000, 1001 and 2000.
        */

        #endregion

        #region Q5_CalculateBurgerPrice
        /*
        Write a method that does not take any argument.
        The method will prompt the user for the number of burgers that he wants to buy.
        The method will calculate and return the amount of money that will be required.
        [One burger cost $1.39].
        From your program Main() method, call the above method two times.
        */

        #endregion

        #region Q6_CalculateGravitationalAttraction
        /*
        “Newton's law of universal gravitation states that every point mass in the universe attracts every other point mass with a force that is directly proportional to the product of their masses and inversely proportional to the square of the distance between them.”

        Write a method called CalculateGravitationalAttraction() that takes three double arguments (masses of the two bodies and the distance between them).
        The method will calculate and return the force of attraction between them.
        [F = G (m_1 m_2)/d^2  , where G = 6.673 x 10^-11].
        In your main call this method with the masses of the earth, moon and the distance between them and display the resulting force.
        Mass of Earth = 5.972 × 10^24, moon = 7.348 × 10^22, Distance = 384,400000m. [Answer 1.982 x (10^20)N]

        Use the e symbol to specify very large or very small values: double G = 6.673e-11;
        */

        #endregion

        #region Q7_CalculateAreaTriangle
        /*
        Heron’s formula allows you to calculate the area of any triangle given the length of the three sides.
        Write a method that takes the length of the three sides and return the area of the specified triangle.
        A = √{s(s-a)(s-b)(s-c)} where s = (a+b+c)/2.
        In your main call this method with arguments 5.83, 4.24 and 8.00, and display the area.
        [Answer = 11.99].
        */

        #endregion

        #region Q8_ConvertCelsiusToFahrenheit
        /*
        Write a method called ConvertCelsiusToFahrenheit that takes a double argument.
        The method will calculate and return the Fahrenheit equivalent of the argument.
        [F = C * 9 / 5 + 32].
        In your main call this method three times with arguments 0, 51 and 100 respectively and display the results.
        */

        #endregion

        #region Q9_ConvertFahrenheitToCelsius
        /*
        Write a method called ConvertFahrenheitToCelsius that takes a double argument.
        The method will calculate and return the Celsius equivalent of the argument.
        [C = (F – 32) * 5 / 9].
        In your main call this method three times with arguments 0, 123.8 and 212 respectively and display the results.
        */

        #endregion

        #region Q10_ConvertCelsiusToKelvin
        /*
        Write a method called ConvertCelsiusToKelvin that takes a double argument.
        The method will calculate and return the Kelvin equivalent of the argument.
        [K = C + 273.15].
        In your main call this method three times with arguments -196, 0 and 100 respectively and display the results.
        */

        #endregion

        #region Q11_ConvertFahrenheitToKelvin
        /*
        Write a method call ConvertFahrenheitToKelvin that takes a double argument.
        The method will calculate and return the Kelvin equivalent of the argument.
        [DO NOT RE-CODE THIS METHOD. Use the two previous methods to assist in your computation].
        In your main call this method three times and display the results.
        */

        #endregion
    }
}