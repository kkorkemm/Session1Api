namespace Session1Api.Base
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class AssetPhotos
    {
        public long ID { get; set; }
        public long AssetID { get; set; }
        public byte[] AssetPhoto { get; set; }

        [JsonIgnore]
        public virtual Assets Assets { get; set; }
    }
}
