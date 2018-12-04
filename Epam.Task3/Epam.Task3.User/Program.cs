using System;

namespace Epam.Task3.User
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var user1 = new User("Ivanov", "Ivan", "Ivanovich", new DateTime(1998, 12, 5));
            Console.WriteLine("First name: {1}{0}Last name: {2}{0}Patternal name: {3}{0}Birth day: {4}{0}Ages {5}", Environment.NewLine, user1.FullName.name, user1.FullName.lastName, user1.FullName.patternalName, user1.BirthDate.ToString("dd/MM/yyyy"), user1.GetAges());

            // Incorrect test
            try
            {
                var user2 = new User("Ivanov", "Ivan", "Ivanovich", new DateTime(2101, 12, 5));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}