using Microsoft.Extensions.DependencyInjection;
using ZawatSys.MicroLib.Lab.Application.Abstractions.Repositories;
using ZawatSys.MicroLib.Lab.Application.Rules.CreationRules.Default;
using ZawatSys.MicroLib.Lab.Application.Rules.CreationRules.Interfaces;
using ZawatSys.MicroLib.Lab.Domain.Entities;
using ZawatSys.MicroLib.Lab.Domain.Enums;
using ZawatSys.MicroLib.Lab.Domain.Services;
using ZawatSys.MicroLib.Shared.Common.Models;

namespace ZawatSys.MicroLib.Lab.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLabDomainServices(this IServiceCollection services)
    {
        // Register domain services
        services.AddSingleton<LabDomainService>();

        // Register creation rule engine
        services.AddSingleton<ICreationRuleEngine, DefaultCreationRules>();

        // Note: Repository implementations to be provided by Infrastructure layer
        // services.AddScoped<ILabOrderRepository, LabOrderRepository>();
        // services.AddScoped<ILabTestRepository, LabTestRepository>();

        return services;
    }
}

public class PlaceholderLabOrderRepository : ILabOrderRepository
{
    public Task<LabOrder?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) => Task.FromResult<LabOrder?>(null);
    public Task<IReadOnlyList<LabOrder>> GetAllAsync(CancellationToken cancellationToken = default) => Task.FromResult<IReadOnlyList<LabOrder>>([]);
    public Task<LabOrder> AddAsync(LabOrder labOrder, CancellationToken cancellationToken = default) => Task.FromResult(labOrder);
    public Task UpdateAsync(LabOrder labOrder, CancellationToken cancellationToken = default) => Task.CompletedTask;
    public Task DeleteAsync(Guid id, CancellationToken cancellationToken = default) => Task.CompletedTask;
    public Task<IReadOnlyList<LabOrder>> GetByPatientIdAsync(Guid patientId, CancellationToken cancellationToken = default) => Task.FromResult<IReadOnlyList<LabOrder>>([]);
    public Task<IReadOnlyList<LabOrder>> GetByStatusAsync(LabOrderStatus status, CancellationToken cancellationToken = default) => Task.FromResult<IReadOnlyList<LabOrder>>([]);
    public Task<IReadOnlyList<LabOrder>> GetByLabIdAsync(Guid labId, CancellationToken cancellationToken = default) => Task.FromResult<IReadOnlyList<LabOrder>>([]);
    public Task<IReadOnlyList<LabOrder>> GetByTenantIdAsync(Guid tenantId, CancellationToken cancellationToken = default) => Task.FromResult<IReadOnlyList<LabOrder>>([]);
}

public class PlaceholderLabTestRepository : ILabTestRepository
{
    public Task<LabTest?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) => Task.FromResult<LabTest?>(null);
    public Task<LabTest?> GetByCodeAsync(string code, CancellationToken cancellationToken = default) => Task.FromResult<LabTest?>(null);
    public Task<IReadOnlyList<LabTest>> GetAllActiveAsync(CancellationToken cancellationToken = default) => Task.FromResult<IReadOnlyList<LabTest>>([]);
    public Task<LabTest> AddAsync(LabTest labTest, CancellationToken cancellationToken = default) => Task.FromResult(labTest);
    public Task UpdateAsync(LabTest labTest, CancellationToken cancellationToken = default) => Task.CompletedTask;
    public Task DeleteAsync(Guid id, CancellationToken cancellationToken = default) => Task.CompletedTask;
}