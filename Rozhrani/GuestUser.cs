namespace Rozhrani
{
    public class GuestUser : User, ILoginable, IAuthorizable
    {
        /// <summary>
        /// Inicializuje novou instanci AdminUser
        /// </summary>
        /// <param name="userName">Uživatelské jméno</param>
        /// <param name="email">Uživatelský e-mail</param>
        /// <param name="password">Heslo uživatele</param>
        public GuestUser(string userName, string email, string password) : base(userName, email, password)
        {
        }

        public void Login(string userName, string passWord)

        {
        if (userName == UserName && passWord == Password)
        {
            Console.WriteLine($"Uživatel {UserName} byl přihlášen (host).");
        }
        else
        {
            Console.WriteLine("Špatně údaje.");
        }
        }
        
        public bool Authorize(string username, string password)
        {
            return username == UserName && password == Password;
        }
        
        public bool HasAccess(string resource)
        {
            return resource == "StudentPortal";
        }
    }
}