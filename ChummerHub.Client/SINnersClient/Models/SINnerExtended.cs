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

    public partial class SINnerExtended
    {
        /// <summary>
        /// Initializes a new instance of the SINnerExtended class.
        /// </summary>
        public SINnerExtended() { }

        /// <summary>
        /// Initializes a new instance of the SINnerExtended class.
        /// </summary>
        public SINnerExtended(Guid? id = default(Guid?), Guid? siNnerId = default(Guid?), string jsonSummary = default(string))
        {
            Id = id;
            SiNnerId = siNnerId;
            JsonSummary = jsonSummary;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "siNnerId")]
        public Guid? SiNnerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jsonSummary")]
        public string JsonSummary { get; set; }

    }
}
