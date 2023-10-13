using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using He_thong_muon_tra_thiet_bi.Models;
using He_thong_muon_tra_thiet_bi.Repositories;

namespace He_thong_muon_tra_thiet_bi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowController : ControllerBase
    {
        private readonly IBorrowRepository _bookRepo;

        public BorrowController(IBorrowRepository repo)
        {
            _bookRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            try
            {
                return Ok(await _bookRepo.GetAllBookAsync());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _bookRepo.GetBookAsync(id);
            return book == null ? NotFound() : Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(BorrowModels modell)
        {
            try
            {
                var newBookId = await _bookRepo.AddBookAsync(modell);
                var book = await _bookRepo.GetBookAsync(newBookId);
                return book == null ? NotFound() : Ok(book);

            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, BorrowModels modell)
        {
            await _bookRepo.UpdateBookAsync(id, modell);
            return Ok(modell);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            await _bookRepo.DeleteBookAsync(id);

            return Ok("Delete data successfully");
        }
    }
}
