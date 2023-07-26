using WebApiCore.Data;
using WebApiCore.Models.Page;

namespace WebApiCore.Services
{
    public class HangHoaRepo : IHangHoaRepo
    {
        private readonly MyDbContext _context;
        public HangHoaRepo(MyDbContext context)
        {
            _context = context;
        }

        public HangHoa Create(HangHoa model)
        {
            _context.HangHoa.Add(model);
            _context.SaveChanges();
            return model;
        }

        public FilterResource<HangHoa> GetAll(string? search, int pageIndex, int pageSize)
        {
            var allProduct = _context.HangHoa.Where(x => string.IsNullOrEmpty(search) || (x.TenHangHoa != null && x.TenHangHoa.Contains(search))).AsQueryable();
            var rs = PaginatedList<HangHoa>.GetData(allProduct, pageIndex, pageSize);
            return rs;
        }
    }
}
