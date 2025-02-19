using Microsoft.AspNetCore.SignalR;
using MonitoringService.Models;

namespace MonitoringService.Services
{
    public interface IDeviceService
    {
        void AddDeviceModel(DeviceModel model);
        IEnumerable<DeviceModel> GetAllDevices();
        IEnumerable<DeviceModel> GetDeviceModels(Guid id);

    }
}
