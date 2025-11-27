namespace Rozhrani
{
    /// <summary>
    /// Rozhranní pro autorizaci uživatele v systému.
    /// </summary>
    interface IAuthorizable
    {
        /// <summary>
        /// Ověří, zda má uživatel přístup k systému.
        /// </summary>
        /// <param name="user">Uživatel</param>
        /// <returns>True pokud má přístup, jinak false</returns>
        bool Authorize(string username, string password);
    }
}
