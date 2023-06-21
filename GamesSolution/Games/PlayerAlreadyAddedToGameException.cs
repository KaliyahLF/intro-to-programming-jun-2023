using System.Runtime.Serialization;

namespace Games;
[Serializable]
internal class PlayerAlreadyAddedToGameException : Exception
{
    public PlayerAlreadyAddedToGameException()
    {
    }

    public PlayerAlreadyAddedToGameException(string? message) : base(message)
    {
    }

    public PlayerAlreadyAddedToGameException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected PlayerAlreadyAddedToGameException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}