namespace api_core_console_client
{
    using ApiCoreDomain.GoodManga;
    using System;
    using System.IO;
    using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            var sid = ReadLine();
            var ch = int.Parse(ReadLine());
            var page = int.Parse(ReadLine());

            var cnn = new GoodMangaConnection
            {
                Id = new GoodMangaIdentifier(sid),
                StartingChapter = ch,
                StartingPage = page
            };

            if (!Directory.Exists(Path.Combine(Environment.CurrentDirectory, "Downloads")))
                Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "Downloads"));
            new GoodMangaDownloadOperation(cnn).Execute();
        }
    }
}
