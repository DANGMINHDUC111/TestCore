using WebApiCore.Data;
using WebApiCore.Models;

namespace WebApiCore.Services
{
    public class LoaiRepo : ILoaiRepo
    {
        private readonly MyDbContext _myDbContext;
        public LoaiRepo(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public LoaiVM Create(LoaiModels loai)
        {
            var x = new Loai()
            {
                TenLoai = loai.TenLoai
            };
            _myDbContext.Add(x);
            _myDbContext.SaveChanges();
            return new LoaiVM()
            {
                MaLoai = x.MaLoai,
                TenLoai = x.TenLoai
            };
        }

        public void Delete(int id)
        {
            var loai = _myDbContext.Loai.FirstOrDefault(x => x.MaLoai == id);
            if(loai != null)
            {
                _myDbContext.Remove(loai);
                _myDbContext.SaveChanges();
            }
        }

        public List<LoaiVM> GetAll()
        {
            return _myDbContext.Loai.Select(x => new LoaiVM
            {
                MaLoai = x.MaLoai,
                TenLoai = x.TenLoai,
            }).ToList();
        }

        public LoaiVM GetById(int id)
        {
            var loai = _myDbContext.Loai.FirstOrDefault(x => x.MaLoai == id);
            if (loai != null)
            {
                return new LoaiVM
                {
                    MaLoai = loai.MaLoai,
                    TenLoai = loai.TenLoai
                };
            }
            return new LoaiVM();
        }

        public void Update(LoaiVM loai)
        {
            var x = _myDbContext.Loai.FirstOrDefault(x => x.MaLoai == loai.MaLoai);
            if(x != null)
            {
                x.TenLoai = loai.TenLoai;
                _myDbContext.Update(x);
                _myDbContext.SaveChanges();
            }
        }
    }
}
