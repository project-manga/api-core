namespace ApiCoreDomain
{
    using System;
    using System.Net;

    /// <summary>
    /// Client to Good Manga site.
    /// </summary>
    public class MangaWebClient : IMangaClient
    {
        #region Constructors
        /// <summary>
        /// Constructs the client.
        /// </summary>
        /// <param name="environment">Manga environment</param>
        /// <param name="uriFormatter">Uri formatter, composes page url</param>
        public MangaWebClient(
            IMangaEnvironment environment,
            IUriFormatter uriFormatter)
        {
            mEnvironment = environment ?? throw new ArgumentNullException(nameof(environment));
            mUriFormatter = uriFormatter ?? throw new ArgumentNullException(nameof(uriFormatter));
            mWebClient = new WebClient();
        } 
        #endregion

        #region Public
        public string DownloadPage(IMangaPageIdentifier identifier)
        {
            try
            {
                return InternalDownloadPage(identifier);
            }
            catch (Exception ex)
            {
                string errorMessage = GetPageDownloadErrorMessage(identifier);
                throw new ClientException(errorMessage, ex);
            }
        }
        #endregion

        #region Private
        private readonly WebClient mWebClient;
        private readonly IMangaEnvironment mEnvironment;
        private readonly IUriFormatter mUriFormatter;

        private static string GetPageDownloadErrorMessage(IMangaPageIdentifier identifier)
        {
            var actualPart = identifier.ChapterId.Part ?? -1;
            var errorMessage = $"An error occurred while trying to download: {identifier.ChapterId.MangaId.ForUri()}, {identifier.ChapterId.Chapter}, {actualPart}, {identifier.ChapterId.Part}";
            return errorMessage;
        }

        private string InternalDownloadPage(IMangaPageIdentifier identifier)
        {
            var address = mUriFormatter.Address(identifier);
            var filename = mEnvironment.FileNameFor(identifier);
            mWebClient.DownloadFile(address, filename);

            return filename;
        }
        #endregion
    }
}