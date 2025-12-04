namespace Rozhrani
{
    public class User
    {
        ///Fields
        private string _userName;
        private string _email;

        private string _password;

        /// <summary>
        /// Uživatelské jméno
        /// </summary>
        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }
        /// <summary>
        /// E-mail uživatele
        /// </summary>
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        /// <summary>
        /// Heslo uživatele
        /// </summary>
        public string Password
        {
            get => _password;
            private set => _password = value;
        }
        /// <summary>
        /// Inicializuje novou instanci User
        /// </summary>
        /// <param name="userName">Uživatelské jméno</param>
        /// <param name="email">Uživatelský e-mail</param>
        /// <param name="password">Heslo uživatele</param>
        public User(string userName,  string email, string password)
        {
            UserName = userName;
            Email = email;
            Password = password;
        }

        public virtual string GetInfo()
        {
            return $"Uživatel: {UserName}, E-mail: {Email}";
        }

    }
}