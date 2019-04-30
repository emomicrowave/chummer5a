﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SINners.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class SINSearchGroupResult
    {
        /// <summary>
        /// Initializes a new instance of the SINSearchGroupResult class.
        /// </summary>
        public SINSearchGroupResult() { }

        /// <summary>
        /// Initializes a new instance of the SINSearchGroupResult class.
        /// </summary>
        public SINSearchGroupResult(IList<string> roles = default(IList<string>), ChummerHubVersion version = default(ChummerHubVersion), IList<SINnerSearchGroup> sinGroups = default(IList<SINnerSearchGroup>), string errorText = default(string))
        {
            Roles = roles;
            Version = version;
            SinGroups = sinGroups;
            ErrorText = errorText;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<string> Roles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public ChummerHubVersion Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sinGroups")]
        public IList<SINnerSearchGroup> SinGroups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorText")]
        public string ErrorText { get; set; }

    }
}