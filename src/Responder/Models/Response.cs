﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Phlank.Responder
{
    /// <summary>
    /// Content model for deserializing responses generated by the <see cref="IResponder"/>.
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Warnings regarding the attempted operation.
        /// </summary>
        [JsonProperty(PropertyName = "warnings", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonPropertyName("warnings")]
        public IEnumerable<Warning> Warnings { get; set; }

        /// <summary>
        /// The content to return back to the user as a result of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonPropertyName("data")]
        public object Data { get; set; }

        /// <summary>
        /// An error which occured while trying to fulfill the request of the client.
        /// </summary>
        [JsonProperty(PropertyName = "error", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonPropertyName("error")]
        public ApiError Error { get; set; }
    }

    /// <summary>
    /// Content model for deserializing responses generated by the <see cref="IResponder"/>.
    /// </summary>
    public class Response<T> where T : class
    {
        /// <summary>
        /// Warnings regarding the attempted operation.
        /// </summary>
        [JsonProperty(PropertyName = "warnings", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonPropertyName("warnings")]
        public IEnumerable<Warning> Warnings { get; set; }

        /// <summary>
        /// The content to return back to the user as a result of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonPropertyName("data")]
        public T Data { get; set; }

        /// <summary>
        /// An error which occured while trying to fulfill the request of the client.
        /// </summary>
        [JsonProperty(PropertyName = "error", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonPropertyName("error")]
        public ApiError Error { get; set; }
    }
}
