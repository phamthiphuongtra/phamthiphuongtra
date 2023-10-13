using He_thong_muon_tra_thiet_bi.Models;

namespace He_thong_muon_tra_thiet_bi.Repositories
{
    public interface IDeviceRepository
    {
        public Task<List<DeviceModels>> GetAllDeviceAsync();
        public Task<DeviceModels> GetDeviceAsync(int id);
        public Task<int> AddDeviceAsync(DeviceModels model);
        public Task UpdateDeviceAsync(int id, DeviceModels model);
        public Task DeleteDeviceAsync(int id);
    }
}
