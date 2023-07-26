using WebApiCore.Models;

namespace WebApiCore.Services
{
    public interface ILoaiRepo
    {
        List<LoaiVM> GetAll();
        LoaiVM GetById(int id);
        LoaiVM Create(LoaiModels loai);
        void Update(LoaiVM loai);
        void Delete(int id);
    }
}
