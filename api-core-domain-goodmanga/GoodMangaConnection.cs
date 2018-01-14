﻿namespace ApiCoreDomain.GoodManga
{
    public class GoodMangaConnection : IMangaConnection
    {
        public IMangaIdentifier Id { get; set; }
        public int StartingChapter { get; set; }
        public int? EndingChapter { get; set; }
        public int? StartingChapterPart { get; set; }
        public int? EndingChapterPart { get; set; }
        public int? ChapterPartStep { get; }
        public int StartingPage { get; set; }
        public int? EndingPage { get; set; }
    }
}
