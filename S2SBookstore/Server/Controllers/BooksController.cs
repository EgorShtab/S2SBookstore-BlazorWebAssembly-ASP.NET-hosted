using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using S2SBookstore.Server.Data;
using S2SBookstore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2SBookstore.Server.Controllers
{
    [Route("api/[controller]/{id?}")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        protected readonly AppDBContext db;
        public BooksController(AppDBContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Books.OrderBy(x=>x.Author));
        }
        [HttpDelete]
        public IActionResult Delete(int bookID)
        {
            try
            {
                var book = db.Books.Where(b => b.ID == bookID).FirstOrDefault();
                db.Books.Remove(book);
                db.SaveChanges();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
