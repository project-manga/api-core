namespace ApiCoreApp.GoodManga
{
    public class GoodMangaUriFormatter : IUriFormatter
    {
        public string Address(IMangaIdentifier identifier, int chapter, int? part, int page)
        {
            if (part.HasValue)
            {
                return $"http://www.goodmanga.net/images/manga/{identifier.ForUri()}/{chapter}.{part.Value}/{page}.jpg";
            }

            return $"http://www.goodmanga.net/images/manga/{identifier.ForUri()}/{chapter}/{page}.jpg";
        }
    }
}
