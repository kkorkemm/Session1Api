namespace Session1Api.Base
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class AssetTransferLogs
    {
        public long ID { get; set; }
        public long AssetID { get; set; }
        public System.DateTime TransferDate { get; set; }
        public string FromAssetSN { get; set; }
        public string ToAssetSN { get; set; }
        public long FromDepartmentLocationID { get; set; }
        public long ToDepartmentLocationID { get; set; }

        [JsonIgnore]
        public virtual Assets Assets { get; set; }
        [JsonIgnore]
        public virtual DepartmentLocations DepartmentLocations { get; set; }
        [JsonIgnore]
        public virtual DepartmentLocations DepartmentLocations1 { get; set; }
    }
}
