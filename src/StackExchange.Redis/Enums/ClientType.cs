using System;
using System.ComponentModel;

namespace StackExchange.Redis
{
    /// <summary>
    /// The class of the connection
    /// </summary>
    public enum ClientType
    {
        /// <summary>
        /// Regular connections, including MONITOR connections
        /// </summary>
        Normal = 0,
        /// <summary>
        /// Replication connections
        /// </summary>
        Replica = 1, // / as an implementation detail, note that enum.ToString without [Flags] preferes *earlier* values
        /// <summary>
        /// Subscription connections
        /// </summary>
        PubSub = 2,
    }
}
