using System;

namespace NetMQ.InProcActors
{
    /// <summary>
    /// This was a class intended to hold constant strings that represented fixed, standard Actor messages.
    /// </summary>
    [Obsolete("Use NetMQActor.EndShimMessage. This will be removed in NetMQ 4.0.")]
    public class ActorKnownMessages
    {
        /// <summary>
        /// This known-actor message was a signal to terminate the pipe.
        /// </summary>
        [Obsolete("Use NetMQActor.EndShimMessage. This will be removed in NetMQ 4.0.")]
        public const string END_PIPE = "endPipe";
    }
}
