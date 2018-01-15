namespace ApiCoreDomain.GoodManga
{
    /// <summary>
    /// GoodManga identifier.
    /// </summary>
    public class GoodMangaIdentifier : IMangaIdentifier
    {
        #region Constructors
        /// <summary>
        /// GoodManga sid.
        /// </summary>
        /// <param name="sid"></param>
        public GoodMangaIdentifier(string sid)
        {
            mSid = sid;
        }
        #endregion

        #region Public
        public string ForUri()
        {
            return mSid;
        }
        #endregion

        #region Private
        private readonly string mSid; 
        #endregion
    }
}
