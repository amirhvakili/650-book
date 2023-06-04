﻿namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P1_1
        {
            public int n { get; set; }
            public List<float> Average;

            public float max1 = 0f;
            public float max2 = 0f;
            public P1_1()
            {
                Console.Write("Please enter the number of students here: ");
                this.n = Convert.ToInt32(Console.ReadLine());
                this.Average = new List<float>();

                for (var i = 0; i < this.n; i++)
                {
                    Console.Write("Enter id: ");
                    var id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter average: ");
                    var average = Convert.ToSingle(Console.ReadLine());

                    Average.Add(id);
                    Average.Add(average);

                    if (average > max1)
                    {
                        max2 = max1;
                        max1 = average;
                    }
                    else if (average > max2 && average < max1)
                    {
                        max2 = average;
                    }
                }
            }
        }
    }
}


