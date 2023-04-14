using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garces_CourseProjectPart2
{
    [Serializable]
    public class Hourly : Employee
    {
        //att
        private double hourlyRate;
        private double hoursWorked;

        //constructors

        public Hourly() : base()
        {
            hourlyRate = 0.0;
            hoursWorked = 0.0;
        }
        public Hourly(string firstName, string lastName, string ssn, DateTime hiredate, Benefits benefits, double hourlyRate, double hoursWorked)
         : base(firstName, lastName, ssn, hiredate, benefits)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        //behaviours
        public override double CalculatePay()
        {
            double pay = 0.0;
            if (hoursWorked > 40.0)
            {
                double basePay = 40.0 * hourlyRate;
                double overtime = (hoursWorked + 40.0) * hoursWorked * 1.5;
                pay = basePay + overtime;
            }
            else
            {
                pay = hoursWorked * hourlyRate;
            }

            return pay;
        }

        public override string ToString()
        {
            return base.ToString() + ", hourlyRate=" + hourlyRate.ToString("C2")
                + ", hoursWorked=" + hoursWorked.ToString("C2");
        }

        //properties
        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }
        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }
    }

}
