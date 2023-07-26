using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.Data;
using WebApiCore.Services;

namespace WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IHangHoaRepo _hoaRepo;
        public ProductController(IHangHoaRepo hoaRepo)
        {
            _hoaRepo = hoaRepo;
        }

        /// <summary>
        /// Get all
        /// </summary>
        /// <param name="search"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllProduct(string? search, int pageIndex, int pageSize)
        {
            try
            {
                var rs = _hoaRepo.GetAll(search, pageIndex, pageSize);
                return Ok(rs);
            }
            catch
            {
                return BadRequest("we can't get product");
            }
        }
        [HttpPost]
        public IActionResult Add(HangHoa model)
        {
            try
            {
                var rs = _hoaRepo.Create(model);
                return Ok(rs);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
