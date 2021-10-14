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
    public class AssetPhotosController : ApiController
    {
        private KazanNeftSession1DBEntities db = new KazanNeftSession1DBEntities();

        // GET: api/AssetPhotos
        [ResponseType(typeof(List<AssetPhotos>))]
        public IHttpActionResult GetAssetPhotos()
        {
            return Ok(db.AssetPhotos);
        }

        // GET: api/AssetPhotos/5
        [ResponseType(typeof(AssetPhotos))]
        public IHttpActionResult GetAssetPhotos(long id)
        {
            AssetPhotos assetPhotos = db.AssetPhotos.Find(id);
            if (assetPhotos == null)
            {
                return NotFound();
            }

            return Ok(assetPhotos);
        }

        // POST: api/AssetPhotos
        [ResponseType(typeof(AssetPhotos))]
        public IHttpActionResult PostAssetPhotos(AssetPhotos assetPhotos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AssetPhotos.Add(assetPhotos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = assetPhotos.ID }, assetPhotos);
        }
    }
}