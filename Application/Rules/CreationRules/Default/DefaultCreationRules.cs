using ZawatSys.MicroLib.Lab.Application.Rules.CreationRules.Interfaces;
using ZawatSys.MicroLib.Shared.Contracts.Common;

namespace ZawatSys.MicroLib.Lab.Application.Rules.CreationRules.Default;

public class DefaultCreationRules : ICreationRuleEngine
{
    public Task<PlatformRuleResult> ValidateOrderCreationAsync(object orderRequest, CancellationToken cancellationToken = default)
    {
        // Default validation rules for lab order creation
        return Task.FromResult(PlatformRuleResult.Success());
    }

    public Task<PlatformRuleResult> ValidateTestAdditionAsync(Guid testId, CancellationToken cancellationToken = default)
    {
        // Default validation for adding tests to an order
        return Task.FromResult(PlatformRuleResult.Success());
    }

    public Task<string> GenerateOrderNumberAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult($"LAB-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString("N")[..8].ToUpper()}");
    }
}