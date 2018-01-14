namespace ApiCoreApp.GoodManga
{
    public interface IGoodMangaEnvironment
    {
        string FileNameFor(string sid, int chapter, int? part, int page);
    }
}