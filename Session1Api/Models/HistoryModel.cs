using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session1Api.Models
{
    using Base;

    public class HistoryModel
    {
        public HistoryModel(AssetTransferLogs transferLogs)
        {
            AssetID = transferLogs.AssetID;
            TransferDate = transferLogs.TransferDate;
            DepartmentFrom = transferLogs.DepartmentLocations.Departments.Name;
            DepartmentTo = transferLogs.DepartmentLocations1.Departments.Name;
            AssetSnFrom = transferLogs.FromAssetSN;
            AssetSnTo = transferLogs.ToAssetSN;
        }

        public long AssetID { get; set; }
        public DateTime TransferDate { get; set; }
        public string DepartmentFrom { get; set; }
        public string DepartmentTo { get; set; }
        public string AssetSnFrom { get; set; }
        public string AssetSnTo { get; set; }
    }
}