using Microsoft.AspNetCore.Mvc;
using He_thong_muon_tra_thiet_bi.Models;
using He_thong_muon_tra_thiet_bi.Repositories;

namespace He_thong_muon_tra_thiet_bi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceRepository _bookRepo;

        public DeviceController(IDeviceRepository repo)
        {
            _bookRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            try
            {
                return Ok(await _bookRepo.GetAllDeviceAsync());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeviceById(int id)
        {
            var book = await _bookRepo.GetDeviceAsync(id);
            return book == null ? NotFound() : Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(DeviceModels modell)
        {
            try
            {
                var newBookId = await _bookRepo.AddDeviceAsync(modell);
                var book = await _bookRepo.GetDeviceAsync(newBookId);
                return book == null ? NotFound() : Ok(book);

            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, DeviceModels modell)
        {
            await _bookRepo.UpdateDeviceAsync(id, modell);
            return Ok(modell);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            await _bookRepo.DeleteDeviceAsync(id);

            return Ok("Delete data successfully");
        }
    }
}
