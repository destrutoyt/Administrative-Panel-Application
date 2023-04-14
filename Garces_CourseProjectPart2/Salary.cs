using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garces_CourseProjectPart2
{
    [Serializable]
    public class Salary : Employee
    {
        //ATTRIBUTES
        private double annualSalary;

        public Salary(): base()
         {
            annualSalary = 0.0;
        }
        public Salary(string firstName, string lastName, string ssn, DateTime hiredate, Benefits benefits, double annualSalary)
            : base(firstName, lastName, ssn,hiredate, benefits)
        {
            this.annualSalary = annualSalary;
        }

        public Salary(string firstName, string lastName, string ssn, DateTime hiredate, Benefits benefits) : base(firstName, lastName, ssn, hiredate, benefits)
        {
        }

        //behaviours
        public override double CalculatePay()
        {
            return annualSalary / 26.0;
        }
        public override string ToString()
        {
            return base.ToString() + ", annualSalary=" + annualSalary.ToString("C2");
        }
        //properties

        public double AnnualSalary
        {
            get { return annualSalary; }
            set { annualSalary = value; }
        }
    }
}
