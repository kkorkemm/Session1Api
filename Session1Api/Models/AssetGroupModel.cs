using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session1Api.Models
{
    using Base;

    public class AssetGroupModel
    {
        public AssetGroupModel(AssetGroups assetGroup)
        {
            ID = assetGroup.ID;
            Name = assetGroup.Name;
        }

        public long ID { get; set; }
        public string Name { get; set; }
    }
}