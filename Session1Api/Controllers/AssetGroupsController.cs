using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Session1Api.Base;

namespace Session1Api.Controllers
{
    using Models;

    public class AssetGroupsController : ApiController
    {
        private KazanNeftSession1DBEntities db = new KazanNeftSession1DBEntities();

        // GET: api/AssetGroups
        [ResponseType(typeof(List<AssetGroups>))]
        public IHttpActionResult GetAssetGroups()
        {
            return Ok(db.AssetGroups.ToList().ConvertAll(p => new AssetGroupModel(p)));
        }

        // GET: api/AssetGroups/5
        [ResponseType(typeof(AssetGroups))]
        public IHttpActionResult GetAssetGroups(long id)
        {
            AssetGroups assetGroups = db.AssetGroups.Find(id);
            if (assetGroups == null)
            {
                return NotFound();
            }

            return Ok(assetGroups);
        }
    }
}