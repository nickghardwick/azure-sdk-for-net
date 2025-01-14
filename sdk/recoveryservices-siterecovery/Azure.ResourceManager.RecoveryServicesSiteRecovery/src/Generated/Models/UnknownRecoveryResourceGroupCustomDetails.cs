// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownRecoveryResourceGroupCustomDetails. </summary>
    internal partial class UnknownRecoveryResourceGroupCustomDetails : RecoveryResourceGroupCustomDetails
    {
        /// <summary> Initializes a new instance of UnknownRecoveryResourceGroupCustomDetails. </summary>
        /// <param name="resourceType"> The class type. </param>
        internal UnknownRecoveryResourceGroupCustomDetails(string resourceType) : base(resourceType)
        {
            ResourceType = resourceType ?? "Unknown";
        }
    }
}
