using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P8
        {
            public P8()
            {
                float max;
                float min;

                Console.Write("Please enter your first number here: ");
                float x = Convert.ToSingle(Console.ReadLine());

                Console.Write("Please enter your second number here: ");
                float y = Convert.ToSingle(Console.ReadLine());
                
                Console.Write("Please enter your third number here: ");
                float z = Convert.ToSingle(Console.ReadLine());

                max = x > y ? x : y;
                max = z > max ? z : max;

                min = x < y ? x : y;
                min = z < min ? z : min;

                float middle;
                middle = x == min || x == max ? 0f : x;
                middle = y == min || y == max ? middle : y;
                middle = z == min || z == max ? middle : z;

                Console.Write("Numbers from minimum to maximum are: ");
                Console.Write("{0}, {1}, {2}", min, middle, max);

            }
        }
    }
}


