namespace ApiCoreDomain
{
    using System.Collections.Generic;

    public class MangaPageIdentifier : IMangaPageIdentifier
    {
        #region Constructors
        public MangaPageIdentifier(IMangaChapterIdentifier chapterId, int page)
        {
            ChapterId = chapterId;
            Page = page;
        }
        #endregion

        #region Public
        public IMangaChapterIdentifier ChapterId { get; }

        public int Page { get; }

        public override bool Equals(object obj)
        {
            return Equals(obj as MangaPageIdentifier);
        }

        public bool Equals(IMangaPageIdentifier other)
        {
            return other != null
                && EqualityComparer<IMangaChapterIdentifier>.Default.Equals(ChapterId, other.ChapterId)
                && Page == other.Page;
        }

        public override int GetHashCode()
        {
            var hashCode = -668726078;
            hashCode = hashCode * -1521134295 + EqualityComparer<IMangaChapterIdentifier>.Default.GetHashCode(ChapterId);
            hashCode = hashCode * -1521134295 + Page.GetHashCode();
            return hashCode;
        }
        #endregion
    }
}
