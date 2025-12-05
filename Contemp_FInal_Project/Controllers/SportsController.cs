using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Contemp_FInal_Project.Data;
using Contemp_FInal_Project.Models;

namespace Contemp_FInal_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsController : ControllerBase
    {
        private readonly Contemp_FInal_ProjectContext _context;

        public SportsController(Contemp_FInal_ProjectContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetSport()
        {
            var sports = _context.Sport.ToList();
            return Ok(sports);
        }
        [HttpGet("{id}")]
        public IActionResult GetSport(int id)
        {
            var sport = _context.Sport.Find(id);
            if (sport == null)
            {
                var sports = _context.Sport.Take(5).ToList();
                return Ok(sports);
            }
            return Ok(sport);

        }
        [HttpPost]
        public IActionResult PostSport(Sport sport)
        {
            try
            {
                _context.Sport.Add(sport);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSport(int id)
        {
            Sport sport = _context.Sport.Find(id);
            if (sport == null)
            {
                return NotFound();
            }
            try
            {
                _context.Sport.Remove(sport);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult PutSport(Sport sport)
        {
            try
            {
                _context.Entry(sport).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
    }
}
