using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garces_CourseProjectPart2
{
    [Serializable]
    public abstract class Employee
    {
        //attributes
        private string firstName;
        private string lastName;
        private string ssn;
        private DateTime hiredate;
        private Benefits benefits;    // put this near the top with the other attributes

        //Constructors

        public Employee()
        {
            firstName = "N/A";
            lastName = "N/A";
            ssn = "N/A";
            hiredate = new DateTime();
            benefits = new Benefits();
        }

        public Employee(string firstName, string lastName, string ssn, DateTime hiredate, Benefits benefits)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.hiredate = hiredate;
            this.benefits = benefits;
        }

        //Behaviours
        public override string ToString()
        {
            return "firstName= \r\n" + firstName + ", lastName=" + lastName
                  + ", ssn=" + ssn + ", hireDate=" + hiredate.ToShortDateString()
                  + ", healthIns=" + benefits.HealthInsurance
                  + ", lifeIns=" + benefits.LifeInsurance
                  + ", vacation=" + benefits.Vacation;
        }


        public abstract double CalculatePay();

        //Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; } //Assigning value (FirstName= "Bob")
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public DateTime HireDate
        {
            get { return hiredate; }
            set { hiredate = value; }
        }

        public Benefits BenefitsEmp
        {
            get { return benefits; }
            set { benefits = value; }
        }
    }
}
