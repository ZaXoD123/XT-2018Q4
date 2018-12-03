using System;

namespace Epam.Task3.User
{
    internal class User
    {
        public User(string lastName, string name, string patternalName, DateTime birthDate)
        {
            if (birthDate >= DateTime.Now.Date || birthDate.Year <= 1850) throw new Exception("Wrong date!");
            FullName = (name, lastName, patternalName);
            BirthDate = birthDate.Date;
        }

        public (string name, string lastName, string patternalName) FullName { get; }
        public DateTime BirthDate { get; }

        public int GetAges()
        {
            return (int) ((DateTime.Now - BirthDate).Days / 365.2425);
        }
    }
}