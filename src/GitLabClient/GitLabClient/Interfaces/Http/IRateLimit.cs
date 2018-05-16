﻿namespace GitLabClient.Interfaces.Http
{
    using System;
    using System.Runtime.Serialization;

    using GitLabClient.Helpers.Attributes;

    public interface IRateLimit
        #if !NO_SERIALIZABLE
                : ISerializable
        #endif
    {
        /// <summary>
        /// The maximum number of requests that the consumer is permitted to make per hour
        /// </summary>
        int Limit { get; }

        /// <summary>
        /// The number of requests remaining in the current rate limit window
        /// </summary>
        int Remaining { get; }

        /// <summary>
        /// The date and time at which the current rate limit window resets
        /// </summary>
        [Parameter(Key = "ignoreThisField")]
        DateTimeOffset Reset { get; }
    }
}