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
        [ResponseType(typeof(List<AssetTransferLogs>))]
        public IHttpActionResult GetAssetTransferLogs()
        {
            return Ok(db.AssetTransferLogs.ToList().ConvertAll(p => new AssetDepartmentModels(p)));
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

            return Ok(new AssetDepartmentModels(assetTransferLogs));
        }

        // PUT: api/AssetTransferLogs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAssetTransferLogs(long id, AssetTransferLogs assetTransferLogs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != assetTransferLogs.ID)
            {
                return BadRequest();
            }

            db.Entry(assetTransferLogs).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetTransferLogsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AssetTransferLogs
        [ResponseType(typeof(AssetTransferLogs))]
        public IHttpActionResult PostAssetTransferLogs(AssetTransferLogs assetTransferLogs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AssetTransferLogs.Add(assetTransferLogs);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = assetTransferLogs.ID }, assetTransferLogs);
        }

        // DELETE: api/AssetTransferLogs/5
        [ResponseType(typeof(AssetTransferLogs))]
        public IHttpActionResult DeleteAssetTransferLogs(long id)
        {
            AssetTransferLogs assetTransferLogs = db.AssetTransferLogs.Find(id);
            if (assetTransferLogs == null)
            {
                return NotFound();
            }

            db.AssetTransferLogs.Remove(assetTransferLogs);
            db.SaveChanges();

            return Ok(assetTransferLogs);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AssetTransferLogsExists(long id)
        {
            return db.AssetTransferLogs.Count(e => e.ID == id) > 0;
        }
    }
}