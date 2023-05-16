namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P47
        {
            public float Miles { get; set; }
            public float Feet { get; set; }

            public const float Meters_Per_Miles = 1609.35f;
            public const float Meters_Per_Foot = 0.30480f;
            public P47()
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Please enter miles here: ");
                        this.Miles = float.Parse(Console.ReadLine());
                        if(this.Miles < 0)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a right input.");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Please enter feet here: ");
                        this.Feet = float.Parse(Console.ReadLine());
                        if (this.Feet < 0)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a right input.");
                    }
                }
            }
            public float MilesToMetersConversion()
            {
                return this.Miles * Meters_Per_Miles;
            }
            public float FeetToMetersConversion()
            {
                return this.Feet * Meters_Per_Foot;
            }
        }
    }
}


