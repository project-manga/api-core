namespace ApiCoreDomain.GoodManga
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// GoodManga identifier.
    /// </summary>
    public class GoodMangaIdentifier : IMangaIdentifier, IEquatable<GoodMangaIdentifier>
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

        public override bool Equals(object obj)
        {
            return Equals(obj as GoodMangaIdentifier);
        }

        public bool Equals(GoodMangaIdentifier other)
        {
            return other != null && mSid == other.mSid;
        }

        public override int GetHashCode()
        {
            return -2012648796 + EqualityComparer<string>.Default.GetHashCode(mSid);
        }
        #endregion

        #region Private
        private readonly string mSid; 
        #endregion
    }
}
