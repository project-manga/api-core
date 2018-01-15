namespace ApiCoreDomain
{
    using System;

    /// <summary>
    /// Represents a manga page identifier.
    /// </summary>
    public interface IMangaPageIdentifier : IEquatable<IMangaPageIdentifier>
    {
        /// <summary>
        /// Gets manga source of the page.
        /// </summary>
        IMangaChapterIdentifier ChapterId { get; }

        /// <summary>
        /// Gets page number.
        /// </summary>
        int Page { get; }
    }
}
