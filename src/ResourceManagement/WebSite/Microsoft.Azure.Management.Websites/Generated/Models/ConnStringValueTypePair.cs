// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Database connection string value to type pair
    /// </summary>
    public partial class ConnStringValueTypePair
    {
        /// <summary>
        /// Initializes a new instance of the ConnStringValueTypePair class.
        /// </summary>
        public ConnStringValueTypePair() { }

        /// <summary>
        /// Initializes a new instance of the ConnStringValueTypePair class.
        /// </summary>
        public ConnStringValueTypePair(ConnectionStringType type, string value = default(string))
        {
            Value = value;
            Type = type;
        }

        /// <summary>
        /// Value of pair
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Type of database. Possible values include: 'MySql', 'SQLServer',
        /// 'SQLAzure', 'Custom', 'NotificationHub', 'ServiceBus',
        /// 'EventHub', 'ApiHub', 'DocDb', 'RedisCache'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ConnectionStringType Type { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}
