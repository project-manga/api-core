namespace ApiCoreDomain
{
    public interface IMangaConnection
    {
        IMangaIdentifier Id { get; }
        int? ChapterPartStep { get; }
        int? EndingChapter { get; }
        int? EndingChapterPart { get; }
        int? EndingPage { get; }
        int StartingChapter { get; }
        int? StartingChapterPart { get; }
        int StartingPage { get; }
    }
}