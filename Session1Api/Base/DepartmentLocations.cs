namespace Session1Api.Base
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class DepartmentLocations
    {
        public DepartmentLocations()
        {
            this.Assets = new HashSet<Assets>();
            this.AssetTransferLogs = new HashSet<AssetTransferLogs>();
            this.AssetTransferLogs1 = new HashSet<AssetTransferLogs>();
        }
    
        public long ID { get; set; }
        public long DepartmentID { get; set; }
        public long LocationID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<Assets> Assets { get; set; }
        [JsonIgnore]
        public virtual ICollection<AssetTransferLogs> AssetTransferLogs { get; set; }
        [JsonIgnore]
        public virtual ICollection<AssetTransferLogs> AssetTransferLogs1 { get; set; }
        [JsonIgnore]
        public virtual Departments Departments { get; set; }
        [JsonIgnore]
        public virtual Locations Locations { get; set; }
    }
}
