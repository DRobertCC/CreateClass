using System;

namespace CreateClass
{
    public enum GendersEnum { Male, Female };

    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; }
        public GendersEnum Gender { get; }
               
        public Person(string name, DateTime birthDate, String gender)
        {
            Name = name;
            BirthDate = birthDate;
            Gender = (GendersEnum)Enum.Parse(typeof(GendersEnum), gender); ;
        }

        public override String ToString()
        {
            int age = DateTime.Today.Year - BirthDate.Year;
            return "\n" + Name + " is a " + age + " year old " + Gender;
            //return ("{0} is {1} years old", this.Name, age.ToString);
        }


    }
}
