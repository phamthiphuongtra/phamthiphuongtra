using AutoMapper;
using Microsoft.EntityFrameworkCore;
using He_thong_muon_tra_thiet_bi.Data;
using He_thong_muon_tra_thiet_bi.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace He_thong_muon_tra_thiet_bi.Repositories
{
    public class StaffRepository: IStaffRepository
    {
        private readonly DeviceContext _context;
        private readonly IMapper _mapper;
        private StaffData updateStaff;

        public StaffRepository(DeviceContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> Addstaffsync(StaffModels model)
        {
            var newBook = _mapper.Map<StaffData>(model);
            _context.StaffData!.Add(newBook);
            await _context.SaveChangesAsync();

            return newBook.ID;
        }


        public async Task Deletestaffsync(int id)
        {
            var deleteBook = _context.StaffData!.SingleOrDefault(b => b.ID == id);
            if (deleteBook != null)
            {
                _context.StaffData!.Remove(deleteBook);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<StaffModels>> GetAllStaffAsync()
        {
            var books = await _context.StaffData!.ToListAsync();
            return _mapper.Map<List<StaffModels>>(books);
        }

        public async Task<StaffModels> Getstaffsync(int id)
        {
            var books = await _context.StaffData!.FindAsync(id);
            return _mapper.Map<StaffModels>(books);
        }

        public async Task<List<StaffModels>> GetstaffByDate(string name)
        {
            var books = await _context.StaffData!.Where(x => x.Date == name).ToListAsync();
            return _mapper.Map<List<StaffModels>>(books);
        }

        public async Task UpdatestaffAsync(int id, StaffModels model)
        {
            if (id == model.ID)
            {
                var updateStaff = _mapper.Map<StaffData>(model);
                _context.StaffData!.Update(updateStaff);
                await _context.SaveChangesAsync();
            }
        }

    }
}
