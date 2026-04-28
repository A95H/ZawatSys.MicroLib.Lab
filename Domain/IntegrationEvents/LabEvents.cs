using ZawatSys.MicroLib.Shared.Contracts.Common;

namespace ZawatSys.MicroLib.Lab.Domain.IntegrationEvents;

public class LabCreatedIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid LabId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? ContactInfo { get; set; }
    public Guid? AddressId { get; set; }
    public bool IsActive { get; set; }
    public Guid TenantId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}

public class LabUpdatedIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid LabId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? ContactInfo { get; set; }
    public Guid? AddressId { get; set; }
    public Guid TenantId { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}

public class LabActivatedIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid LabId { get; set; }
    public Guid TenantId { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}

public class LabDeactivatedIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid LabId { get; set; }
    public Guid TenantId { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}

public class LabDeletedIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid LabId { get; set; }
    public Guid TenantId { get; set; }
    public DateTimeOffset DeletedAt { get; set; }
}
