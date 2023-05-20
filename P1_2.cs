namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P1_2
        {
            public int n { get; set; }

            public float max1 = 0f;
            public float max2 = 0f;

            public int id1 = 0;
            public int id2 = 0;
            public P1_2()
            {
                Console.Write("Please enter the number of students here: ");
                this.n = Convert.ToInt32(Console.ReadLine());

                for (var i = 0; i < this.n; i++)
                {
                    Console.Write("Enter id: ");
                    var id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter average: ");
                    var average = Convert.ToSingle(Console.ReadLine());

                    if (average > max1)
                    {
                        id2 = id1;
                        id1 = id;
                        max2 = max1;
                        max1 = average;
                    }
                    else if (average > max2 && average < max1)
                    {
                        id2 = id;
                        max2 = average;
                    }
                }
            }
        }
    }
}


