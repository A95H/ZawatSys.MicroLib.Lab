using ZawatSys.MicroLib.Lab.Domain.Entities;

namespace ZawatSys.MicroLib.Lab.Application.Abstractions.Repositories;

public interface ILabOrderItemRepository
{
    Task<LabOrderItem?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<LabOrderItem>> GetByLabOrderIdAsync(Guid labOrderId, CancellationToken cancellationToken = default);
    Task<LabOrderItem> AddAsync(LabOrderItem item, CancellationToken cancellationToken = default);
    Task UpdateAsync(LabOrderItem item, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}