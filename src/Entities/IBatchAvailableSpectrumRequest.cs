// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Whitespace.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Interface that represents a paws batch available spectrum request.
    /// </summary>
    public interface IBatchAvailableSpectrumRequest 
    {
        /// <summary>
        /// Gets or sets the device descriptor.
        /// </summary>
        [JsonProperty(PropertyName = Constants.PropertyNameDeviceDescriptor)]
        DeviceDescriptor DeviceDescriptor { get; set; }

        /// <summary>
        /// Gets or sets the device location.
        /// </summary>
        [JsonProperty(PropertyName = Constants.PropertyNameLocations)]
        GeoLocation[] Locations { get; set; }

        /// <summary>
        /// Gets or sets the master device location.
        /// </summary>
        /// <value>The master device location.</value>
        [JsonProperty(PropertyName = Constants.PropertyNameMasterDeviceLocation)]
        GeoLocation MasterDeviceLocation { get; set; }

        /// <summary>
        /// Gets or sets the device antenna.
        /// </summary>
        [JsonProperty(PropertyName = Constants.PropertyNameAntenna)]
        AntennaCharacteristics Antenna { get; set; }

        /// <summary>
        /// Gets or sets the device owner.
        /// </summary>
        [JsonProperty(PropertyName = Constants.PropertyNameOwner)]
        DeviceOwner Owner { get; set; }

        /// <summary>
        /// Gets or sets the device capabilities.
        /// </summary>
        [JsonProperty(PropertyName = Constants.PropertyNameCapabilities)]
        DeviceCapabilities Capabilities { get; set; }

        /// <summary>
        /// Gets or sets the master device descriptors.
        /// </summary>
        [JsonProperty(PropertyName = Constants.PropertyNameMasterDeviceDescriptors)]
        DeviceDescriptor MasterDeviceDescriptors { get; set; }

        /// <summary>
        /// Gets or sets the request.type.
        /// </summary>
        [JsonProperty(PropertyName = Constants.PropertyNameRequestType)]
        string RequestType { get; set; }
    }
}
