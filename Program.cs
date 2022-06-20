using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTechTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecuteClockTask();
            Console.WriteLine("==================================");
            ExecuteTreeTask();
            Console.ReadLine();
        }
        private static void ExecuteTreeTask()
        {
            var tree = new TreeTask();
            Console.WriteLine("Tree depth: {0}", tree.GetDepth());
        }
        private static void ExecuteClockTask()
        {
            int hours = InputHours();
            int minutes = InputMinutes();
            var task = new ClockTask(hours, minutes);
            double answer = task.GetCalculatedAnswer();
            Console.WriteLine("Lesser angle is: {0}", answer);
        }

        private static int InputHours()
        {
            Console.WriteLine("Please enter the hours in an analogoue format: number from 1 to 12");
            try
            {
                int temphours = int.Parse(Console.ReadLine());
                if (temphours >= 1 && temphours <= 12)
                {
                    return temphours;
                }
                else
                {
                    Console.WriteLine("Your input is not in range of an analogue range of hours, please input a number from 1 to 12");
                    return InputHours();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input is incorrect, make sure you are inputing in an analogue format, input only a number from 1 to 12");
                return InputHours();
            }
        }
        private static int InputMinutes()
        {
            Console.WriteLine("Please enter the minutes in an analogoue format: number from 0 to 59");
            try
            {
                int tempminutes = int.Parse(Console.ReadLine());
                if (tempminutes >= 0 && tempminutes <= 59)
                {
                    return tempminutes;
                }
                else
                {
                    Console.WriteLine("Your input is not in range of an analogue range of minutes, please input a number from 0 to 59");
                    return InputMinutes();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input is incorrect, make sure you are inputing in an analogue format, input only a number from 0 to 59");
                return InputMinutes();
            }
        }
    }
}
