namespace ApiCoreDomain
{
    public interface IMangaClient
    {
        string Page(IMangaIdentifier identifier, int chapter, int? part, int page);
    }
}