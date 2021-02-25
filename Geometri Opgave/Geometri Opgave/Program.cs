using System;

namespace Geometri_Opgave
{
    class Program
    {

        static void Main(string[] args)
        {
            // Makes it possible for you to insert a specific length of the square
            Console.WriteLine("Enter length of square:");
            double squareLength = Convert.ToDouble(Console.ReadLine());

            // Calculates the area of the square
            double areaOfSquare = squareLength * squareLength;
            Console.WriteLine("Area of square is: " + areaOfSquare);


            // Calculates the circumference of the square
            double circumferenceOfSquare = squareLength * squareLength;
            Console.WriteLine("Circumference of square is: " + circumferenceOfSquare);
        }
    }
}
