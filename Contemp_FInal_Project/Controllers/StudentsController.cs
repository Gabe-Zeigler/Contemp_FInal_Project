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
    public class StudentsController : ControllerBase
    {
        private readonly Contemp_FInal_ProjectContext _context;

        public StudentsController(Contemp_FInal_ProjectContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetStudent()
        {
            var students = _context.Student.ToList();
            return Ok(students);
        }
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _context.Student.Find(id);
            if (student == null)
            {
                var students = _context.Student.Take(5).ToList();
                return Ok(students);
            }
            return Ok(student);

        }
        [HttpPost]
        public IActionResult PostStudent(Student student)
        {
            try
            {
                _context.Student.Add(student);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            Student student = _context.Student.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            try
            {
                _context.Student.Remove(student);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult PutStudent(Student student)
        {
            try
            {
                _context.Entry(student).State = EntityState.Modified;
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
