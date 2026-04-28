using ZawatSys.MicroLib.Lab.Domain.Entities;

namespace ZawatSys.MicroLib.Lab.Application.Abstractions.Repositories;

public interface ILabAttachmentRepository
{
    Task<LabAttachment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<LabAttachment>> GetByLabOrderIdAsync(Guid labOrderId, CancellationToken cancellationToken = default);
    Task<LabAttachment> AddAsync(LabAttachment attachment, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}