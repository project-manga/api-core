namespace ApiCoreDomain.GoodManga
{
    /// <summary>
    /// GoodManga uri formatter
    /// </summary>
    public class GoodMangaUriFormatter : IUriFormatter
    {
        public string Address(IMangaPageIdentifier identifier)
        {
            if (identifier.Part.HasValue)
            {
                return $"http://www.goodmanga.net/images/manga/{identifier.MangaId.ForUri()}/{identifier.Chapter}.{identifier.Part}/{identifier.Page}.jpg";
            }

            return $"http://www.goodmanga.net/images/manga/{identifier.MangaId.ForUri()}/{identifier.Chapter}/{identifier.Page}.jpg";
        }
    }
}
