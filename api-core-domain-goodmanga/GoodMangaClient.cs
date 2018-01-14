namespace ApiCoreApp.GoodManga
{
    using System;
    using System.Net;

    /// <summary>
    /// Client to Good Manga site.
    /// </summary>
    public class GoodMangaClient
    {
        #region Constructors
        public GoodMangaClient(
            IMangaEnvironment environment,
            IUriFormatter uriFormatter)
        {
            mEnvironment = environment ?? throw new ArgumentNullException(nameof(environment));
            mUriFormatter = uriFormatter ?? throw new ArgumentNullException(nameof(uriFormatter));
            mWebClient = new WebClient();
        } 
        #endregion

        #region Public
        public string Page(IMangaIdentifier identifier, int chapter, int? part, int page)
        {
            try
            {
                var address = mUriFormatter.Address(identifier, chapter, part, page);
                var filename = mEnvironment.FileNameFor(identifier, chapter, part, page);
                mWebClient.DownloadFile(address, filename);

                return filename;
            }
            catch (Exception ex)
            {
                string errorMessage = GetPageDownloadErrorMessage(identifier.ForUri(), chapter, part, page);
                throw new ClientException(errorMessage, ex);
            }
        } 
        #endregion

        #region Private
        private WebClient mWebClient;
        private IMangaEnvironment mEnvironment;
        private IUriFormatter mUriFormatter;

        private static string GetPageDownloadErrorMessage(string sid, int chapter, int? part, int page)
        {
            var actualPart = part ?? -1;
            var errorMessage = $"An error occurred while trying to download: {sid}, {chapter}, {part}, {page}";
            return errorMessage;
        } 
        #endregion
    }
}