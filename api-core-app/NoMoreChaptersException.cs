namespace ApiCoreApp
{
    using System;

    /// <summary>
    /// Represents an exception indicating no more chapters 
    /// are available for a manga to download.
    /// </summary>
    [Serializable]
    internal class NoMoreChaptersException : Exception
    {
        public NoMoreChaptersException()
        {
        }
    }
}