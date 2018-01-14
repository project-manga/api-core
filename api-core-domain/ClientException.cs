namespace ApiCoreApp
{
    using System;

    /// <summary>
    /// Represents client exception.
    /// </summary>
    [Serializable]
    public class ClientException : Exception
    {
        public ClientException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}