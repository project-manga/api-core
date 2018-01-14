namespace ApiCoreApp
{
    /// <summary>
    /// To be implemented from Environment classes.
    /// </summary>
    public interface IMangaEnvironment
    {
        /// <summary>
        /// Gets the full path for the page.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="chapter"></param>
        /// <param name="part"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        string FileNameFor(IMangaIdentifier identifier, int chapter, int? part, int page);
    }
}