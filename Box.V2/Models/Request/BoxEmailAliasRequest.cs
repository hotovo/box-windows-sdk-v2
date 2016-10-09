using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Box.V2.Models.Request
{
    /// <summary>
    /// A request class for making user alias requests
    /// </summary>
    public class BoxEmailAliasRequest
    {
        private const string FieldEmail = "email";

        /// <summary>
        /// Email field
        /// </summary>
        [JsonProperty(PropertyName = FieldEmail)]
        public string Email { get; set; }
    }
}
