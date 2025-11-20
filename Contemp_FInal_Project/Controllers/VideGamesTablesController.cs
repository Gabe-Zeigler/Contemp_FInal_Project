using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Contemp_FInal_Project.Data;
using Contemp_FInal_Project.Tables;

namespace Contemp_FInal_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideGamesTablesController : ControllerBase
    {
        private readonly Context _context;

        public VideGamesTablesController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VideGamesTable>>> GetGames()
        {
            var gameList = _context.VideGamesTable.ToList();
            return Ok(gameList);
        }

        [HttpPost]
        public async Task<ActionResult<VideGamesTable>> PostGames(VideGamesTable videGamesTable)
        {
            try
            {
                _context.VideGamesTable.Add(videGamesTable);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult PutStudent(VideGamesTable videGamesTable)
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
                _context.Entry(videGamesTable).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGames(int id)
        {
            var videGamesTable = _context.VideGamesTable.Find(id);
            if (videGamesTable == null)
            {
                return NotFound();
            }
            try
            {
                _context.VideGamesTable.Remove(videGamesTable);
                _context.SaveChanges();
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }









        //[HttpGet]
        //public IActionResult GestStudents()
        //{
        //    var students = _context.Student.ToList();
        //    return Ok(students);
        //}
        //[HttpGet("{id}")]
        //public IActionResult GetStudent(int id)
        //{
        //    Student student = _context.Student.Find(id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(student);
        //}

        //[HttpPost]
        //public IActionResult PostStudent(Student student)
        //{
        //    try
        //    {
        //        _context.Student.Add(student);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    return Ok();
        //}

        //[HttpPut]
        //public IActionResult PutStudent(Student student)
        //{
        //    //var s = _context.Student.Find(student.Id);
        //    //if (s == null) {
        //    //    return NotFound();
        //    //}
        //    //s.Name = student.Name;
        //    //s.Age = student.Age;
        //    //_context.Student.Update(s);
        //    try
        //    {
        //        _context.Entry(student).State = EntityState.Modified;
        //        _context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound();
        //    }
        //    return Ok();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteStudent(int id)
        //{
        //    Student student = _context.Student.Find(id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }
        //    try
        //    {
        //        _context.Student.Remove(student);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    return Ok();
        //}
    }
}
