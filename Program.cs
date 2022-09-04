using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            Console.WriteLine("Please enter a number greater than 0 for the imaginary coordinate: ");
            string str1 = Console.ReadLine();
            double imagNum = Convert.ToDouble(str1);
            if(imagNum < 0)
            {
                Console.WriteLine("Number not greater than 0, please enter a number that is: ");
                str1 = Console.ReadLine();
                imagNum = Convert.ToDouble(str1);
            }
            Console.WriteLine("Please enter a number less than 0 for the real coordinate: ");
            string str2 = Console.ReadLine();
            double realNum = Convert.ToDouble(str2);
            if (realNum > 0)
            {
                Console.WriteLine("Number not less than 0, please enter a number that is: ");
                str2 = Console.ReadLine();
                realNum = Convert.ToDouble(str2);
            }
            
            for (imagCoord = imagNum; imagCoord >= -imagNum; imagCoord -= imagNum/48)
            {
                for (realCoord = realNum+realNum; realCoord <= realNum*-80; realCoord += -realNum)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }
            
        }
    }
}
