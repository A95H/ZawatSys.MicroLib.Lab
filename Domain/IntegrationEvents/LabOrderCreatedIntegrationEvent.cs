using ZawatSys.MicroLib.Lab.Domain.Enums;
using ZawatSys.MicroLib.Shared.Contracts.Common;

namespace ZawatSys.MicroLib.Lab.Domain.IntegrationEvents;

public class LabOrderCreatedIntegrationEvent : VersionedDomainIntegrationEvent
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }
    public Guid LabId { get; set; }
    public string LabName { get; set; } = string.Empty;
    public Guid PatientId { get; set; }
    public Guid DoctorId { get; set; }
    public Guid? EncounterId { get; set; }
    public Guid? ProcedureId { get; set; }
    public Guid? DiagnosisId { get; set; }
    public LabOrderStatus Status { get; set; }
    public LabOrderPriority Priority { get; set; }
    public DateTimeOffset? ExpectedDeliveryDate { get; set; }
    public string Notes { get; set; } = string.Empty;
    public List<LabOrderItemEventDto> Items { get; set; } = new();
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset OccurredOn { get; set; }
}

public class LabOrderItemEventDto
{
    public Guid Id { get; set; }
    public Guid LabTestId { get; set; }
    public string LabTestName { get; set; } = string.Empty;
    public string LabTestCode { get; set; } = string.Empty;
    public LabItemCategory Category { get; set; }
    public string Notes { get; set; } = string.Empty;
}