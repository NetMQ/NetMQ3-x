using System;

// ReSharper disable CheckNamespace
// ReSharper disable UnusedMember.Global

namespace NetMQ.zmq
{
    /// <summary>
    /// All public types have been moved out of the <see cref="NetMQ.Core"/> namespace. This class remains
    /// to prevent compile errors when users still have <c>using NetMQ.zmq;</c> in their code.
    /// </summary>
    [Obsolete("Don't use this type! It will be removed in NetMQ 4.0.")]
    public static class ThisNamespaceIsNotUsed { }
}