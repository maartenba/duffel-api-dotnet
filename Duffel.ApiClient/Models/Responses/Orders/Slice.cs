using System;
using System.Collections.Generic;
using Duffel.ApiClient.Converters.Json;
using Duffel.ApiClient.Models.Responses.Offers;
using Newtonsoft.Json;

namespace Duffel.ApiClient.Models.Responses.Orders
{
    public class Slice : ApiClient.Models.Responses.Slice
    {
        /// <summary>
        /// The conditions associated with this slice, describing the kinds of modifications you can make and any penalties that will apply to those modifications. This condition is applied only to this slice and to all the passengers associated with this order - for information at the order level (e.g. "what happens if I want to change all the slices?") refer to the conditions at the top level. If a particular kind of modification is allowed, you may not always be able to take action through the Duffel API. In some cases, you may need to contact the Duffel support team or the airline directly.
        /// </summary>
        [JsonProperty("conditions")]
        public Conditions Conditions { get; set; }

        [JsonProperty("duration")]
        [JsonConverter(typeof(StringDurationToTimeStampJsonConverter))]
        public TimeSpan Duration { get; set; }

        [JsonProperty("fare_brand_name")]
        public string FareBrandName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("segments")]
        public IEnumerable<Segment> Segments { get; set; }
    }
}
