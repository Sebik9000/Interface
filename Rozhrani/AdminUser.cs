namespace Rozhrani
{
    public class AdminUser : User, ILoginable, IAuthorizable
    {
        /// <summary>
        /// Inicializuje novou instanci AdminUser
        /// </summary>
        /// <param name="userName">Uživatelské jméno</param>
        /// <param name="email">Uživatelský e-mail</param>
        /// <param name="password">Heslo uživatele</param>
        public AdminUser(string userName, string email, string password) : base(userName, email, password)
        {
            public void Login(string userName, string passWord)
            {

            }
        }

    }
}