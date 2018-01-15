namespace ApiCoreDomain
{
    using System;
    using System.IO;

    public class MangaEnvironment : IMangaEnvironment
    {
        public string FileNameFor(IMangaPageIdentifier identifier)
        {
            return Path.Combine(
                Environment.CurrentDirectory,
                "Downloads",
                $"{identifier.MangaId.ForUri()}_{identifier.Chapter:0000}_{identifier.Part:00}_{identifier.Page:0000}.jpg");
        }
    }
}
