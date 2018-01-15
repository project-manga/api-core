namespace ApiCoreDomain
{
    using System;

    /// <summary>
    /// Represents a manga chapter identifier.
    /// </summary>
    public interface IMangaChapterIdentifier : IEquatable<IMangaChapterIdentifier>
    {
        /// <summary>
        /// Gets manga source of the chapter.
        /// </summary>
        IMangaIdentifier MangaId { get; }

        /// <summary>
        /// Gets chapter number.
        /// </summary>
        int Chapter { get; }

        /// <summary>
        /// Gets chapter part.
        /// </summary>
        int? Part { get; }
    }
}
