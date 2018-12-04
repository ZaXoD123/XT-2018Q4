using System;

namespace Epam.Task3.User
{
    public class User
    {
        public User(string lastName, string name, string patternalName, DateTime birthDate)
        {
            if (birthDate >= DateTime.Now.Date || birthDate.Year <= 1850)
            {
                throw new Exception("Wrong date!");
            }

            this.FullName = (name, lastName, patternalName);
            this.BirthDate = birthDate.Date;
        }

        public (string name, string lastName, string patternalName) FullName { get; }

        public DateTime BirthDate { get; }

        public int GetAges()
        {
            return (int)((DateTime.Now - this.BirthDate).Days / 365.2425);
        }
    }
}