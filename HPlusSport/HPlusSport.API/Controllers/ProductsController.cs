using HPlusSport.API.Data;
using HPlusSport.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace HPlusSport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;
        public ProductsController(ShopContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            return Ok(await _context.Products.ToListAsync());
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Product>> GetProduct([FromRoute] int id)
        {
            var Product = await _context.Products.FindAsync(id);
            if (Product == null)
            {
                return NotFound();
            }
            return Ok(Product);
        }

        [HttpPost]
        [Route("AddProduct")]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            /*if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            */
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                "GetProduct",
                new { id = product.Id },
                product);
        }

        [HttpPut]
        [Route("UpdateProduct/{id}")]
        public async Task<ActionResult> PutProduct([FromRoute] int id,
            [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            _context.Entry(product).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Products.Any(p => p.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<ActionResult<Product>> DeleteProduct([FromRoute] int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return product;
            }
        }

        //Deleting varius Products
        [HttpPost]
        [Route("Delete")]
        public async Task<ActionResult> DeleteMultipleProduct([FromQuery] int[] ids)
        {
            var products = new List<Product>();
            foreach(var id in ids)
            {
                var product = await _context.Products.FindAsync(id);
                if (product == null)
                {
                    return NotFound();
                }
                products.Add(product);
            }
            _context.Products.RemoveRange(products);
            await _context.SaveChangesAsync();
            return Ok(products);
        }
    }
}
