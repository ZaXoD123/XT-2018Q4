namespace Epam.Task3.Employee
{
    using System;

    internal class Employee : User.User
    {
        public Employee(string lastName, string name, string patternalName, DateTime birthDate, string position, int experience) : base(lastName, name, patternalName, birthDate)
        {
            if (experience < 0 || experience > this.GetAges())
            {
                throw new Exception("Wrong values!");
            }

            this.Experience = experience;
            this.Position = position;
        }
        
        public string Position { get; }

        public int Experience { get; }
    }
}