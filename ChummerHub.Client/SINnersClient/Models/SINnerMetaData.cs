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

    public partial class SINnerMetaData
    {
        /// <summary>
        /// Initializes a new instance of the SINnerMetaData class.
        /// </summary>
        public SINnerMetaData() { }

        /// <summary>
        /// Initializes a new instance of the SINnerMetaData class.
        /// </summary>
        public SINnerMetaData(Guid? id = default(Guid?), SINnerVisibility visibility = default(SINnerVisibility), IList<Tag> tags = default(IList<Tag>))
        {
            Id = id;
            Visibility = visibility;
            Tags = tags;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "visibility")]
        public SINnerVisibility Visibility { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<Tag> Tags { get; set; }

    }
}