namespace Rozhrani
{

    public class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new GuestUser("student1", "student1@vsps.cz", "Student123"),
                new AdminUser("admin", "admin@vsps.cz", "Admin123")
            };
            foreach (var user in users)
            {
                Console.WriteLine(user.GetInfo());

                Console.WriteLine("Test přihlášení uživatlů");

                if (user is ILoginable loginableUser)
                {
                    Console.WriteLine("Pokus o přihlášení se správným heslem.");
                    loginableUser.Login(user.UserName, user is GuestUser ? "Student123" : "Admin123");
                }
            }
        }
    }
}