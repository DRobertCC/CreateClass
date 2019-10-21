using System;

namespace CreateClass
{
    public class Employee : Person
    {
        public int Salary { get; set; }
        public String Profession { get; set; }

        public Employee()
        {
        }

        public Employee(string name, DateTime birthDate, String gender, int salary, string profession)
            : base(name, birthDate, gender)
        {
            Salary = salary;
            Profession = profession;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Profession + " with salary of " + Salary;
        }
    }

}
