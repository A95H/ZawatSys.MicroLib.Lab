using ZawatSys.MicroLib.Lab.Domain.Entities;
using ZawatSys.MicroLib.Lab.Domain.Enums;

namespace ZawatSys.MicroLib.Lab.Application.Abstractions.Repositories;

public interface ILabOrderRepository
{
    Task<Domain.Entities.LabOrder?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<Domain.Entities.LabOrder>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Domain.Entities.LabOrder> AddAsync(Domain.Entities.LabOrder order, CancellationToken cancellationToken = default);
    Task UpdateAsync(Domain.Entities.LabOrder order, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<Domain.Entities.LabOrder>> GetByPatientIdAsync(Guid patientId, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<Domain.Entities.LabOrder>> GetByStatusAsync(LabOrderStatus status, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<Domain.Entities.LabOrder>> GetByLabIdAsync(Guid labId, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<Domain.Entities.LabOrder>> GetByTenantIdAsync(Guid tenantId, CancellationToken cancellationToken = default);
}