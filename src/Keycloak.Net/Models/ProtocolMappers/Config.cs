using Newtonsoft.Json;

namespace Keycloak.Net.Models.ProtocolMappers
{
    public class Config
    {
        [JsonProperty("single")]
        public string Single { get; set; }
        [JsonProperty("attribute.name.format")]
        public string AttributeNameFormat { get; set; }
        [JsonProperty("attribute.name")]
        public string AttributeName { get; set; }
        [JsonProperty("userinfo.token.claim")]
        public string UserInfoTokenClaim { get; set; }
        [JsonProperty("user.attribute")]
        public string UserAttribute { get; set; }
        [JsonProperty("id.token.claim")]
        public string IdTokenClaim { get; set; }
        [JsonProperty("access.token.claim")]
        public string AccessTokenClaim { get; set; }
        [JsonProperty("claim.name")]
        public string ClaimName { get; set; }
        [JsonProperty("jsonType.label")]
        public string JsonTypelabel { get; set; }
        [JsonProperty("user.attribute.formatted")]
        public string UserAttributeFormatted { get; set; }
        [JsonProperty("user.attribute.country")]
        public string UserAttributeCountry { get; set; }
        [JsonProperty("user.attribute.postal_code")]
        public string UserAttributePostalCode { get; set; }
        [JsonProperty("user.attribute.street")]
        public string UserAttributeStreet { get; set; }
        [JsonProperty("user.attribute.region")]
        public string UserAttributeRegion { get; set; }
        [JsonProperty("user.attribute.locality")]
        public string UserAttributeLocality { get; set; }
        [JsonProperty("multi.valued")]
        public string Multivalued { get; set; }
        [JsonProperty("claim.value")]
        public string ClaimValue { get; set; }
    }
}