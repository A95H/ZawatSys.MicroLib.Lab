using ZawatSys.MicroLib.Lab.Domain.Entities;

namespace ZawatSys.MicroLib.Lab.Application.Abstractions.Repositories;

public interface ILabRepository
{
    Task<Domain.Entities.Lab?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<Domain.Entities.Lab>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Domain.Entities.Lab> AddAsync(Domain.Entities.Lab lab, CancellationToken cancellationToken = default);
    Task UpdateAsync(Domain.Entities.Lab lab, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<Domain.Entities.Lab>> GetActiveAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<Domain.Entities.Lab>> GetByTenantIdAsync(Guid tenantId, CancellationToken cancellationToken = default);
}