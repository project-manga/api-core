﻿namespace ApiCoreApp.GoodManga
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
                mConnection.Sid,
                mConnection.StartingChapter,
                mConnection.EndingChapter,
                mConnection.StartingChapterPart,
                mConnection.EndingChapterPart,
                mConnection.ChapterPartStep,
                mConnection.StartingPage,
                mConnection.EndingPage);

            return new GoodMangaReader(context,
                new GoodMangaClient(
                    new GoodMangaEnvironment(),
                    new GoodMangaUriFormatter()
                )
            );
        }

        private readonly GoodMangaConnection mConnection;
    }
}
