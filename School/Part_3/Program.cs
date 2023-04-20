using System;

namespace Part_III
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q3
            // Console.WriteLine($"{CalculateTuitionFee(3):C}");
            // Console.WriteLine($"{CalculateTuitionFee(5):C}");
            // Console.WriteLine($"{CalculateTuitionFee(4, 500):C}");
            // Console.WriteLine($"{CalculateTuitionFee(2, 399):C}");
            //====================================================================

            //Q4
            // Console.WriteLine($"{CalculateCommission(900):C}");
            // Console.WriteLine($"{CalculateCommission(1000):C}");
            // Console.WriteLine($"{CalculateCommission(1001):C}");
            // Console.WriteLine($"{CalculateCommission(2000):C}");
            //====================================================================

            //Q5
            // Console.WriteLine($"{CalculateBurgerPrice():C}");
            // Console.WriteLine($"{CalculateBurgerPrice():C}");
            //====================================================================

            //Q6
            // double earth = 5.972e24, moon = 7.348e22, distance = 384400000;
            // double force = CalculateGravitationalAttraction(earth, moon, distance);
            // Console.WriteLine($"{force:e3} N");  
            //====================================================================

            //Q7
            // Console.WriteLine($"{CalculateAreaTriangle(5.83, 4.24, 8.00):F2}");
            //====================================================================

            //Q8
            // Console.WriteLine($"Celsius: 0, Fahrenheit: {ConvertCelsiusToFahrenheit(0)}");
            // Console.WriteLine($"Celsius: 51, Fahrenheit: {ConvertCelsiusToFahrenheit(51)}");
            // Console.WriteLine($"Celsius: 100, Fahrenheit: {ConvertCelsiusToFahrenheit(100)}");
            //====================================================================

            //Q9
            // Console.WriteLine($"Fahrenheit: 0, Celsius: {ConvertFahrenheitToCelsius(0):N1}");
            // Console.WriteLine($"Fahrenheit: 123.8, Celsius: {ConvertFahrenheitToCelsius(123.8)}");
            // Console.WriteLine($"Fahrenheit: 212, Celsius: {ConvertFahrenheitToCelsius(212)}");
            //====================================================================

            //10
            // Console.WriteLine($"Celsius: -196, Kelvin: {ConvertCelsiusToKelvin(-196)}");
            // Console.WriteLine($"Celsius: 0, Kelvin: {ConvertCelsiusToKelvin(0)}");
            // Console.WriteLine($"Celsius: 100, Kelvin: {ConvertCelsiusToKelvin(100)}");
            //====================================================================

            //11
            // Console.WriteLine($"Fahrenheit: 32, Kelvin: {ConvertFahrenheitToKelvin(32)}");
            // Console.WriteLine($"Fahrenheit: 68, Kelvin: {ConvertFahrenheitToKelvin(68)}");
            // Console.WriteLine($"Fahrenheit: -41, Kelvin: {ConvertFahrenheitToKelvin(-41)}");
            //====================================================================
        }

        #region Q3_CalculateTuitionFee
        /*
        Write a method called CalculateTuitionFee(int numberOfCourses, double costPerCourse = 449.99).
        This method will calculate and return the required fees amount.
        [Fees = number of courses * cost per course + 15.25].
        Call the CalculateTuitionFee() method four times from your program Main() method supplying different arguments each time.
        */
        public static double CalculateTuitionFee(int numberOfCourses, double costPerCourse = 449.99)
        {
            double fee = numberOfCourses * costPerCourse + 15.25;

            return fee;
        }
        #endregion

        #region Q4_CalculateCommission
        /*
        Write a method called CalculateCommission(double saleAmount).
        This method will calculate and return a sales representation’s commission.
        [over $1000 the commission will be 1%].
        Call the CalculateCommission() method three times from your program Main() method, supplying arguments 900, 1000, 1001 and 2000.
        */
        public static double CalculateCommission(double saleAmount)
        {
            double commission = 0;

            if (saleAmount > 1000)
            {
                commission = 0.01;
            }

            double totalCommission = saleAmount * commission;
            return totalCommission;
        }
        #endregion

        #region Q5_CalculateBurgerPrice
        /*
        Write a method that does not take any argument.
        The method will prompt the user for the number of burgers that he wants to buy.
        The method will calculate and return the amount of money that will be required.
        [One burger cost $1.39].
        From your program Main() method, call the above method two times.
        */
        public static double CalculateBurgerPrice()
        {
            Console.Write("Enter the number of burgers: ");
            int numBurger = Convert.ToInt32(Console.ReadLine());

            double amount = numBurger * 1.39;

            return amount;
        }
        #endregion

        #region Q6_CalculateGravitationalAttraction
        /*
        “Newton's law of universal gravitation states that every point mass in the universe attracts every other point mass with a force that is directly proportional to the product of their masses and inversely proportional to the square of the distance between them.”

        Write a method called CalculateGravitationalAttraction() that takes three double arguments (masses of the two bodies and the distance between them).
        The method will calculate and return the force of attraction between them.
        [F = G (m_1 m_2)/d^2  , where G = 6.673 x 10^-11].
        In your main call this method with the masses of the earth, moon and the distance between them and display the resulting force.
        Mass of Earth = 5.972 × 10^24, moon = 7.348 × 10^22, Distance = 384,400000m. [Answer 1.982 x (10^20)N] -> 1.982e20 N

        Use the e symbol to specify very large or very small values: double G = 6.673e-11;       
        */
        public static double CalculateGravitationalAttraction(double mass1, double mass2, double distance)
        {
            double G = 6.673e-11;
            double F = G * (mass1 * mass2) / (distance * distance);

            return F;
        }
        #endregion

        #region Q7_CalculateAreaTriangle
        /*
        Heron’s formula allows you to calculate the area of any triangle given the length of the three sides.
        Write a method that takes the length of the three sides and return the area of the specified triangle.
        A = √{s(s-a)(s-b)(s-c)} where s = (a+b+c)/2.
        In your main call this method with arguments 5.83, 4.24 and 8.00, and display the area.
        [Answer = 11.99].
        */
        public static double CalculateAreaTriangle(double length1, double length2, double length3)
        {
            double s = (length1 + length2 + length3)/2;
            double area = Math.Sqrt(s * (s-length1) * (s-length2) * (s-length3));

            return area;
        }
        #endregion

        #region Q8_ConvertCelsiusToFahrenheit
        /*
        Write a method called ConvertCelsiusToFahrenheit that takes a double argument.
        The method will calculate and return the Fahrenheit equivalent of the argument.
        [F = C * 9 / 5 + 32].
        In your main call this method three times with arguments 0, 51 and 100 respectively and display the results.
        */
        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = celsius * 9.0 / 5.0 + 32;

            return fahrenheit;
        }
        #endregion

        #region Q9_ConvertFahrenheitToCelsius
        /*
        Write a method called ConvertFahrenheitToCelsius that takes a double argument.
        The method will calculate and return the Celsius equivalent of the argument.
        [C = (F – 32) * 5 / 9].
        In your main call this method three times with arguments 0, 123.8 and 212 respectively and display the results.
        */
        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5.0 / 9.0;

            return celsius;
        }
        #endregion

        #region Q10_ConvertCelsiusToKelvin
        /*
        Write a method called ConvertCelsiusToKelvin that takes a double argument.
        The method will calculate and return the Kelvin equivalent of the argument.
        [K = C + 273.15].
        In your main call this method three times with arguments -196, 0 and 100 respectively and display the results.
        */
        public static double ConvertCelsiusToKelvin(double c)
        {
            double kelvin = c + 273.15;

            return kelvin;
        }
        #endregion

        #region Q11_ConvertFahrenheitToKelvin
        /*
        Write a method call ConvertFahrenheitToKelvin that takes a double argument.
        The method will calculate and return the Kelvin equivalent of the argument.
        [DO NOT RE-CODE THIS METHOD. Use the two previous methods to assist in your computation].
        In your main call this method three times and display the results.
        */
        public static double ConvertFahrenheitToKelvin(double fahrenheit)
        {
            double celsius = ConvertFahrenheitToCelsius(fahrenheit);
            double kelvin = ConvertCelsiusToKelvin(celsius);

            return kelvin;
        }
        #endregion
    }
}