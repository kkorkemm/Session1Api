using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session1Api.Models
{
    using Base;

    public class AssetsModel
    {
        public AssetsModel(Assets asset)
        {
            ID = asset.ID;
            AssetName = asset.AssetName;
            DepartmentName = asset.DepartmentLocations.Departments.Name;
            AssetSN = asset.AssetSN;
            Description = asset.Description;
            WarrantyDate = Convert.ToDateTime(asset.WarrantyDate);
            AssetGroup = asset.AssetGroups;
            Department = asset.DepartmentLocations.Departments;
            Location = asset.DepartmentLocations.Locations;
        }

        public long ID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public DateTime WarrantyDate { get; set; }


        public AssetGroups AssetGroup { get; set; }
        public Departments Department { get; set; }
        public Locations Location { get; set; }
        
    }
}