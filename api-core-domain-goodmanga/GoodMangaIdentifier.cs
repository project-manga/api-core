namespace ApiCoreDomain.GoodManga
{
    public class GoodMangaIdentifier : IMangaIdentifier
    {
        public GoodMangaIdentifier(string sid)
        {
            mSid = sid;
        }

        public string ForUri()
        {
            return mSid;
        }

        private readonly string mSid;
    }
}
