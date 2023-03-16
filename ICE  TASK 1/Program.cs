using System;

namespace ICE__TASK_1
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter number of scripts");
            int scripts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of questions");
            int questions = Convert.ToInt32(Console.ReadLine());

            int[] sub = new int[questions];
            for (int i = 0; i < questions; i++)
            {
                Console.WriteLine("Enter sub total for question: " + (i + 1));
                sub[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter number of lecturers");
            int lecturers = Convert.ToInt32(Console.ReadLine());

            int scriptsPerLec = scripts / lecturers;

            int minutes = 0;
            int seconds = 0;
            for (int i = 0; i < questions; i++)
            {
                for (int j = 0; j < sub[i]; j++)
                {
                    seconds += 2;
                    if (seconds == 60)
                    {
                        minutes++;
                        seconds = 0;
                    }
                }
            }

            if (seconds >= 30)
            {
                minutes++;
            }

            int totalMinutes = minutes * scriptsPerLec;
            int hours = 0;
            bool notHour = false;
            while (!notHour)
            {
                if (totalMinutes >= 60)
                {
                    hours++;
                    totalMinutes -= 60;
                }
                else
                {
                    notHour = true;
                }
            }

            Console.WriteLine("It will take each lecturer " + hours + " hours and " + totalMinutes + " minutes to mark " + scriptsPerLec + " Scripts");
        }
    }
}
