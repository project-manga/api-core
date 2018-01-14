﻿namespace ApiCoreDomain
{
    using System;
    using System.Net;

    /// <summary>
    /// Client to Good Manga site.
    /// </summary>
    public class MangaWebClient : IMangaClient
    {
        #region Constructors
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
        public string Page(IMangaIdentifier identifier, int chapter, int? part, int pageNumber)
        {
            try
            {
                var address = mUriFormatter.Address(identifier, chapter, part, pageNumber);
                var filename = mEnvironment.FileNameFor(identifier, chapter, part, pageNumber);
                mWebClient.DownloadFile(address, filename);

                return filename;
            }
            catch (Exception ex)
            {
                string errorMessage = GetPageDownloadErrorMessage(identifier.ForUri(), chapter, part, pageNumber);
                throw new ClientException(errorMessage, ex);
            }
        } 
        #endregion

        #region Private
        private readonly WebClient mWebClient;
        private readonly IMangaEnvironment mEnvironment;
        private readonly IUriFormatter mUriFormatter;

        private static string GetPageDownloadErrorMessage(string sid, int chapter, int? part, int page)
        {
            var actualPart = part ?? -1;
            var errorMessage = $"An error occurred while trying to download: {sid}, {chapter}, {part}, {page}";
            return errorMessage;
        } 
        #endregion
    }
}