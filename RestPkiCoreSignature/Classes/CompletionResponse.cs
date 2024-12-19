using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestPkiCoreSignature.Classes
{
    public class CompletionResponse
    {

        [JsonProperty("signedFile")]
        public DocumentFileModel SignedFile { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

    }
}
