using System;
using System.Collections.Generic;

namespace ApiCoreDomain
{
    public class MangaPageIdentifier : IMangaPageIdentifier, IEquatable<MangaPageIdentifier>
    {
        #region Constructors
        public MangaPageIdentifier(IMangaIdentifier mangaId, int chapter, int? part, int page)
        {
            MangaId = mangaId;
            Chapter = chapter;
            Part = part;
            Page = page;
        }
        #endregion

        #region Public
        public IMangaIdentifier MangaId { get; }

        public int Chapter { get; }

        public int? Part { get; }

        public int Page { get; }

        public override bool Equals(object obj)
        {
            return Equals(obj as MangaPageIdentifier);
        }

        public bool Equals(MangaPageIdentifier other)
        {
            return other != null &&
                EqualityComparer<IMangaIdentifier>.Default.Equals(MangaId, other.MangaId) &&
                Chapter == other.Chapter &&
                EqualityComparer<int?>.Default.Equals(Part, other.Part) &&
                Page == other.Page;
        }

        public override int GetHashCode()
        {
            var hashCode = -668726078;
            hashCode = hashCode * -1521134295 + EqualityComparer<IMangaIdentifier>.Default.GetHashCode(MangaId);
            hashCode = hashCode * -1521134295 + Chapter.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(Part);
            hashCode = hashCode * -1521134295 + Page.GetHashCode();
            return hashCode;
        } 
        #endregion
    }
}
