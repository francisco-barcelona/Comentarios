using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEComentarios.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BEComentarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentarioController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public ComentarioController(AplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/Comentario
        [HttpGet]
        public ActionResult<List<Comentario>> Get()
        {
            try
            {
                var listComentario = _context.Comentario.ToList();
                return Ok(listComentario);

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Comentario/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Comentario> Get(int id)
        {
            try
            {
                var comentario = _context.Comentario.Find(id);
                if (comentario == null)
                {
                    return NotFound();
                } else
                {
                    return Ok(comentario);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Comentario
        [HttpPost]
        public ActionResult Post([FromBody] Comentario comentario)
        {
            try
            {
                _context.Add(comentario);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    

    // PUT: api/Comentario/5
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] Comentario comentario)
    {
        try
        {
            if (id != comentario.Id)
            {
                return BadRequest();
            }
            _context.Entry(comentario).State = EntityState.Modified;
            _context.Update(comentario);
            _context.SaveChanges();
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    } 


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var comentario = _context.Comentario.Find(id);
                if(comentario == null)
                {
                    return NotFound();
                }
                _context.Remove(comentario);
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
