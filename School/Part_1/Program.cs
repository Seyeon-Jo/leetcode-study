using System;
using System.Xml.Linq;

namespace Part_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            // DisplayPersonalInfo();
            //====================================================================

            //Q2
            // CalculateTuition();
            // CalculateTuition();
            //====================================================================

            //Q3
            // CalculateAreaOfCircle();
            // CalculateAreaOfCircle();
            //====================================================================

            //Q4
            // CalculateAreaOfTriangle();
            // CalculateAreaOfTriangle();
            //====================================================================

            //Q5
            // CalculateSaleCommission();
            //====================================================================

            //Q6
            // DisplaySineTable();
            //====================================================================

            //Q7
            // DisplayMenu();
            //====================================================================

            //Q8
            // ShowMenu();
            //====================================================================
        }

        #region Q1_DisplayPersonInfo
        /*
        Write a method called DisplayPersonalInfo().
        This method will display your name, school, program and your favorite course.
        Call the DisplayPersonalInfo() method from your program Main() method.

        You invoke a method by its name followed by a pair of brackets and the usual semi-colon.
        */
        public static void DisplayPersonalInfo()
        {
            Console.WriteLine("Name: 세연");
            Console.WriteLine("School: Centennial College");
            Console.WriteLine("Program: Software Engineering Technology");
            Console.WriteLine("Favorite course: Programming");
        }
        #endregion

        #region Q2_CalculateTuition
        /*
        Write a method called CalculateTuition().
        This method will prompt the user for the number of courses that she is currently taking
        and then calculate and display the tuition cost. (cost = number of course * 569.99).
        Call the CalculateTuition() method two times from the same Main() method as in question 1.
        */
        public static void CalculateTuition()
        {
            Console.Write("Enter the number of courses: ");
            int numCourse = Convert.ToInt32(Console.ReadLine());

            double cost = numCourse * 569.99;

            Console.WriteLine($"The tuition cost is {cost:C}");
        }
        #endregion

        #region Q3_CalculateAreaOfCircle
        /*
        Write a method call CalculateAreaOfCircle().
        This method will prompt the user for the radius of a circle
        and then calculate and display the area.[A = πr^2].
        Call the CalculateAreaOfCircle() method twice from the same Main() method as in question 1.
        Use Math.Pi for the value of π
        */
        public static void CalculateAreaOfCircle()
        {
            Console.Write("Enter the radius of a circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine($"The area of a circle is {area}");
        }
        #endregion

        #region Q4_CalculateAreaOfTriangle
        /*
        Write a method call CalculateAreaOfTriangle(), that prompts the user for the base and height of a triangle
        and then calculate and display the area.[ A = bt/2 ]
        Call the CalculateAreaOfTriangle() method twice from the same Main() method as in question 1.
        */
        public static void CalculateAreaOfTriangle()
        {
            Console.Write("Enter the base of a triangle: ");
            double baseT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of a triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = (baseT * height) / 2;

            Console.WriteLine($"The area of a triangle is {area}");
        }
        #endregion

        #region Q5_CalculateSaleCommission
        /*
        Write a method call CalculateSaleCommission(), that prompts the user for his sales figure,
        and then calculate and display his commission. (commission = 25% of sales in excess of 1000. If sales is equal to or below $1000.00 there is no commission)
        Call the CalculateSaleCommission() method three times from the same Main() method as in question 1.
        */
        public static void CalculateSaleCommission()
        {
            Console.Write("Enter the sales figure: ");
            double salesFigure = Convert.ToDouble(Console.ReadLine());

            double commission = 0;

            if (salesFigure > 1000)
            {
                commission = (salesFigure - 1000) * 0.25;
            }

            Console.WriteLine($"The commission of sales figure is {commission}");
        }
        #endregion

        #region Q6_DisplaySineTable
        /*
        Write a method call DisplaySineTable(), that prompts the user for a starting value and an step size.
        The method will calculate and display a table (10 rows) of sine values based on the user input.
        Use the built-in method Math.Sin() to obtain the sine of an angle.

        e.g. if the starting value is 0.5 and the step size is 0.03 the method will display the following table:
        0.50	0.4794
        0.53	0.5055
        0.56	0.5311

        0.77	0.6961

        The numbers in both columns MUST be right aligned.
        Call the DisplaySineTable() method from the same Main() method as in question 1.
        */
        public static void DisplaySineTable()
        {
            Console.Write("Enter the starting value: ");
            double start = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the step size: ");
            double step = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine(" Input | Sine Value ");    
            Console.WriteLine("====================");

            for (int i = 0; i < 10; i ++)
            {
                double sin = Math.Sin(start);

                Console.WriteLine($"{start,6:F2} | {sin,10:F4}");

                start += step;
            }
        }
        #endregion

        #region Q7_DisplayMenu
        /*
        In a write a method called DisplayMenu() to display the following text on screen:

        ==================Computer Systems====================
        |       1. Display My Personal Information           |
        |       2. Calculate Tuition                         |
        |       3. Calculate Area Of A Circle                |
        |       4. Calculate the Area Of A Triangle          |
        |       5. Calculate Sales Commission                |
        |       6. Display Sine Table                        |
        |       0. End program                               |
        |                                                    |
        ======================================================
                Enter the number of your choice ->

        You may replace the instructor’s name with your name.
        */
        public static void DisplayMenu()
        {
            Console.WriteLine("================== Computer Systems ==================");
            Console.WriteLine("|       1. Display My Personal Information           |");
            Console.WriteLine("|       2. Calculate Tuition                         |");
            Console.WriteLine("|       3. Calculate Area Of A Circle                |");
            Console.WriteLine("|       4. Calculate the Area Of A Triangle          |");
            Console.WriteLine("|       5. Calculate Sales Commission                |");
            Console.WriteLine("|       6. Display Sine Table                        |");
            Console.WriteLine("|       0. End program                               |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("======================================================");
            Console.Write("Enter the number of your choice: ");
        }
        #endregion

        #region Q8_ShowMenu
        /*
        Add another method called ShowMenu() to your project.
        This method will call the method in question 7 continuously until the user presses 0.
        (You will have to invoke the method in a loop body, read in the user input as well as check the input).
        You will need to hook up all the methods that you wrote previously (i.e. questions 1 to 6).
        Replace all the code from your Main() method with a single call to the ShowMenu() method.
        */
        public static void ShowMenu()
        {
            int inputNum;
            do
            {
                DisplayMenu();
                inputNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                switch (inputNum)
                {
                    case 1:
                        DisplayPersonalInfo();
                        break;
                    case 2:
                        CalculateTuition();
                        break;
                    case 3:
                        CalculateAreaOfCircle();
                        break;
                    case 4:
                        CalculateAreaOfTriangle();
                        break;
                    case 5:
                        CalculateSaleCommission();
                        break;
                    case 6:
                        DisplaySineTable();
                        break;
                    case 0:
                        Console.WriteLine("End");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                } 
                Console.WriteLine(" ");
            } while (inputNum != 0);
        }
        #endregion
    }
}

