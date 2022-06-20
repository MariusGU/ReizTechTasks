using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTechTasks
{
    internal class ClockTask
    {
        private int hours;
        private int minutes;
        private double answer;
        public ClockTask(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
            answer = Calculate();
        }
        private double Calculate()
        {
            double minutesDegrees = minutes * 6;

            double hoursDegrees = ((double)hours * 30) + ((double)minutes / 2);

            if(hoursDegrees >= 360)
            {
                hoursDegrees = hoursDegrees - 360;
            }

            double firstAngle = Math.Abs(hoursDegrees - minutesDegrees);
            double secondAngle = 360 - firstAngle;

            if (firstAngle >= secondAngle)
            {
                return secondAngle;
            }
            else
            {
                return firstAngle;
            }
        }
        public double GetCalculatedAnswer()
        {
            return answer;
        }
    }
}
