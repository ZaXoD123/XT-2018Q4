namespace Epam.Task3.Employee
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var user1 = new Employee("Ivanov", "Ivan", "Ivanovich", new DateTime(1998, 12, 5), "Worker", 1);
            Console.WriteLine("First name: {1}{0}Last name: {2}{0}Patternal name: {3}{0}Birth day: {4}{0}Ages {5}{0}Position {6}{0}Experience {7}", Environment.NewLine, user1.FullName.name, user1.FullName.lastName, user1.FullName.patternalName, user1.BirthDate.ToString("dd/MM/yyyy"), user1.GetAges(), user1.Position, user1.Experience);

            // Incorrect test
            try
            {
                var user2 = new Employee("Никулин", "Николай", "Олегович", new DateTime(1998, 12, 5), "Работник", -1);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}