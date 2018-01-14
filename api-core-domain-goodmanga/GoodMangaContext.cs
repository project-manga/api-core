namespace ApiCoreApp.GoodManga
{
    using System;

    public class GoodMangaContext
    {
        /// <summary>
        /// Constructs GoodMangaContext
        /// </summary>
        /// <param name="sid">Manga sid</param>
        /// <param name="startingChapter">Manga starting chapter</param>
        /// <param name="endingChapter">Manga ending chapter</param>
        /// <param name="startingChapterPart"></param>
        /// <param name="endingChapterPart"></param>
        /// <param name="chapterPartStep"></param>
        /// <param name="startingPage">Manga starting page</param>
        /// <param name="endingPage">Manga ending page</param>
        public GoodMangaContext(
            string sid,
            int startingChapter,
            int? endingChapter,
            int? startingChapterPart,
            int? endingChapterPart,
            int? chapterPartStep,
            int startingPage,
            int? endingPage)
        {
            Sid = sid ?? throw new ArgumentNullException(nameof(sid));
            StartingChapter = startingChapter;
            CurrentChapter = startingChapter;
            EndingChapter = endingChapter;
            StartingChapterPart = startingChapterPart;
            CurrentChapterPart = startingChapterPart;
            EndingChapterPart = endingChapterPart;
            ChapterPartStep = chapterPartStep;
            StartingPage = startingPage;
            CurrentPage = startingPage;
            EndingPage = endingPage;
        }

        public string Sid { get; }

        public int StartingChapter { get; }
        public int CurrentChapter { get; private set; }
        public int? EndingChapter { get; }

        public int? StartingChapterPart { get; }
        public int? CurrentChapterPart { get; private set; }
        public int? EndingChapterPart { get; }
        public int? ChapterPartStep { get; }

        public int StartingPage { get; }
        public int CurrentPage { get; private set; }
        public int? EndingPage { get; }

        public bool HasChapters => mChaptersErrors < mAllowedChaptersErrors 
            && (!EndingChapter.HasValue || CurrentChapter < EndingChapter.GetValueOrDefault())
            && (!EndingChapterPart.HasValue || CurrentChapterPart < EndingChapterPart.GetValueOrDefault());

        public bool HasPages => mPagesErrors < mAllowedPagesErrors
            && (!EndingPage.HasValue || CurrentPage < EndingPage.GetValueOrDefault());

        public void NextChapter()
        {
            if (!HasChapters)
            {
                throw new NoMoreChaptersException();
            }

            CurrentPage = 0;
            mPagesErrors = 0;
            CurrentChapter++;
        }

        public void FailChapter()
        {
            mChaptersErrors++;
            NextChapter();
        }

        public void NextPage()
        {
            if (!HasPages)
            {
                throw new NoMorePagesException();
            }

            CurrentPage++;
        }

        public void SuccessPage()
        {
            mPagesErrors = 0;
            mChaptersErrors = 0;
        }

        public void FailPage()
        {
            mPagesErrors++;
        }

        private int mChaptersErrors = 0;
        private int mPagesErrors = 0;
        private int mAllowedChaptersErrors = 3;
        private int mAllowedPagesErrors = 3;
    }

}
