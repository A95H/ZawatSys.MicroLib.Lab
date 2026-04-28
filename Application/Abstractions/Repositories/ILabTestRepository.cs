using ZawatSys.MicroLib.Lab.Domain.Entities;

namespace ZawatSys.MicroLib.Lab.Application.Abstractions.Repositories;

public interface ILabTestRepository
{
    Task<LabTest?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<LabTest?> GetByCodeAsync(string code, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<LabTest>> GetAllActiveAsync(CancellationToken cancellationToken = default);
    Task<LabTest> AddAsync(LabTest labTest, CancellationToken cancellationToken = default);
    Task UpdateAsync(LabTest labTest, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}