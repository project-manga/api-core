namespace ApiCoreDomain
{
    using System;

    /// <summary>
    /// Represents an exception indicating no more pages 
    /// are available for a manga to download.
    /// </summary>
    [Serializable]
    public class NoMorePagesException : Exception
    {
    }
}