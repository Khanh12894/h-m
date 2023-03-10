using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidAPI.Entities;
using SolidAPI.Intefaces;
using SolidAPI.Models;
using System.Threading.Tasks;

namespace SolidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        public IBuyerService _service;
        public BuyerController(IBuyerService service)
        {
            _service = service;
        }
        [HttpPost("Create")]
        public Task<bool> Create(BuyerModel model)
        {
            return _service.Create(model);
        }
    }
}
