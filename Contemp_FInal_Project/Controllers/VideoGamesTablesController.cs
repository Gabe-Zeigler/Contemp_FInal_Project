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
    public class VideoGamesTablesController : ControllerBase
    {
        private readonly Contemp_FInal_ProjectContext _context;

        public VideoGamesTablesController(Contemp_FInal_ProjectContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetGames()
        {
            var gameList = _context.VideoGamesTables.ToList();
            return Ok(gameList);
        }

        [HttpGet("{id}")]
        public IActionResult GetGamesId(int id)
        {
            var gameId = _context.VideoGamesTables.Find(id);
            if (id == null || id == 0)
            {
                var gameList = _context.VideoGamesTables.Take(5).ToList();
                return Ok(gameList);
            } else if (gameId == null)
            {
                return NotFound();
            }
            return Ok(gameId);
        }


        [HttpPost]
        public IActionResult PostGames(VideoGamesTable VideoGamesTable)
        {
            try
            {
                _context.VideoGamesTables.Add(VideoGamesTable);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult PutStudent(VideoGamesTable VideoGamesTable)
        {
            //var s = _context.Student.Find(student.Id);
            //if (s == null) {
            //    return NotFound();
            //}
            //s.Name = student.Name;
            //s.Age = student.Age;
            //_context.Student.Update(s);
            try
            {
                _context.Entry(VideoGamesTable).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGames(int id)
        {
            var VideoGamesTable = _context.VideoGamesTables.Find(id);
            if (VideoGamesTable == null)
            {
                return NotFound();
            }
            try
            {
                _context.VideoGamesTables.Remove(VideoGamesTable);
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
