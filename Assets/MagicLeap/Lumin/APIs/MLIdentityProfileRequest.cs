// %BANNER_BEGIN%
// ---------------------------------------------------------------------
// %COPYRIGHT_BEGIN%
// <copyright file = "MLIdentityProfileRequest.cs" company="Magic Leap, Inc">
//
// Copyright (c) 2018-present, Magic Leap, Inc. All Rights Reserved.
//
// </copyright>
// %COPYRIGHT_END%
// ---------------------------------------------------------------------
// %BANNER_END%

namespace UnityEngine.XR.MagicLeap
{
    using System;

    /// <summary>
    /// Functionality to query for user profiles.
    /// </summary>
    public partial class MLIdentity
    {
        /// <summary>
        /// Public representation of MLIdentity.Profile.
        /// Represents a set of attribute of a user's profile.
        /// </summary>
        public partial class Profile
        {
            /// <summary>
            /// Represents a request for profile attributes.
            /// </summary>
            public class Request
            {
                #if PLATFORM_LUMIN
                /// <summary>
                /// Gets or sets the delegate for the callback to notify when the request has finished.
                /// </summary>
                /// <param name="result">The MLResult of the request.</param>
                public delegate void RequestAttibutesDelegate(MLResult result);
                #endif

                /// <summary>
                /// The different states a request can be in.
                /// </summary>
                public enum State
                {
                    /// <summary>
                    /// The request is currently querying for attribute names.
                    /// </summary>
                    REQUEST_ATTRIB_NAMES,

                    /// <summary>
                    /// The request is currently listening for attribute names.
                    /// </summary>
                    LISTENING_ATTRIB_NAMES,

                    /// <summary>
                    /// The request is currently querying for attribute values.
                    /// </summary>
                    REQUEST_ATTRIB_VALUES,

                    /// <summary>
                    /// The request is currently listening for attribute values.
                    /// </summary>
                    LISTENING_ATTRIB_VALUES,

                    /// <summary>
                    /// The request has finished.
                    /// </summary>
                    DONE
                }

                #if PLATFORM_LUMIN
                /// <summary>
                /// Gets or sets the current state of the request.
                /// </summary>
                public State RequestState { get; set; }

                /// <summary>
                /// Gets or sets the callback to notify when the request has finished.
                /// </summary>
                public RequestAttibutesDelegate Callback { get; set; }

                /// <summary>
                /// Gets or sets the current result code of this request.
                /// </summary>
                public MLResult.Code ResultCode { get; set; }
                #endif
            }
        }
    }
}
