using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RestPkiCoreSignature.Classes
{



    public class StartResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("failure")]
        public string Failure { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("toSign")]
        public ToSign ToSign { get; set; }

        [JsonProperty("toSignHash")]
        public ToSignHash ToSignHash { get; set; }

    }
    
    public class ToSign
    {
        [JsonProperty("signatureAlgorithm")]
        public SignatureAlgorithm SignatureAlgorithm { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("digestInfo")]
        public string DigestInfo { get; set; }
    }

    public class SignatureAlgorithm
    {
        [JsonProperty("algorithm")]
        public string Algorithm { get; set; }

        [JsonProperty("oid")]
        public string Oid { get; set; }

        [JsonProperty("digestAlgorithm")]
        public string DigestAlgorithm { get; set; }

        [JsonProperty("digestAlgorithmOid")]
        public string DigestAlgorithmOid { get; set; }
    }

    public class ToSignHash
    {
        [JsonProperty("algorithm")]
        public string Algorithm { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("hexValue")]
        public string HexValue { get; set; }
    }
}



