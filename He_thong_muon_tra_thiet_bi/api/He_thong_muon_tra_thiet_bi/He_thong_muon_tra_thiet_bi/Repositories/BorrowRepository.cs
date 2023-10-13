using AutoMapper;
using Microsoft.EntityFrameworkCore;
using He_thong_muon_tra_thiet_bi.Data;
using He_thong_muon_tra_thiet_bi.Models;

namespace He_thong_muon_tra_thiet_bi.Repositories
{
    public class BorrowRepository : IBorrowRepository
    {
        private readonly DeviceContext _context;
        private readonly IMapper _mapper;
        public BorrowRepository(DeviceContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> AddBookAsync(BorrowModels model)
        {
            var newBook = _mapper.Map<BorrowData>(model);
            _context.borrowData!.Add(newBook);
            await _context.SaveChangesAsync();

            return newBook.Id;
        }

        public async Task DeleteBookAsync(int id)
        {
            var deleteBook = _context.borrowData!.SingleOrDefault(b => b.Id == id);
            if (deleteBook != null)
            {
                _context.borrowData!.Remove(deleteBook);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<BorrowModels>> GetAllBookAsync()
        {
            var books = await _context.borrowData!.ToListAsync();
            return _mapper.Map<List<BorrowModels>>(books);
        }

        public async Task<BorrowModels> GetBookAsync(int id)
        {
            var books = await _context.borrowData!.FindAsync(id);
            return _mapper.Map<BorrowModels>(books);
        }

        public async Task UpdateBookAsync(int id, BorrowModels model)
        {
            if (id == model.Id)
            {
                var updateBook = _mapper.Map<BorrowData>(model);
                updateBook.ReturnDate = DateTime.Now;
                _context.borrowData!.Update(updateBook);
                await _context.SaveChangesAsync();
            }
        }
    }
}
