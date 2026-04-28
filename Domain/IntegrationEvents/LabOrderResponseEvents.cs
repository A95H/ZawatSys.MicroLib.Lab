using ZawatSys.MicroLib.Lab.Domain.Enums;
using ZawatSys.MicroLib.Shared.Contracts.Common;

namespace ZawatSys.MicroLib.Lab.Domain.IntegrationEvents;

public class UpdateLabOrderIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid LabOrderId { get; set; }
    public LabOrderPriority Priority { get; set; }
    public DateTimeOffset? ExpectedDeliveryDate { get; set; }
    public string? Notes { get; set; }
    public Guid TenantId { get; set; }
}

public class SetLabOrderStatusIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid LabOrderId { get; set; }
    public LabOrderStatus OldStatus { get; set; }
    public LabOrderStatus NewStatus { get; set; }
    public Guid TenantId { get; set; }
}

public class AddLabOrderItemIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid ItemId { get; set; }
    public Guid LabOrderId { get; set; }
    public LabItemCategory Category { get; set; }
    public string? Notes { get; set; }
    public Guid TenantId { get; set; }
}

public class AddLabAttachmentIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid AttachmentId { get; set; }
    public Guid LabOrderId { get; set; }
    public string FileUrl { get; set; } = string.Empty;
    public AttachmentType AttachmentType { get; set; }
    public Guid TenantId { get; set; }
}
