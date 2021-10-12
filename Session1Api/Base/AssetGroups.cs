namespace Session1Api.Base
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class AssetGroups
    {
        public AssetGroups()
        {
            this.Assets = new HashSet<Assets>();
        }
    
        public long ID { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public virtual ICollection<Assets> Assets { get; set; }
    }
}
