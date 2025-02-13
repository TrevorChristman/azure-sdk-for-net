// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Intelligence Pack containing a string name and boolean indicating if it&apos;s enabled. </summary>
    public partial class IntelligencePack
    {
        /// <summary> Initializes a new instance of IntelligencePack. </summary>
        internal IntelligencePack()
        {
        }

        /// <summary> Initializes a new instance of IntelligencePack. </summary>
        /// <param name="name"> The name of the intelligence pack. </param>
        /// <param name="enabled"> The enabled boolean for the intelligence pack. </param>
        /// <param name="displayName"> The display name of the intelligence pack. </param>
        internal IntelligencePack(string name, bool? enabled, string displayName)
        {
            Name = name;
            Enabled = enabled;
            DisplayName = displayName;
        }

        /// <summary> The name of the intelligence pack. </summary>
        public string Name { get; }
        /// <summary> The enabled boolean for the intelligence pack. </summary>
        public bool? Enabled { get; }
        /// <summary> The display name of the intelligence pack. </summary>
        public string DisplayName { get; }
    }
}
