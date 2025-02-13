// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list runbook operation. </summary>
    internal partial class RunbookListResult
    {
        /// <summary> Initializes a new instance of RunbookListResult. </summary>
        internal RunbookListResult()
        {
            Value = new ChangeTrackingList<RunbookData>();
        }

        /// <summary> Initializes a new instance of RunbookListResult. </summary>
        /// <param name="value"> Gets or sets a list of runbooks. </param>
        /// <param name="nextLink"> Gets or sets the next link. </param>
        internal RunbookListResult(IReadOnlyList<RunbookData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets or sets a list of runbooks. </summary>
        public IReadOnlyList<RunbookData> Value { get; }
        /// <summary> Gets or sets the next link. </summary>
        public string NextLink { get; }
    }
}
