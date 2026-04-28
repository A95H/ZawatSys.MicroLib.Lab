using ZawatSys.MicroLib.Lab.Domain.Enums;
using ZawatSys.MicroLib.Shared.Contracts.Common;

namespace ZawatSys.MicroLib.Lab.Domain.IntegrationEvents;

public class LabOrderStatusChangedIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }
    public Guid LabOrderId { get; set; }
    public LabOrderStatus OldStatus { get; set; }
    public LabOrderStatus NewStatus { get; set; }
    public Guid ChangedById { get; set; }
    public string? Notes { get; set; }
    public DateTimeOffset OccurredOn { get; set; }
}