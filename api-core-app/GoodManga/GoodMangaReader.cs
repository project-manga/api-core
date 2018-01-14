﻿namespace ApiCoreApp.GoodManga
{
    using System;

    public class GoodMangaReader : IMangaReader
    {
        public GoodMangaReader(GoodMangaContext context, GoodMangaClient client)
        {
            mContext = context ?? throw new ArgumentNullException(nameof(context));
            mClient = client ?? throw new ArgumentNullException(nameof(client));
        }

        public IMangaIdentifier Id => new GoodMangaIdentifier(mContext.Sid);

        public int Chapter => mContext.CurrentChapter;

        public int? Part => mContext.CurrentChapterPart;

        public int Page => mContext.CurrentPage;

        public bool Read()
        {
            try
            {
                return ReadPage();
            }
            catch (NoMoreChaptersException)
            {
                return false;
            }
        }

        private bool ReadPage()
        {
            try
            {
                mContext.NextPage();

                mClient.Page(
                    new GoodMangaIdentifier(mContext.Sid),
                    mContext.CurrentChapter,
                    mContext.CurrentChapterPart,
                    mContext.CurrentPage);

                mContext.SuccessPage();
                return true;
            }
            catch (ClientException)
            {
                mContext.FailPage();
                return true;
            }
            catch (NoMorePagesException)
            {
                mContext.FailChapter();
                return true;
            }
        }

        private readonly GoodMangaContext mContext;
        private readonly GoodMangaClient mClient;
    }
}
