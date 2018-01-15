namespace ApiCoreDomain.GoodManga
{
    /// <summary>
    /// GoodManga uri formatter
    /// </summary>
    public class GoodMangaUriFormatter : IUriFormatter
    {
        public string Address(IMangaPageIdentifier identifier)
        {
            if (identifier.ChapterId.Part.HasValue)
            {
                return $"http://www.goodmanga.net/images/manga/{identifier.ChapterId.MangaId.ForUri()}/{identifier.ChapterId.Chapter}.{identifier.ChapterId.Part}/{identifier.Page}.jpg";
            }

            return $"http://www.goodmanga.net/images/manga/{identifier.ChapterId.MangaId.ForUri()}/{identifier.ChapterId.Chapter}/{identifier.Page}.jpg";
        }
    }
}
