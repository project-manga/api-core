using ApiCoreDomain;

namespace ApiCoreApp.GoodManga
{
    public interface IGoodMangaOperationFactory
    {
        IMangaOperation CreateDownloadOperation(long id);
    }
}