namespace ApiCoreDomain
{
    using System.Collections.Generic;

    public class MangaChapterIdentifier : IMangaChapterIdentifier
    {
        #region Constructors
        public MangaChapterIdentifier(IMangaIdentifier mangaId, int chapter, int? part)
        {
            MangaId = mangaId;
            Chapter = chapter;
            Part = part;
        }
        #endregion

        #region Public
        public IMangaIdentifier MangaId { get; }

        public int Chapter { get; }

        public int? Part { get; }

        public override bool Equals(object obj)
        {
            return Equals(obj as MangaPageIdentifier);
        }

        public bool Equals(IMangaChapterIdentifier other)
        {
            return other != null
                && EqualityComparer<IMangaIdentifier>.Default.Equals(MangaId, other.MangaId)
                && Chapter == other.Chapter
                && EqualityComparer<int?>.Default.Equals(Part, other.Part);
        }

        public override int GetHashCode()
        {
            var hashCode = -668726078;
            hashCode = hashCode * -1521134295 + EqualityComparer<IMangaIdentifier>.Default.GetHashCode(MangaId);
            hashCode = hashCode * -1521134295 + Chapter.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(Part);
            return hashCode;
        } 
        #endregion
    }
}
