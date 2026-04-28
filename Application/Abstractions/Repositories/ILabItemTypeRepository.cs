using ZawatSys.MicroLib.Lab.Domain.Entities;
using ZawatSys.MicroLib.Lab.Domain.Enums;

namespace ZawatSys.MicroLib.Lab.Application.Abstractions.Repositories;

public interface ILabItemTypeRepository
{
    Task<LabItemType?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<LabItemType>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<LabItemType>> GetActiveAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<LabItemType>> GetByCategoryAsync(LabItemCategory category, CancellationToken cancellationToken = default);
    Task<LabItemType> AddAsync(LabItemType itemType, CancellationToken cancellationToken = default);
    Task UpdateAsync(LabItemType itemType, CancellationToken cancellationToken = default);
}