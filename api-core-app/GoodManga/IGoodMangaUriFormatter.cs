namespace ApiCoreApp.GoodManga
{
    public interface IGoodMangaUriFormatter
    {
        string Address(string sid, int chapter, int? part, int page);
    }
}