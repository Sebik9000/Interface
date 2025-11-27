namespace Rozhrani
{
    /// <summary>
    /// Rozhranní pro přihlášení uživatele do systému.
    /// </summary>

    interface IAuthorizable
    {

    /// <summary>
    /// Oveří, zda má uživatel přístup k danému zdroji.
    /// </summary>
    /// <param name="resource">Název zdroje</param>
    /// <returns>True pokud má přístup, jinak false</returns>
        bool HasAccess(string resource);
    }
}
