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

    public class AssetTransferLogsController : ApiController
    {
        private KazanNeftSession1DBEntities db = new KazanNeftSession1DBEntities();

        // GET: api/AssetTransferLogs
        [ResponseType(typeof(AssetTransferLogs))]
        public IHttpActionResult GetAssetTransferLogs()
        {
            return Ok(db.AssetTransferLogs.ToList().ConvertAll(p => new HistoryModel(p)));
        }

        // GET: api/AssetTransferLogs/5
        [ResponseType(typeof(AssetTransferLogs))]
        public IHttpActionResult GetAssetTransferLogs(long id)
        {
            AssetTransferLogs assetTransferLogs = db.AssetTransferLogs.Find(id);
            if (assetTransferLogs == null)
            {
                return NotFound();
            }

            return Ok(new HistoryModel(assetTransferLogs));
        }
    }
}