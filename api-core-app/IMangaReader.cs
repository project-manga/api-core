namespace ApiCoreApp
{
    public interface IMangaReader
    {
        IMangaIdentifier Id { get; }
        int Chapter { get; }
        int Page { get; }
        int? Part { get; }

        bool Read();
    }
}