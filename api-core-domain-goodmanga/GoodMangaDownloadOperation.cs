namespace ApiCoreDomain.GoodManga
{
    using System;

    public class GoodMangaDownloadOperation : IMangaOperation
    {
        private readonly IMangaConnection mConnection;

        public GoodMangaDownloadOperation(IMangaConnection connection)
        {
            mConnection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public void Execute()
        {
            var command = new GoodMangaDownloadCommand(mConnection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                // TODO: log
                Console.WriteLine($"{mConnection.Id}: {reader.Chapter} {reader.Part.GetValueOrDefault()} {reader.Page}");
            }
        }
    }
}
