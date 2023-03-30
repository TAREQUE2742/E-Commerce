using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using E_Commerce.Domain;
using E_Commerce.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using E_Commerce.Dto;

namespace E_Commerce.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AccountController : ControllerBase
    {
        public ApplicationDbContext _context { get; set; }
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var data = await _context.AppUsers.ToListAsync();
            if(data.Count == 0){
                return Ok("No data found");
            }
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var user = await _context.AppUsers.Where((x) => x.Id == id).FirstOrDefaultAsync();
            if(user == null){
                return Ok("No user found with this ID");
            }
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> EditAsync(int id, [FromBody] AppUserRequest request) 
        {
            var user = await _context.AppUsers.Where((x) => x.Id == id).FirstOrDefaultAsync();
            if(user==null) return StatusCode(404,"User Not Found");

            user.Email = request.Email;
            user.FullName = request.FullName;
            user.Password = request.Password;
            user.Gender = request.Gender;
            await _context.SaveChangesAsync();
            return Ok(request);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync([FromRoute] int id) 
        {
            var user = await _context.AppUsers.Where(x => x.Id == id).FirstOrDefaultAsync();
            if(user==null) return StatusCode(404,"User Not Found");
            //var user = new AppUser() { Id = id};
           _context.AppUsers.Remove(user);
            await _context.SaveChangesAsync();
            
            return Ok(user);
        }


        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] AppUser appUser)
        {
            // first check username if exists show an error message
            await _context.AppUsers.AddAsync(new AppUser
            {
                Email = appUser.Email,
                FullName = appUser.FullName,
                Password = appUser.Password,
                Gender = appUser.Gender
            });
            await _context.SaveChangesAsync();
            return Ok();
        }


    }
}