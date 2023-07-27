using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.Data;
using WebApiCore.Models;
using WebApiCore.Services;

namespace WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiController : Controller
    {
        private readonly ILoaiRepo _loaiRepo;
        public LoaiController(ILoaiRepo loaiRepo)
        {
            _loaiRepo = loaiRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var dsLoai = _loaiRepo.GetAll();
            return Ok(dsLoai);
        }

        [HttpGet("{id}")]
        public IActionResult GetAll(int id)
        {
            var loai = _loaiRepo.GetById(id);
            return Ok(loai);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(LoaiModels model)
        {
            var loai = _loaiRepo.Create(model);
            return Ok(loai);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _loaiRepo.Delete(id);
           return Ok();
        }
    }
}
