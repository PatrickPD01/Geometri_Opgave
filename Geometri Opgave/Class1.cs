using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_Opgave
{
    public class Square
    {
        public int a;
        private double areaOfSquare;
        private double circumferenceOfSquare;

        public Square(int a)
        {
            // Creating an constructor which takes a as perimeter 
            this.a = a;
            int s, perimeter;

            // Prints an informative message, which invites the user to enter the side of the square a
            Console.Write("Side : ");

            // Reads an integer from the console.
            s = Convert.ToInt32(Console.ReadLine());

            // Keeps in a new variable area the result of the multiplication of a by a.
            perimeter = s * s;
            Console.WriteLine("Perimeter of Square : " + perimeter);
        }


    }
}
