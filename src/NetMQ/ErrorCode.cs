using System;

namespace NetMQ
{
    /// <summary>
    /// This enum-type represents the various numeric socket-related error codes.
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// The provided endpoint is not connected.
        /// </summary>
        EndpointNotFound = 2,

        /// <summary>
        /// The requested address is already in use.
        /// </summary>
        AddressAlreadyInUse = 48,

        /// <summary>
        /// Non-blocking mode was requested and the message cannot be sent at the moment.
        /// </summary>
        TryAgain = 35,

        /// <summary>
        /// Permission denied
        /// </summary>
        AccessDenied = 13,

        /// <summary>
        /// The endpoint supplied is invalid.
        /// </summary>
        Invalid = 22,

        /// <summary>
        /// The connection is still in progress.
        /// </summary>
        InProgress = 36,

        /// <summary>
        /// The connection is still in progress.
        /// </summary>
        [Obsolete("Use InProgress. This will be removed in NetMQ 4.0.")]
        InProgres = 36,

        /// <summary>
        /// The requested transport protocol is not supported.
        /// </summary>
        ProtocolNotSupported = 43,

        /// <summary>
        /// The provided context is invalid.
        /// </summary>
        Fault = 14,

        /// <summary>
        /// The requested address was not available.
        /// For Bind operations, that can mean the address was not local.
        /// </summary>
        AddressNotAvailable = 49,

        /// <summary>
        /// The network appears to be down.
        /// </summary>
        NetworkDown = 50,

        /// <summary>
        /// There is not enough buffer space for the requested operation.
        /// </summary>
        NoBufferSpaceAvailable = 55,

        /// <summary>
        /// The socket is not connected.
        /// </summary>
        NotConnected = 57,

        /// <summary>
        /// The connection was refused.
        /// </summary>
        ConnectionRefused = 61,

        /// <summary>
        /// The host is not reachable.
        /// </summary>
        HostUnreachable = 65,

        /// <summary>
        /// This is the value chosen for beginning the range of 0MQ error codes.
        /// </summary>
        BaseErrorNumber = 156384712,

        /// <summary>
        /// The message is too long.
        /// </summary>
        MessageSize = BaseErrorNumber + 10,

        /// <summary>
        /// The address family is not supported by this protocol.
        /// </summary>
        AddressFamilyNotSupported = BaseErrorNumber + 11,

        /// <summary>
        /// The network is apparently not reachable.
        /// </summary>
        NetworkUnreachable = BaseErrorNumber + 12,

        /// <summary>
        /// The connection-attempt has apparently been aborted.
        /// </summary>
        ConnectionAborted = BaseErrorNumber + 13,

        /// <summary>
        /// The connection has apparently been reset.
        /// </summary>
        ConnectionReset = BaseErrorNumber + 14,

        /// <summary>
        /// The operation timed-out.
        /// </summary>
        TimedOut = BaseErrorNumber + 16,

        /// <summary>
        /// The connection has apparently been reset.
        /// </summary>
        NetworkReset = BaseErrorNumber + 18,

        /// <summary>
        /// The operation cannot be performed on this socket at the moment due
        /// to the socket not being in the appropriate state.
        /// </summary>
        FiniteStateMachine = BaseErrorNumber + 51,

        /// <summary>
        /// The context associated with the specified socket has already been terminated.
        /// </summary>
        ContextTerminated = BaseErrorNumber + 53,

        /// <summary>
        /// No I/O thread is available to accomplish this task.
        /// </summary>
        EmptyThread = BaseErrorNumber + 54,

        /// <summary>
        /// Too many sockets for this process.
        /// </summary>
        TooManyOpenSockets = BaseErrorNumber + 107,

        /// <summary>
        /// The provided endpoint is not connected.
        /// </summary>
        [Obsolete("Use EndpointNotFound. This will be removed in NetMQ 4.0.")]
        ENOENT = 2,

        /// <summary>
        /// The operation was interrupted by a signal.
        /// </summary>
        [Obsolete("Not in use. This will be removed in NetMQ 4.0.")]
        EINTR = 4,

        /// <summary>
        /// Permission denied
        /// </summary>
        [Obsolete("Use AccessDenied. This will be removed in NetMQ 4.0.")]
        EACCESS = 13,

        /// <summary>
        /// The provided context is invalid.
        /// </summary>
        [Obsolete("Use Fault. This will be removed in NetMQ 4.0.")]
        EFAULT = 14,

        /// <summary>
        /// The endpoint supplied is invalid.
        /// </summary>
        [Obsolete("Use Invalid. This will be removed in NetMQ 4.0.")]
        EINVAL = 22,

        /// <summary>
        /// Non-blocking mode was requested and the message cannot be sent at the moment.
        /// </summary>
        [Obsolete("Use TryAgain. This will be removed in NetMQ 4.0.")]
        EAGAIN = 35,

        /// <summary>
        /// The connection is still in progress.
        /// </summary>
        [Obsolete("Use InProgress. This will be removed in NetMQ 4.0.")]
        EINPROGRESS = 36,

        /// <summary>
        /// The requested transport protocol is not supported.
        /// </summary>
        [Obsolete("Use ProtocolNotSupported. This will be removed in NetMQ 4.0.")]
        EPROTONOSUPPORT = 43,

        /// <summary>
        /// That operation is not supported by this socket type.
        /// </summary>
        [Obsolete("Not in use. This will be removed in NetMQ 4.0.")]
        ENOTSUP = 45,

        /// <summary>
        /// The requested address is already in use.
        /// </summary>
        [Obsolete("Use AddressAlreadyInUse. This will be removed in NetMQ 4.0.")]
        EADDRINUSE = 48,

        /// <summary>
        /// The requested address was not available.
        /// For Bind operations, that can mean the address was not local.
        /// </summary>
        [Obsolete("Use AddressNotAvailable. This will be removed in NetMQ 4.0.")]
        EADDRNOTAVAIL = 49,

        /// <summary>
        /// The network appears to be down.
        /// </summary>
        [Obsolete("Use NetworkDown. This will be removed in NetMQ 4.0.")]
        ENETDOWN = 50,

        /// <summary>
        /// There is not enough buffer space for the requested operation.
        /// </summary>
        [Obsolete("Use NoBufferSpaceAvailable. This will be removed in NetMQ 4.0.")]
        ENOBUFS = 55,

        /// <summary>
        /// Unused
        /// </summary>
        [Obsolete("Not in use. This will be removed in NetMQ 4.0.")]
        EISCONN = 56,

        /// <summary>
        /// The socket is not connected.
        /// </summary>
        [Obsolete("Use NotConnected. This will be removed in NetMQ 4.0.")]
        ENOTCONN = 57,

        /// <summary>
        /// The connection was refused.
        /// </summary>
        [Obsolete("Use ConnectionRefused. This will be removed in NetMQ 4.0.")]
        ECONNREFUSED = 61,

        /// <summary>
        /// The host is not reachable.
        /// </summary>
        [Obsolete("Use HostUnreachable. This will be removed in NetMQ 4.0.")]
        EHOSTUNREACH = 65,

        /// <summary>
        /// This is the value chosen for beginning the range of 0MQ error codes.
        /// </summary>
        [Obsolete("Use BaseErrorNumber. This will be removed in NetMQ 4.0.")]
        ZMQ_HAUSNUMERO = BaseErrorNumber,

        /// <summary>
        /// The provided socket was invalid.
        /// </summary>
        [Obsolete("Not in use. This will be removed in NetMQ 4.0.")]
        ENOTSOCK = BaseErrorNumber + 9,

        /// <summary>
        /// The message is too long.
        /// </summary>
        [Obsolete("Use MessageSize. This will be removed in NetMQ 4.0.")]
        EMSGSIZE = BaseErrorNumber + 10,

        /// <summary>
        /// The address family is not supported by this protocol.
        /// </summary>
        [Obsolete("Use AddressFamilyNotSupported. This will be removed in NetMQ 4.0.")]
        EAFNOSUPPORT = BaseErrorNumber + 11,

        /// <summary>
        /// The network is apparently not reachable.
        /// </summary>
        [Obsolete("Use NetworkUnreachable. This will be removed in NetMQ 4.0.")]
        ENETUNREACH = BaseErrorNumber + 12,

        /// <summary>
        /// The connection-attempt has apparently been aborted.
        /// </summary>
        [Obsolete("Use ConnectionAborted. This will be removed in NetMQ 4.0.")]
        ECONNABORTED = BaseErrorNumber + 13,

        /// <summary>
        /// The connection has apparently been reset.
        /// </summary>
        [Obsolete("Use ConnectionReset. This will be removed in NetMQ 4.0.")]
        ECONNRESET = BaseErrorNumber + 14,

        /// <summary>
        /// The operation timed-out.
        /// </summary>
        [Obsolete("Use TimedOut. This will be removed in NetMQ 4.0.")]
        ETIMEDOUT = BaseErrorNumber + 16,

        /// <summary>
        /// The network was reset.
        /// </summary>
        [Obsolete("Use NetworkReset. This will be removed in NetMQ 4.0.")]
        ENETRESET = BaseErrorNumber + 18,

        /// <summary>
        /// The operation cannot be performed on this socket at the moment due
        /// to the socket not being in the appropriate state.
        /// </summary>
        [Obsolete("Use FiniteStateMachine. This will be removed in NetMQ 4.0.")]
        EFSM = BaseErrorNumber + 51,

        /// <summary>
        /// The requested transport protocol is not compatible with the socket type.
        /// </summary>
        [Obsolete("Not in use. This will be removed in NetMQ 4.0.")]
        ENOCOMPATPROTO = BaseErrorNumber + 52,

        /// <summary>
        /// The context associated with the specified socket has already been terminated.
        /// </summary>
        [Obsolete("Use ContextTerminated. This will be removed in NetMQ 4.0.")]
        ETERM = BaseErrorNumber + 53,

        /// <summary>
        /// No I/O thread is available to accomplish this task.
        /// </summary>
        [Obsolete("Use EmptyThread. This will be removed in NetMQ 4.0.")]
        EMTHREAD = BaseErrorNumber + 54,

        /// <summary>
        /// Unused
        /// </summary>
        [Obsolete("Not In Use. This will be removed in NetMQ 4.0.")]
        EIOEXC = BaseErrorNumber + 105,

        /// <summary>
        /// Unused
        /// </summary>
        [Obsolete("This will be removed in NetMQ 4.0.")]
        ESOCKET = BaseErrorNumber + 106,

        /// <summary>
        /// Too many sockets for this process.
        /// </summary>
        [Obsolete("Use TooManyOpenSockets. This will be removed in NetMQ 4.0.")]
        EMFILE = BaseErrorNumber + 107
    }
}