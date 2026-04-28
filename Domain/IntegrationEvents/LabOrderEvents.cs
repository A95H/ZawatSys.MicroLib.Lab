using ZawatSys.MicroLib.Shared.Contracts.Common;

namespace ZawatSys.MicroLib.Lab.Domain.IntegrationEvents;

public abstract class VersionedDomainIntegrationEvent : IDomainIntegrationEvent
{
    public long Version { get; set; }
}



public class LabOrderCompletedIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid LabOrderId { get; set; }
    public string Results { get; set; } = string.Empty;
    public Guid TenantId { get; set; }
}

public class LabOrderCancelledIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid LabOrderId { get; set; }
    public string Reason { get; set; } = string.Empty;
    public Guid TenantId { get; set; }
}