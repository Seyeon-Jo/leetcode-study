using System;

namespace Part_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            // DisplayHorizontalStars(0);
            // Console.WriteLine("");
            // DisplayHorizontalStars(5);
            // Console.WriteLine("");
            // DisplayHorizontalStars(10);
            //====================================================================

            //Q2
            // DisplayVerticalStars(0);
            // Console.WriteLine("");
            // DisplayVerticalStars(5);
            // Console.WriteLine("");
            // DisplayVerticalStars(10);
            //====================================================================

            //Q3
            // DisplayVolumeSphere(1);
            // DisplayVolumeSphere(2);
            // DisplayVolumeSphere(10);
            //====================================================================

            //Q4
            // DisplaySellingPrice(100, "ON");
            // DisplaySellingPrice(100, "QB");
            // DisplaySellingPrice(100, "BC");
            //====================================================================

            //Q5
            // DisplayCelsiusFahrenheit(2.3);
            // Console.WriteLine("");
            // DisplayCelsiusFahrenheit(2.5);
            //====================================================================

            //Q6
            // DisplayKilometerMiles(0, 1, 3);
            // Console.WriteLine("");
            // DisplayKilometerMiles(10, 2, 5);
            // Console.WriteLine("");
            // DisplayKilometerMiles(20, 3, 2);
            //====================================================================

            //Q7
            // ModifyDisplaySineTable(1, 2, 5);
            //====================================================================

            //Q8
            // ConvertCmToMcm(90);
            // ConvertCmToMcm(120);
            // ConvertCmToMcm(275);
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
        If there are multiple parameters, then they are separated by commas.
        */
        public static void DisplayHorizontalStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.Write("*");
            }
        }
        #endregion

        #region Q2_DisplayVerticalStars
        /*
        Write a method similar to the one above that displays a vertical line of stars.
        Call this method three times with arguments 0, 5 and 10 respectively.
        */
        public static void DisplayVerticalStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.WriteLine("*");
            }
        }
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
        public static void DisplayVolumeSphere(double radius)
        {
            double volume = Math.PI * 4/3 * radius * radius * radius;
            Console.WriteLine($"{volume:F4}");
        }
        #endregion

        #region Q4_DisplaySellingPrice
        /*
        Write a method that takes two arguments: a cost price and a two-letter province code.
        It will calculate and display the selling price.
        (If province is Ontario a tax of 13% is added to the price, if the province is Quebec a tax of 17% is added to the cost price. There is no tax for the rest of the provinces and territories).
        In your main, call this method enough times to fully test it.
        */
        public static void DisplaySellingPrice(double price, string code)
        {
            switch (code)
            {
                case "ON":
                    Console.WriteLine(price + (price * 0.13));
                    break;
                case "QB":
                    Console.WriteLine(price + (price * 0.17));
                    break;
                default:
                    Console.WriteLine(price);
                    break;
            }
        }
        #endregion

        #region Q5_DisplayCelsiusFahrenheit
        /*
        Write a method that takes a single argument of type double.
        The will display a Celsius to Fahrenheit conversion table.
        The starting temperature is indicated by the argument and it will display 10 lines in increments of 1.
        [Fahrenheit = 9/5 Celsius + 32]. 
        In your main call this method two times, each time with a different start value.
        */
        public static void DisplayCelsiusFahrenheit(double startValue)
        {
            Console.WriteLine("Celsius | Fahrenheit");
            Console.WriteLine("--------------------");

            for (int i = 0; i < 10; i++)
            {
                double celsius = startValue + i;
                double fahrenheit = 9.0 / 5.0 * celsius + 32;

                Console.WriteLine($"{celsius,7:F2} | {fahrenheit,10:F2}");
            }
        }
        #endregion

        #region Q6_DisplayKilometerMiles
        /*
        Write a method that takes the following arguments: a starting km value of type double, an increment size of type double and the number of lines of type int.
        The display a kilometer to miles conversion table. [miles = km * 0.621371].
        In your main call this method three times, each time with different values.
        */
        public static void DisplayKilometerMiles(double startKm, double increment, int numLines)
        {
            Console.WriteLine("kilometer | miles");
            Console.WriteLine("-----------------");

            for (int i = 0; i < numLines; i++)
            {
                double miles = startKm * 0.621371;

                Console.WriteLine($"{startKm,9:F2} | {miles,5:F2}");

                startKm += increment;
            }
        }
        #endregion

        #region Q7_ModifyDisplaySineTable
        /*
        Modify the DisplaySineTable() method in the previous section to accept the start value,
        the step size and number of rows as argument to the method.
        */
        public static void ModifyDisplaySineTable(double start, double step, int numRows)
        {
            Console.WriteLine("Input |    Sine");
            Console.WriteLine("---------------");

            for (int i = 0; i < numRows; i++)
            {
                double sine = Math.Sin(start);

                Console.WriteLine($"{start,5:F2} | {sine,7:F4}");

                start += step;
            }
        }
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
        public static void ConvertCmToMcm(int height)
        {
            int mt = height / 100;
            int cm = height % 100;

            Console.WriteLine($"{mt}m {cm}cm");
        }
        /* 만일 height이 double이라면, Math.Floor를 사용해서 작성할 수 있음!!!
        public static void ConvertCmToMcm(double height)
        {
            double mt = Math.Floor(height / 100);
            double cm = height % 100;

            Console.WriteLine($"{height}cm = {mt:F0}m {cm:F0}cm");
        } */
        #endregion
    }
}

