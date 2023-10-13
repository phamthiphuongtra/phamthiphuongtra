using He_thong_muon_tra_thiet_bi.Models;

namespace He_thong_muon_tra_thiet_bi.Repositories
{
    public interface IStaffRepository
    {
        public Task<List<StaffModels>> GetAllStaffAsync();
        public Task<StaffModels> Getstaffsync(int id);
        public Task<List<StaffModels>> GetstaffByDate(string name);
        public Task<int> Addstaffsync(StaffModels model);
        public Task UpdatestaffAsync(int id, StaffModels model);
        public Task Deletestaffsync(int id);
    }
}
