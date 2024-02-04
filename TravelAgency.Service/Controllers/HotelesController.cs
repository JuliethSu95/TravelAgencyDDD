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
using TravelAgency.Aplicacion.Contratos;
using TravelAgency.Aplicacion.Core;
using TravelAgency.Aplicacion.Implementacion;
using TravelAgency.Datos.Persistencia.Core;

namespace TravelAgency.Service.Controllers
{
    public class HotelesController : ApiController
    {
        IHotelesServicios _hotelesServicio;

        #region Constructor
        public HotelesController(IHotelesServicios hotelesServicios)
        {
            _hotelesServicio = hotelesServicios;
        }
        #endregion

        // GET: api/Hoteles
        public IEnumerable<HotelesDTO> GetAgenteDTO()
        {
            return _hotelesServicio.ObtenerTodos().AsEnumerable();
        }

        // GET: api/Hoteles/5
        public HotelesDTO GetAgenteDTO(int id)
        {
            var hotelesDTO = _hotelesServicio.ObtenerId(id);
            if (hotelesDTO == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return hotelesDTO;
        }

        //// PUT: api/Hoteles/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutHotelesDTO(int id, HotelesDTO hotelesDTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != hotelesDTO.IdHotel)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(hotelesDTO).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!HotelesDTOExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Hoteles
        //[ResponseType(typeof(HotelesDTO))]
        //public IHttpActionResult PostHotelesDTO(HotelesDTO hotelesDTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.HotelesDTO.Add(hotelesDTO);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = hotelesDTO.IdHotel }, hotelesDTO);
        //}

        //// DELETE: api/Hoteles/5
        //[ResponseType(typeof(HotelesDTO))]
        //public IHttpActionResult DeleteHotelesDTO(int id)
        //{
        //    HotelesDTO hotelesDTO = db.HotelesDTO.Find(id);
        //    if (hotelesDTO == null)
        //    {
        //        return NotFound();
        //    }

        //    db.HotelesDTO.Remove(hotelesDTO);
        //    db.SaveChanges();

        //    return Ok(hotelesDTO);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool HotelesDTOExists(int id)
        //{
        //    return db.HotelesDTO.Count(e => e.IdHotel == id) > 0;
        //}
    }
}