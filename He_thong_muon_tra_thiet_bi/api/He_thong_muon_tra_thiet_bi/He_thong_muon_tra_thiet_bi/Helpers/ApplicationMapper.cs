using AutoMapper;
using He_thong_muon_tra_thiet_bi.Data;
using He_thong_muon_tra_thiet_bi.Models;

namespace He_thong_muon_tra_thiet_bi.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<BorrowData, BorrowModels>().ReverseMap();
            CreateMap<DeviceData, DeviceModels>().ReverseMap();
            CreateMap<StaffData, StaffModels>().ReverseMap();
        }
    }
}
