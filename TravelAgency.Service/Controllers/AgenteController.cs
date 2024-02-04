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
using TravelAgency.Datos.Persistencia.Core;

namespace TravelAgency.Service.Controllers
{
    public class AgenteController : ApiController
    {
        IAgenteServicios _agenteServicio;

        #region Constructor
        public AgenteController(IAgenteServicios agenteServicios)
        {
            _agenteServicio = agenteServicios;
        }
        #endregion

        // GET: api/Agente
        public IEnumerable<AgenteDTO> GetAgenteDTO()
        {
            return _agenteServicio.ObtenerTodos().AsEnumerable();
        }

        // GET: api/Agente/5

        public AgenteDTO GetAgenteDTO(int id)
        {
            var agenteDTO = _agenteServicio.ObtenerId(id);
            if (agenteDTO == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return agenteDTO;
        }

        // PUT: api/Agente/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutAgenteDTO(int id, AgenteDTO agenteDTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != agenteDTO.IdAgente)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(agenteDTO).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AgenteDTOExists(id))
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

        //// POST: api/Agente
        //[ResponseType(typeof(AgenteDTO))]
        //public IHttpActionResult PostAgenteDTO(AgenteDTO agenteDTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.AgenteDTO.Add(agenteDTO);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = agenteDTO.IdAgente }, agenteDTO);
        //}

        //// DELETE: api/Agente/5
        //[ResponseType(typeof(AgenteDTO))]
        //public IHttpActionResult DeleteAgenteDTO(int id)
        //{
        //    AgenteDTO agenteDTO = db.AgenteDTO.Find(id);
        //    if (agenteDTO == null)
        //    {
        //        return NotFound();
        //    }

        //    db.AgenteDTO.Remove(agenteDTO);
        //    db.SaveChanges();

        //    return Ok(agenteDTO);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool AgenteDTOExists(int id)
        //{
        //    return db.AgenteDTO.Count(e => e.IdAgente == id) > 0;
        //}
    }
}