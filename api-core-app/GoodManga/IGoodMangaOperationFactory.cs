namespace ApiCoreApp.GoodManga
{
    public interface IGoodMangaOperationFactory
    {
        GoodMangaDownloadOperation CreateDownloadOperation(long id);
    }
}