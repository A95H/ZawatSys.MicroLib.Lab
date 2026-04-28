using ZawatSys.MicroLib.Shared.Contracts.Common;

namespace ZawatSys.MicroLib.Lab.Domain.IntegrationEvents;

public class LabOrderDeliveredIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }
    public Guid LabOrderId { get; set; }
    public DateTimeOffset DeliveredAt { get; set; }
    public string? ReceivedBy { get; set; }
    public string? Notes { get; set; }
    public DateTimeOffset OccurredOn { get; set; }
}