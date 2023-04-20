using System;
/*
Name     : 
Date     : 
Student #: 
*/
namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            // ShowMenu();
            //=================================================================

            //Q2
            /* 
            * In your Main() method, using a suitable looping structure, write the 
            * code to call this method repeatedly. 
            * Using a suitable branching structure, write the code to implement the 
            * following required functionality for all valid responses.
            * Valid responses includes both upper and lower case of the input. The 
            * following must be implemented:
            * a will call the DemoQuestion3() method
            * b will call the DemoQuestion4() method
            * c will call the DemoQuestion5() method
            * d will call the DemoQuestion6() method
            * x will terminate the program
            * Any other key will produce an error message
            * 
            * YOU DON'T HAVE TO CREATE A NEW METHOD FOR THIS QUESTION
            */
            string choice;          
            do
            {
                ShowMenu();
                choice = Console.ReadLine();
                Console.WriteLine(" ");

                switch (choice.ToLower())
                {
                    case "a":
                        double earth = 5.972E24, moon = 7.348E22, d = 3.844E8;
                        Console.WriteLine("\n\n**********Begin Question 3 **********");
                        Console.WriteLine($"Mass of earth: {earth:E6}kg");
                        Console.WriteLine($"Mass of the moon: {moon:E6}kg");
                        Console.WriteLine($"The distance between them: {d:E6}m");
                        Console.WriteLine($"The force of attraction: {CalculateGravitationalAttraction(earth, moon, d):E6}N"); 
                        Console.WriteLine("\n**********End Question 3 **********\n\n");
                        break;                    
                    case "b":
                        Console.WriteLine("\n\n**********Begin Question 4 **********");
                        HeightConversion(75);
                        HeightConversion(100);
                        HeightConversion(290);
                        Console.WriteLine("\n\n**********End Question 4 **********\n\n");
                        break;                    
                    case "c":
                        Console.WriteLine("\n\n**********Begin Question 5 **********");
                        Console.WriteLine("Angle  Sine     Cosine");
                        double sine = 0, cosine = 0;
                        for (double i = 0.50; i < 0.6; i += 0.01)
                        {
                            SineCosine(i, ref sine, ref cosine);
                            Console.WriteLine($"{i:F2} {sine,8:F4} {cosine,8:F4}");
                        }
                        Console.WriteLine("\n**********End Question 5 **********\n\n");
                        break;                    
                    case "d":
                        Console.WriteLine("\n\n**********End Question 6 **********");
                        int[] randomArr = GenerateRandomIntArray(10 ,99);
                        DisplayIntArray(randomArr);
                        Console.WriteLine(" ");
                        int[] numFrequency = CalculateNumberFrequencies(randomArr);
                        DisplayIntArray(numFrequency);
                        Console.WriteLine("\n**********End Question 6 **********\n\n");
                        break;                    
                    case "x":
                        Console.WriteLine("Ended");
                        break;  
                    default:
                        Console.WriteLine("Errors");          
                        break;       
                }
            } while (choice != "x");
            //=================================================================

            //Q3
            /* Driver for question 3 - 6 marks
            * 
            * Write the statements to call the above method with the masses of the earth, 
            * moon and the distance between them and display the resulting force. 
            * 
            * 	Mass of Earth = 5.972E24, moon = 7.348E22, Distance = 3.844E8.
            * 	[Answer 1.99e020]
            * 	You should use E as a format specifier in your output
            */
            /*
            **********Begin Question 3 **********
            Mass of earth: 5.972000e+024kg 
            Mass of the moon:7.348000e+022kg 
            The distance between them:3.844000e+008m 
            The force of attraction:1.981725e+020N

            **********End Question 3 **********
            */
            // double earth = 5.972E24, moon = 7.348E22, d = 3.844E8;
            // Console.WriteLine("\n\n**********Begin Question 3 **********");
            // Console.WriteLine($"Mass of earth: {earth:E6}kg");
            // Console.WriteLine($"Mass of the moon: {moon:E6}kg");
            // Console.WriteLine($"The distance between them: {d:E6}m");
            // Console.WriteLine($"The force of attraction: {CalculateGravitationalAttraction(earth, moon, d):E6}N"); 
            // Console.WriteLine("\n**********End Question 3 **********\n\n");          
            //=================================================================

            //Q4
            /*
            **********Begin Question 4 **********
            75cm 0m 75cm
            100cm 1m 0cm
            290cm 2m 90cm

            **********End Question 4 **********
            */
            // Console.WriteLine("\n\n**********Begin Question 4 **********");
            // HeightConversion(75);
            // HeightConversion(100);
            // HeightConversion(290);
            // Console.WriteLine("\n\n**********End Question 4 **********\n\n");
            //=================================================================

            //Q5
            /* Driver for question 5 - 8 marks 
            * Write the code statements to call this method ten times with values 
            * 0.500, 0.501, 0.502 … 0.509  and printout the values for angle, 
            * sine and cosine in a tabular format. It is expected to use some
            * kind of repetitive structure
            */
            /*
            **********Begin Question 5 **********
            Angle  Sine     Cosine
            0.50   0.4794   0.8776
            0.51   0.4882   0.8727
            0.52   0.4969   0.8678
            0.53   0.5055   0.8628
            0.54   0.5141   0.8577
            0.55   0.5227   0.8525
            0.56   0.5312   0.8473
            0.57   0.5396   0.8419
            0.58   0.5480   0.8365
            0.59   0.5564   0.8309

            **********End Question 5 **********
            */
            // Console.WriteLine("\n\n**********Begin Question 5 **********");
            // Console.WriteLine("Angle  Sine     Cosine");
            // double sine = 0, cosine = 0;
            // for (double i = 0.50; i < 0.6; i += 0.01)
            // {
            //     SineCosine(i, ref sine, ref cosine);
            //     Console.WriteLine($"{i:F2} {sine,8:F4} {cosine,8:F4}");
            // }
            // Console.WriteLine("\n**********End Question 5 **********\n\n");
            //=================================================================

            //Q6
            /* Driver for Question 6 - 7 marks
            * Write the code to do the following:
            *   Call the GenerateRandomIntArray() and assign the results to a suitable variable
            *   Use the DisplayIntArray() method to display the above variable
            *   Print an empty line
            *   Call CalculateNumberFrequencies() method and display the resulting value
            */
            /*
            **********End Question 6 **********
            31 38 96 94 27 85 36 26 15 12 29  9 22 54  0 53 47 43 90 52
            2  2  4  3  2  3  0  0  1  3
            **********End Question 6 **********
            */
            // Console.WriteLine("\n\n**********End Question 6 **********");
            // int[] randomArr = GenerateRandomIntArray(10 ,99);
            // DisplayIntArray(randomArr);
            // Console.WriteLine(" ");
            // int[] numFrequency = CalculateNumberFrequencies(randomArr);
            // DisplayIntArray(numFrequency);
            // Console.WriteLine("\n**********End Question 6 **********\n\n");
            //=================================================================
        }
        
        #region Question 1 - 13 marks
        /* 
         * Write a method that does not take any argument nor does it
         * return a value. The method only displays the following text.
         * 
         * YOU MUST INSERT YOUR NAME IN THE TOP LINE OF THE MENU 
         * 
         * +---------------------COMP100------------------------+
         * |           a) Working with Newton's Law             |
         * |           b) Height Converter                      |
         * |           c) Sine and Cosine Table                 |
         * |           d) Number Frequency                      |
         * |                                                    |
         * |           x) To exit the program                   |
         * +----------------------------------------------------+
         * Press the letter corresponding to your choice-> 
         * 
         */
        public static void ShowMenu()
        {
            Console.WriteLine("+---------------------COMP100------------------------+");
            Console.WriteLine("|           a) Working with Newton's Law             |");
            Console.WriteLine("|           b) Height Converter                      |");
            Console.WriteLine("|           c) Sine and Cosine Table                 |");
            Console.WriteLine("|           d) Number Frequency                      |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|           x) To exit the program                   |");
            Console.WriteLine("+----------------------------------------------------+");
            Console.Write("Press the letter corresponding to your choice -> ");
        }
        #endregion

        #region Question 2 - 26 marks
        /* 
         * In your Main() method, using a suitable looping structure, write the 
         * code to call this method repeatedly. 
         * Using a suitable branching structure, write the code to implement the 
         * following required functionality for all valid responses.
         * Valid responses includes both upper and lower case of the input. The 
         * following must be implemented:
         * a will call the DemoQuestion3() method
         * b will call the DemoQuestion4() method
         * c will call the DemoQuestion5() method
         * d will call the DemoQuestion6() method
         * x will terminate the program
         * Any other key will produce an error message
         * 
         * YOU DON'T HAVE TO CREATE A NEW METHOD FOR THIS QUESTION
         */
        #endregion

        #region Question 3 - 15 marks
        /*  CalculateGravitationalForce - 9 marks
         * 	“Newton's law of universal gravitation states that every point mass in the 
         * 	universe attracts every other point mass with a force that is directly 
         * 	proportional to the product of their masses and inversely proportional to 
         * 	the square of the distance between them.” 
         * 	
         * Write a method with the following specifications:
         * Name     : CalculateGravitationalAttraction
         * Parameter: 
         * 	          A double representing the mass of the first body
         * 	          A double representing the mass of the second body
         * 	          A double representing the distance between them. 
         * Returns  : a double representing the attractive force between the bodies
         * Displays : Nothing
         * Task     : Calculate and return the force of attraction between them. 
         * 	[F=G (m_1 m_2)/d^2  , where G = 6.673e-11]. See word file for equation
         */

        /* Driver for question 3 - 6 marks
         * 
         * Write the statements to call the above method with the masses of the earth, 
         * moon and the distance between them and display the resulting force. 
         * 
         * 	Mass of Earth = 5.972E24, moon = 7.348E22, Distance = 3.844E8.
         * 	[Answer 1.99e020]
         * 	You should use E as a format specifier in your output
         */
        static double CalculateGravitationalAttraction(double mass1, double mass2, double d)
        {
            //code for invoking question 3 goes here
            double G = 6.673e-11;
            double F = G * (mass1 * mass2) / (d * d);
            
            return F;
        }
        #endregion

        #region Question 4 - 10 marks
        /* Write a method with the following specifications: - 9 marks
         * Name     : HeightConversion
         * Parameter: an int representing the height value in cm
         * Returns  : Nothing
         * Displays : the meter and  centimeter equivalent
         * Tasks: Converts the argument to metres and cm and display
         * it on the console. 
         */

        /* Driver for question 4 - 3 marks
         * Write the code to call the above method below three times
         * with argument 75, 100 and 290.
         */
        /*
        **********Begin Question 4 **********
        75cm 0m 75cm
        100cm 1m 0cm
        290cm 2m 90cm

        **********End Question 4 **********
        */
        static void HeightConversion(int height)
        {            
            //code for invoking question 4  here
            int mt = height / 100;
            int cm = height % 100;

            Console.WriteLine($"{height}cm {mt}m {cm}cm");      
        }
        #endregion

        #region Question 5 - 18 marks
        /* SineCosine - 10 marks
         * Write a method with the following specifications:
         * Name     : SineCosine
         * Parameter: 
         *           A double that represents an angle in radians
         *           A double that represents the sine to the first argument
         *           A double that represents the cosine of the first argument
         * Returns  : Nothing
         * Displays : Nothing
         * Task     : Calculates the sine and cosine of the first argument and
         * assigns the result values to the second and third Parameter
         * 
         * NOTE: the second and three arguments are decorated so that the 
         * method is able to change the actual value of the variable
         */
        /* Driver for question 5 - 8 marks 
         * Write the code statements to call this method ten times with values 
         * 0.500, 0.501, 0.502 … 0.509  and printout the values for angle, 
         * sine and cosine in a tabular format. It is expected to use some
         * kind of repetitive structure
         */
        /*
        **********Begin Question 5 **********
        Angle  Sine     Cosine
        0.50   0.4794   0.8776
        0.51   0.4882   0.8727
        0.52   0.4969   0.8678
        0.53   0.5055   0.8628
        0.54   0.5141   0.8577
        0.55   0.5227   0.8525
        0.56   0.5312   0.8473
        0.57   0.5396   0.8419
        0.58   0.5480   0.8365
        0.59   0.5564   0.8309

        **********End Question 5 **********
        */
        static void SineCosine(double angle, ref double sine, ref double cosine)
        {
            sine = Math.Sin(angle);
            cosine = Math.Cos(angle);
        }
        #endregion

        #region Question 6 - 20 marks
        /* Write a method with the following specifications: //13 marks
         * Name: CalculateNumberFrequencies
         * Argument: an int array with values ranging from 0 to 99
         * Returns: int array of 10 integers. The first element will 
         *          indicate the number or unit values in the argument 
         *          (i.e. values 0-9), the second element will indicate 
         *          the number of 10 values (i.e. values 10-19), the 
         *          third element will indicate the number of 20 values 
         *          (i.e. values 20-29) etc.
         * Display: Nothing
         * Tasks  : The method will create an int array of 10 elements 
         *          (call this the result). 
         *          Each item of the argument is examined and the 
         *          appropriate element of the result array is incremented. 
         */
        /* Driver for Question 6 - 7 marks
         * Write the code to do the following:
         *   Call the GenerateRandomIntArray() and assign the results to a suitable variable
         *   Use the DisplayIntArray() method to display the above variable
         *   Print an empty line
         *   Call CalculateNumberFrequencies() method and display the resulting value
         */
        /*
        **********End Question 6 **********
        31 38 96 94 27 85 36 26 15 12 29  9 22 54  0 53 47 43 90 52
        2  2  4  3  2  3  0  0  1  3
        **********End Question 6 **********
        */
        static int[] CalculateNumberFrequencies(int[] array)
        {
            int[] result = new int[10];

            foreach (int num in array)
            {
                int numValue = num / 10;
                result[numValue]++;
            }
            return result;
        }
        /*
         * FREE CODE
         */
        static void DisplayIntArray(int[] numbers)
        {
            foreach (var x in numbers)
                Console.Write($"{x,3}");
        }
        /*
         * FREE CODE
         */
        static int[] GenerateRandomIntArray(int numberOfItems, int largestValue)
        {
            int[] result = new int[numberOfItems];
            Random generator = new Random();
            for (int i = 0; i < numberOfItems; i++)
                result[i] = generator.Next(largestValue);
            return result;
        }
        #endregion
    }
}
