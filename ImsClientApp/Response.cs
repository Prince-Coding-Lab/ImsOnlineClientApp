using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ImsClientApp
{
    public class OperationResponse
    {
       // [JsonPropertyName("HasSucceeded")]
        public bool HasSucceeded { get; set; }

        //[JsonPropertyName("IsDomainValidationErrors")]
        public bool IsDomainValidationErrors { get; set; }
      //  [JsonPropertyName("Message")]
        public string Message { get; set; }
       // [JsonPropertyName("StatusCode")]
        public string StatusCode { get; set; }
      //  [JsonPropertyName("ReturnedObject")] 
        public object ReturnedObject { get; set; }
    }
}
