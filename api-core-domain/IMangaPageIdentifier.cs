namespace ApiCoreDomain
{
    /// <summary>
    /// Represents a manga page identifier.
    /// </summary>
    public interface IMangaPageIdentifier
    {
        /// <summary>
        /// Gets manga source of the page.
        /// </summary>
        IMangaIdentifier MangaId { get; }
        
        /// <summary>
        /// Gets chapter source of the page.
        /// </summary>
        int Chapter { get; }

        /// <summary>
        /// Gets chapter part source of the page.
        /// </summary>
        int? Part { get; }

        /// <summary>
        /// Gets page number.
        /// </summary>
        int Page { get; }
    }
}
