using System;

namespace CreateClass
{
    public class Employee : Person, ICloneable
    {
        public int Salary { get; set; }
        public String Profession { get; set; }
        public Room Room { get; internal set; } // Room type inner property

        public Employee(string name, DateTime birthDate, String gender, int salary, string profession)
            : base(name, birthDate, gender)
        {
            Salary = salary;
            Profession = profession;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Profession + " with salary of " + Salary + " works in room " + Room.Number;
        }

        public object Clone() // See Demo.cs Employee Kovacs
        {
            //return MemberwiseClone(); // Room 112 both.

            Employee newEmployee = (Employee)MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee; // 1st: 111, 2nd: 112
        }
    }

}
