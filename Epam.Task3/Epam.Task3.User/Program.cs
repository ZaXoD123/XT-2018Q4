using System;

namespace Epam.Task3.User
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var user1 = new User("Никулин", "Николай", "Олегович", new DateTime(1998, 12, 5));
            Console.WriteLine("Имя: {1}{0}Фамилия: {2}{0}Отчество: {3}{0}Дата Рождения: {4}{0}Возраст {5}",
                Environment.NewLine, user1.FullName.name, user1.FullName.lastName, user1.FullName.patternalName,
                user1.BirthDate.ToString("dd/MM/yyyy"), user1.GetAges());

            //Incorrect test
            try
            {
                var user2 = new User("Никулин", "Николай", "Олегович", new DateTime(2101, 12, 5));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}