namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P5
        {
            public P5()
            {

                var birthday = new DateTime(1348, 10, 04);
                var now = new DateTime(1396, 08, 28);
                var timespan = now - birthday;

                //Calculating Years
                int years;
                if(now.Month <= birthday.Month)
                    years = now.Year - birthday.Year - 1;
                else
                   years = now.Year - birthday.Year;
               
                //Calculating Months
                int months;
                if (now.Month <= birthday.Month)
                    months = 12 - birthday.Month + now.Month;
                else
                    months = now.Month - birthday.Month;

                //Calculating Days
                int days;
                if (now.Day > birthday.Day)
                    days = now.Day - birthday.Day;
                else
                {
                    months = months - 1;
                    days = 30 - birthday.Day + now.Day;
                }


                var hours = timespan.TotalHours;
                var minutes = timespan.TotalMinutes;
                var seconds = timespan.TotalSeconds;

                Console.WriteLine("{0}/{1}/{2}", years, months, days);
                Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);
            }
        }
    }
}


