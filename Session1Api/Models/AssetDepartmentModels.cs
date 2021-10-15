using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session1Api.Models
{
    using Base;

    public class AssetDepartmentModels
    {
        public AssetDepartmentModels(AssetTransferLogs logs)
        {
            AssetID = logs.AssetID;
            TransferDate = logs.TransferDate;
            FromAssetSN = logs.FromAssetSN;
            ToAssetSN = logs.ToAssetSN;

            var departmentLocationFROM = AppData.GetContext().DepartmentLocations.Where(p => p.ID == logs.FromDepartmentLocationID).FirstOrDefault();

            FromDepartment = AppData.GetContext().Departments.Where(p => p.ID == departmentLocationFROM.DepartmentID).FirstOrDefault().Name;

            var departmentlocationTO = AppData.GetContext().DepartmentLocations.Where(p => p.ID == logs.ToDepartmentLocationID).FirstOrDefault();

            ToDepartment = AppData.GetContext().Departments.Where(p => p.ID == departmentlocationTO.DepartmentID).FirstOrDefault().Name;
        }

        public long AssetID { get; set; }
        public DateTime TransferDate { get; set; }
        public string FromAssetSN { get; set; }
        public string ToAssetSN { get; set; }
        public string FromDepartment { get; set; }
        public string ToDepartment { get; set; }
    }
}