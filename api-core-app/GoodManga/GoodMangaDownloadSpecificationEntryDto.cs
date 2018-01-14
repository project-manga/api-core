namespace ApiCoreApp.GoodManga
{
    /// <summary>
    /// Represents GoodManga download specification entry dto.
    /// </summary>
    public class GoodMangaDownloadSpecificationEntryDto
    {
        /// <summary>
        /// Gets or sets downloading manga sid
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// Gets or sets download starting chapter
        /// </summary>
        public int? StartingChapter { get; set; }
        
        /// <summary>
        /// Gets or sets download ending chapter
        /// </summary>
        public int? EndingChapter { get; set; }

        /// <summary>
        /// Gets or sets download part set
        /// </summary>
        public int? ChaptersPartStep { get; set; }

        /// <summary>
        /// Gets or sets download starting page
        /// </summary>
        public int? StartingPage { get; set; }

        /// <summary>
        /// Gets ors sets download ending page
        /// </summary>
        public int? EndingPage { get; set; }
    }
}
