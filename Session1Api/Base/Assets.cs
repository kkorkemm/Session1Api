namespace Session1Api.Base
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Assets
    {
        public Assets()
        {
            this.AssetPhotos = new HashSet<AssetPhotos>();
            this.AssetTransferLogs = new HashSet<AssetTransferLogs>();
        }
    
        public long ID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public long DepartmentLocationID { get; set; }
        public long EmployeeID { get; set; }
        public long AssetGroupID { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> WarrantyDate { get; set; }

        [JsonIgnore]
        public virtual AssetGroups AssetGroups { get; set; }
        [JsonIgnore]
        public virtual ICollection<AssetPhotos> AssetPhotos { get; set; }
        [JsonIgnore]
        public virtual DepartmentLocations DepartmentLocations { get; set; }
        [JsonIgnore]
        public virtual Employees Employees { get; set; }
        [JsonIgnore]
        public virtual ICollection<AssetTransferLogs> AssetTransferLogs { get; set; }
    }
}
