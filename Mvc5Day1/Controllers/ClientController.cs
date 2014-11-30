﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Mvc5Day1.Models;

namespace Mvc5Day1.Controllers
{
    public class ClientController : ApiController
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        public ClientController()
        {
            db.Configuration.LazyLoadingEnabled = false;
        }
        // GET: api/Client
        public IQueryable<客戶資料> Get客戶資料()
        {
            return db.客戶資料;
        }

        // GET: api/Client/5
        [ResponseType(typeof(客戶資料))]
        public IHttpActionResult Get客戶資料(int id)
        {
            客戶資料 客戶資料 = db.客戶資料.Find(id);
            if (客戶資料 == null)
            {
                return NotFound();
            }

            return Ok(客戶資料);
        }

        // PUT: api/Client/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put客戶資料(int id, 客戶資料 客戶資料)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != 客戶資料.Id)
            {
                return BadRequest();
            }

            db.Entry(客戶資料).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!客戶資料Exists(id))
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

        // POST: api/Client
        [ResponseType(typeof(客戶資料))]
        public IHttpActionResult Post客戶資料(客戶資料 客戶資料)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.客戶資料.Add(客戶資料);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = 客戶資料.Id }, 客戶資料);
        }

        // DELETE: api/Client/5
        [ResponseType(typeof(客戶資料))]
        public IHttpActionResult Delete客戶資料(int id)
        {
            客戶資料 客戶資料 = db.客戶資料.Find(id);
            if (客戶資料 == null)
            {
                return NotFound();
            }

            db.客戶資料.Remove(客戶資料);
            db.SaveChanges();

            return Ok(客戶資料);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool 客戶資料Exists(int id)
        {
            return db.客戶資料.Count(e => e.Id == id) > 0;
        }
    }
}