using AutoMapper;
using Microsoft.EntityFrameworkCore;
using He_thong_muon_tra_thiet_bi.Data;
using He_thong_muon_tra_thiet_bi.Models;

namespace He_thong_muon_tra_thiet_bi.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly DeviceContext _context;
        private readonly IMapper _mapper;
        public DeviceRepository(DeviceContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> AddDeviceAsync(DeviceModels model)
        {
            var newDevice = _mapper.Map<DeviceData>(model);
            _context.DeviceData!.Add(newDevice);
            await _context.SaveChangesAsync();

            return newDevice.ID;
        }

        public async Task DeleteDeviceAsync(int id)
        {
            var deleteDevice = _context.DeviceData!.SingleOrDefault(b => b.ID == id);
            if (deleteDevice != null)
            {
                _context.DeviceData!.Remove(deleteDevice);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<DeviceModels>> GetAllDeviceAsync()
        {
            var Device = await _context.DeviceData!.ToListAsync();
            return _mapper.Map<List<DeviceModels>>(Device);
        }

        public async Task<DeviceModels> GetDeviceAsync(int id)
        {
            var Device = await _context.DeviceData!.FindAsync(id);
            return _mapper.Map<DeviceModels>(Device);
        }

        public async Task UpdateDeviceAsync(int id, DeviceModels model)
        {
            if (id == model.ID)
            {
                var updateDevice = _mapper.Map<DeviceData>(model);
                _context.DeviceData!.Update(updateDevice);
                await _context.SaveChangesAsync();
            }
        }
    }
}
