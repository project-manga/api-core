namespace ApiCoreDomain
{
    public interface IMangaConnection
    {
        IMangaIdentifier Id { get; set; }
        int? ChapterPartStep { get; }
        int? EndingChapter { get; set; }
        int? EndingChapterPart { get; set; }
        int? EndingPage { get; set; }
        int StartingChapter { get; set; }
        int? StartingChapterPart { get; set; }
        int StartingPage { get; set; }
    }
}