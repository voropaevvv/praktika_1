using System;



namespace mathexamtask

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Type the x: ");

            string text = Console.ReadLine();

            double x = double.Parse(text);



            if (x < 4)

            {

                double y = (Math.Pow(x, 2) / 6) + (0.5);

                Console.WriteLine("Y: " + y);

            }

            else if (x >= 4 && x < 10)

            {

                double pi = Math.PI;

                for (int i = 4; i <= x; i++)

                {

                    double y = (0.25) * Math.Pow(x, 3);

                    Console.WriteLine("Y: " + y * pi);

                }

            }

            else

            {

                double summ = 0;

                double y = 0;

                for (int i = 4; i <= x; i++)

                {

                    summ += i * i;

                    y = 0.5 * summ * 3.5 * i;

                }

                Console.WriteLine("Y:" + y);

            }



        }

    }

}