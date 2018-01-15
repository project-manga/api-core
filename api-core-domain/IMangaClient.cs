namespace ApiCoreDomain
{
    public interface IMangaClient
    {
        /// <summary>
        /// Downloads a page.
        /// </summary>
        /// <param name="identifier">Manga identifier</param>
        /// <param name="chapter">Chapter number</param>
        /// <param name="part">Chapter part number</param>
        /// <param name="page">Chapter page</param>
        /// <returns>
        /// Returns the location where the page was downloaded.
        /// </returns>
        string DownloadPage(IMangaIdentifier identifier, int chapter, int? part, int page);
    }
}