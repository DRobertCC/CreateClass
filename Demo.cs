using System;
using System.Globalization;

namespace CreateClass
{
    class Demo
    {
        private static void Main()
        {
            DateTime dt = new DateTime(1990, 07, 18);
            Person tim = new Person("Tim", dt, "Male");
            Console.WriteLine(tim);


            //Console.Write("Enter your Name: ");
            //String guestName = Console.ReadLine();
            
            //string myDateFormat = "yyyy-m-d";
            //Console.Write("Enter your Birth Date in the format {0} (example: {1}): ", myDateFormat, DateTime.Today.ToString(myDateFormat));
            //DateTime userBirthday;
            //if (DateTime.TryParseExact(Console.ReadLine(), myDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out userBirthday) && DateTime.Today > userBirthday)
            //{
            //    Person guest = new Person(guestName, userBirthday, "Male");

            //    Console.WriteLine("You lived {0} days from {1} ", (DateTime.Today - guest.BirthDate).TotalDays, guest.BirthDate.ToString(myDateFormat));

            //    // Save today's date.
            //    var today = DateTime.Today;
            //    // Calculate the age.
            //    var age = today.Year - guest.BirthDate.Year;
            //    // Go back to the year the person was born in case of a leap year
            //    if (guest.BirthDate.Date > today.AddYears(-age)) age--;

            //    Console.WriteLine("You are {0} years old.", age);
            //}
            //else
            //{
            //    Console.WriteLine("Wrongly formated input!");
            //}


            DateTime dt2 = new DateTime(1985, 04, 12);
            Employee eva = new Employee("Eva", dt2, "Female", 5000, "Archeologist");
            eva.Profession = "Lawyer";
            eva.Room = new Room(222);
            Console.WriteLine(eva);


            Employee Kovacs = new Employee("Géza", DateTime.Now, "Male", 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.Number = 112;

            Console.WriteLine(Kovacs);
            Console.WriteLine(Kovacs2);
            Console.ReadKey();
        }
    }
}
