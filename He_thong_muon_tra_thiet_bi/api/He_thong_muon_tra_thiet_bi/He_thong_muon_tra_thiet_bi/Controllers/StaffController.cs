using Microsoft.AspNetCore.Mvc;
using He_thong_muon_tra_thiet_bi.Models;
using He_thong_muon_tra_thiet_bi.Repositories;

namespace He_thong_muon_tra_thiet_bi.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class StaffController : ControllerBase
        {
            private readonly IStaffRepository _staffRepo;

            public StaffController(IStaffRepository repo)
            {
            _staffRepo = repo;
            }
            [HttpGet]
            public async Task<IActionResult> GetAllProduct()
            {
                try
                {
                    return Ok(await _staffRepo.GetAllStaffAsync());
                }
                catch
                {
                    return BadRequest();
                }
            }
            [HttpGet("{id:int}")]
            public async Task<IActionResult> GetstaffById(int id)
            {
                var staff = await _staffRepo.Getstaffsync(id);
                return staff == null ? NotFound() : Ok(staff);
            }

            [HttpGet("/name/{name}")]
            public async Task<IActionResult> GetstaffByName(string name)
            {
                var staff = await _staffRepo.GetstaffByDate(name);
                return staff == null ? NotFound() : Ok(staff);
            }


            [HttpPost]
            public async Task<IActionResult> AddNewBook(StaffModels modell)
            {
                try
                {
                    var newstaffId = await _staffRepo.Addstaffsync(modell);
                    var staff = await _staffRepo.Getstaffsync(newstaffId);
                    return staff == null ? NotFound() : Ok(staff);

                }
                catch
                {
                    return BadRequest();
                }
            }
            [HttpPut("{id}")]
            public async Task<IActionResult> Updatestaff(int id, StaffModels modell)
            {
                await _staffRepo.UpdatestaffAsync(id, modell);
                return Ok(modell);
            }
            [HttpDelete("{id}")]
            public async Task<IActionResult> Deletestaff([FromRoute] int id)
            {
                await _staffRepo.Deletestaffsync(id);

                return Ok("Delete data successfully");
            }
        }
}
