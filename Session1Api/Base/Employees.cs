namespace Session1Api.Base
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        public Employees()
        {
            this.Assets = new HashSet<Assets>();
        }
    
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        [JsonIgnore]
        public virtual ICollection<Assets> Assets { get; set; }
    }
}
