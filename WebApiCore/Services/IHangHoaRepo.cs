using WebApiCore.Data;
using WebApiCore.Models.Page;

namespace WebApiCore.Services
{
    public interface IHangHoaRepo
    {
        public FilterResource<HangHoa> GetAll(string? search, int pageIndex, int pageSize);
        public HangHoa Create(HangHoa model);
    }
}
