namespace Rozhrani
{
    /// <summary>
    /// Rozhranní pro přihlášení uživatele do systému.
    /// </summary>

    interface ILoginable
    {

    /// <summary>
    /// Přihlásí uživatele do systému.
    /// </summary>
    /// <param name="userName">Uživatelské jméno</param>
    /// <param name="passWord">Uživatelské heslo</param>
    /// <returns>True pokud má přístup, jinak false</returns>
        void Login(string userName, string password);
    }
}
