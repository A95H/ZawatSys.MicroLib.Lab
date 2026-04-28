using ZawatSys.MicroLib.Shared.Contracts.Common;

namespace ZawatSys.MicroLib.Lab.Application.Rules.CreationRules.Interfaces;

public interface ICreationRuleEngine
{
    Task<PlatformRuleResult> ValidateOrderCreationAsync(object orderRequest, CancellationToken cancellationToken = default);
    Task<PlatformRuleResult> ValidateTestAdditionAsync(Guid testId, CancellationToken cancellationToken = default);
    Task<string> GenerateOrderNumberAsync(CancellationToken cancellationToken = default);
}