namespace ApiCoreDomain
{
    /// <summary>
    /// Implemented by those classes whose compose 
    /// page uri.
    /// </summary>
    public interface IUriFormatter
    {
        /// <summary>
        /// Formats page components into specific uri.
        /// </summary>
        /// <param name="identifier">Manga page id</param>
        /// <returns></returns>
        string Address(IMangaPageIdentifier identifier);
    }
}