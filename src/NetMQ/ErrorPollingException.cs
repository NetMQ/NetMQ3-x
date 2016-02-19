using System;
using JetBrains.Annotations;

namespace NetMQ
{
    /// <summary>
    /// ErrorPollingException is an Exception that had been used within the message-queueing system to signal polling-related errors.
    /// Use one of the NetMQException-derived exception classes instead.
    /// </summary>
    [Obsolete("This exception is unused in NetMQ and will be removed in NetMQ 4.0.")]
    public class ErrorPollingException : Exception
    {
        /// <summary>
        /// Create a new ErrorPollingException containing the given message and a reference to the given socket.
        /// </summary>
        /// <param name="message">the textual description of what gave rise to this exception, to be exposed as the Message property</param>
        /// <param name="socket">a reference to the socket, to be exposed via the Socket property</param>
        public ErrorPollingException([CanBeNull] string message, [NotNull] NetMQSocket socket)
            : base(message)
        {
            Socket = socket;
        }

        /// <summary>
        /// Get the NetMQSocket that this exception holds a reference to.
        /// </summary>
        [NotNull]
        public NetMQSocket Socket { get; private set; }
    }
}
