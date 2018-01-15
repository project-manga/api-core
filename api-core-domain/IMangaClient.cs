namespace ApiCoreDomain
{
    public interface IMangaClient
    {
        /// <summary>
        /// Downloads a page.
        /// </summary>
        /// <param name="identifier">Manga page identifier</param>
        /// <returns>
        /// Returns the location where the page was downloaded.
        /// </returns>
        string DownloadPage(IMangaPageIdentifier identifier);
    }
}