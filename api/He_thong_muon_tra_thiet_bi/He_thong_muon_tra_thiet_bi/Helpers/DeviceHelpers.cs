using AutoMapper;
using He_thong_muon_tra_thiet_bi.Data;
using He_thong_muon_tra_thiet_bi.Models;

namespace He_thong_muon_tra_thiet_bi.Helpers
{
    public class DeviceHelpers : Profile
    {
        public DeviceHelpers() 
        {
            CreateMap<DeviceData, DeviceModels>().ReverseMap();
            CreateMap<StaffData, StaffModels>().ReverseMap();
        }
    }
}
