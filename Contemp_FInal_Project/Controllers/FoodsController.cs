using Contemp_FInal_Project.Data;
using Contemp_FInal_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Signing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contemp_FInal_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly Contemp_FInal_ProjectContext _context;

        public FoodsController(Contemp_FInal_ProjectContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetFoods()
        {
            var foods = _context.Food.ToList();
            return Ok(foods);
        }

        [HttpGet("{id}")]
        public IActionResult GetFoods(int id)
        {
            Food food = _context.Food.Find(id);

            if (food == null || id == 0)
            {
               var foods = _context.Food.Take(5).ToList();
                return Ok(foods);
            }
            return Ok(food);
        }
        [HttpPost]
        public IActionResult PostFoods(Food food)
        {
            try
            {
                _context.Food.Add(food);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFood(int id) 
        {
            Food food = _context.Food.Find(id);
            if(id == null)
            {
                return NotFound();
            }
            try
            {
                _context.Food.Remove(food);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult PutFood(Food food)
        {
            try
            {
                _context.Entry(food).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}