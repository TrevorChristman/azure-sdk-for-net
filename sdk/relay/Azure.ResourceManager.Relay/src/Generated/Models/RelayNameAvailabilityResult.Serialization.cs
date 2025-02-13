// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Relay.Models
{
    public partial class RelayNameAvailabilityResult
    {
        internal static RelayNameAvailabilityResult DeserializeRelayNameAvailabilityResult(JsonElement element)
        {
            Optional<string> message = default;
            Optional<bool> nameAvailable = default;
            Optional<RelayNameUnavailableReason> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nameAvailable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reason = new RelayNameUnavailableReason(property.Value.GetString());
                    continue;
                }
            }
            return new RelayNameAvailabilityResult(message.Value, Optional.ToNullable(nameAvailable), Optional.ToNullable(reason));
        }
    }
}
