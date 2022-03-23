﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.PowerToys.Run.Plugin.System.Components
{
    internal class SystemPluginContext
    {
        /// <summary>
        /// Gets or sets the type of the result
        /// </summary>
        public ResultContextType Type { get; set; }

        /// <summary>
        /// Gets or sets the context data for the command/results
        /// </summary>
        public string Data { get; set; }
    }

    internal enum ResultContextType
    {
        Command, // Reserved for later usage
        NetworkAdapterInfo,
    }
}
