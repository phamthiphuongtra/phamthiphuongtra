using Microsoft.EntityFrameworkCore;
namespace He_thong_muon_tra_thiet_bi.Data
{
    public class DeviceContext : DbContext
    {
        public DeviceContext(DbContextOptions<DeviceContext> opt) : base(opt)
        {

        }
        #region DbSet
        public DbSet<BorrowData> borrowData { get; set; }
        public DbSet<DeviceData> DeviceData { get; set; }
        public DbSet<StaffData> StaffData { get; set; }
        #endregion
    }
}
