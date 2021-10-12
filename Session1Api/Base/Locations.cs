namespace Session1Api.Base
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Locations
    {
        public Locations()
        {
            this.DepartmentLocations = new HashSet<DepartmentLocations>();
        }
    
        public long ID { get; set; }
        public string Name { get; set; }
    
        [JsonIgnore]
        public virtual ICollection<DepartmentLocations> DepartmentLocations { get; set; }
    }
}
