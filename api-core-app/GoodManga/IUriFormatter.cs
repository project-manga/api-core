namespace ApiCoreApp.GoodManga
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
        /// <param name="identifier">Manga Id</param>
        /// <param name="chapter">Chapter number</param>
        /// <param name="part">Chapter part</param>
        /// <param name="page">Chapter page</param>
        /// <returns></returns>
        string Address(IMangaIdentifier identifier, int chapter, int? part, int page);
    }
}