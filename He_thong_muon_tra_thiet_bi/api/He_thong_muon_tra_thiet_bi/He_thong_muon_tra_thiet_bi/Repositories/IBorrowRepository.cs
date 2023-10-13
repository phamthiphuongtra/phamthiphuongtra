using He_thong_muon_tra_thiet_bi.Models;

namespace He_thong_muon_tra_thiet_bi.Repositories
{
    public interface IBorrowRepository
    {
        public Task<List<BorrowModels>> GetAllBookAsync();
        public Task<BorrowModels> GetBookAsync(int id);
        public Task<int> AddBookAsync(BorrowModels model);
        public Task UpdateBookAsync(int id, BorrowModels model);
        public Task DeleteBookAsync(int id);
    }
}
