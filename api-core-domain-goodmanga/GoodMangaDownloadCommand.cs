namespace ApiCoreDomain.GoodManga
{
    using System;

    public class GoodMangaDownloadCommand : DownloadCommand
    {
        public GoodMangaDownloadCommand(GoodMangaConnection connection)
        {
            mConnection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public GoodMangaReader ExecuteReader()
        {
            var context = new GoodMangaContext(
                mConnection.Id,
                mConnection.StartingChapter,
                mConnection.EndingChapter,
                mConnection.StartingChapterPart,
                mConnection.EndingChapterPart,
                mConnection.ChapterPartStep,
                mConnection.StartingPage,
                mConnection.EndingPage);

            return new GoodMangaReader(context,
                new GoodMangaClient(
                    new MangaEnvironment(),
                    new GoodMangaUriFormatter()
                )
            );
        }

        private readonly GoodMangaConnection mConnection;
    }
}
