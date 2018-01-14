namespace ApiCoreApp.GoodManga
{
    public class GoodMangaUriFormatter : IGoodMangaUriFormatter
    {
        public string Address(string sid, int chapter, int? part, int page)
        {
            if (part.HasValue)
            {
                return $"http://www.goodmanga.net/images/manga/{sid}/{chapter}.{part.Value}/{page}.jpg";
            }

            return $"http://www.goodmanga.net/images/manga/{sid}/{chapter}/{page}.jpg";
        }
    }
}
