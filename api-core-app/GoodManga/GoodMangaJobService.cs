namespace ApiCoreApp.GoodManga
{
    using System;

    public class GoodMangaJobService
    {
        public GoodMangaJobService(IGoodMangaOperationFactory goodMangaOperationFactory)
        {
            mGoodMangaOperationFactory = goodMangaOperationFactory ?? throw new ArgumentNullException(nameof(goodMangaOperationFactory));
        }

        public void Download(long id)
        {
            GoodMangaDownloadOperation downloadOperation = mGoodMangaOperationFactory.CreateDownloadOperation(id);
            downloadOperation.Execute();
        }

        private readonly IGoodMangaOperationFactory mGoodMangaOperationFactory;
    }
}
