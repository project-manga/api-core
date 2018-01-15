namespace ApiCoreDomain.GoodManga
{
    using System;

    /// <summary>
    /// GoodManga reader implementation.
    /// </summary>
    public class GoodMangaReader : IMangaReader
    {
        #region Constructors
        /// <summary>
        /// Constructs the reader.
        /// </summary>
        /// <param name="context">The context</param>
        /// <param name="client">The client</param>
        public GoodMangaReader(GoodMangaContext context, MangaWebClient client)
        {
            mContext = context ?? throw new ArgumentNullException(nameof(context));
            mClient = client ?? throw new ArgumentNullException(nameof(client));
        } 
        #endregion

        #region Public
        public IMangaIdentifier Id => mContext.Identifier;

        public int Chapter => mContext.CurrentChapter;

        public int? Part => mContext.CurrentChapterPart;

        public int Page => mContext.CurrentPage;

        public bool Read()
        {
            try
            {
                return ReadPage();
            }
            catch (NoMoreChaptersException)
            {
                return false;
            }
        }
        #endregion

        #region Private
        private readonly GoodMangaContext mContext;
        private readonly MangaWebClient mClient;

        private bool ReadPage()
        {
            try
            {
                mContext.NextPage();

                mClient.DownloadPage(
                    new MangaPageIdentifier(
                        new MangaChapterIdentifier(
                            mContext.Identifier,
                            mContext.CurrentChapter,
                            mContext.CurrentChapterPart
                        ),
                        mContext.CurrentPage
                    )
                );

                mContext.SuccessPage();
                return true;
            }
            catch (ClientException)
            {
                mContext.FailPage();
                return true;
            }
            catch (NoMorePagesException)
            {
                mContext.FailChapter();
                return true;
            }
        } 
        #endregion
    }
}
