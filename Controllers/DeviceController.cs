using Microsoft.AspNetCore.Mvc;
using MonitoringService.Services;
using MonitoringService.Models;

namespace MonitoringService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _deviceService;

        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }
        [HttpPost]
        public IActionResult ReceiveDeviceModel([FromBody] DeviceModel model)
        {
            _deviceService.AddDeviceModel(model);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllDevices()
        {
            return Ok(_deviceService.GetAllDevices());
        }

        [HttpGet("{id}")]
        public IActionResult GetDevices(Guid id)
        {
            return Ok(_deviceService.GetDeviceModels(id));
        }
    }
}
