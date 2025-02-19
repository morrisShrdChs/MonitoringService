using System.Collections.Concurrent;
using MonitoringService.Models;

namespace MonitoringService.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly ConcurrentDictionary<Guid, List<DeviceModel>> _storage = new();

        public void AddDeviceModel(DeviceModel model)
        {
            _storage.AddOrUpdate(model.Id,
                new List<DeviceModel> { model },
                (key, list) => { list.Add(model); return list; });
        }

        public IEnumerable<DeviceModel> GetAllDevices() => _storage.Values.SelectMany(x => x);

        public IEnumerable<DeviceModel> GetDeviceModels(Guid id) =>
            _storage.TryGetValue(id, out var activities) ? activities : Enumerable.Empty<DeviceModel>();
    }
}
