﻿namespace ApiCoreApp.GoodManga
{
    using System;
    using System.IO;

    public class GoodMangaEnvironment : IGoodMangaEnvironment
    {
        public string FileNameFor(IMangaIdentifier identifier, int chapter, int? part, int page)
        {
            return Path.Combine(
                Environment.CurrentDirectory,
                "Downloads",
                $"{identifier.ForUri()}_{chapter:0000}_{part:00}_{page:0000}.jpg");
        }
    }
}
