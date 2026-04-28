using ZawatSys.MicroLib.Lab.Domain.Enums;
using ZawatSys.MicroLib.Shared.Contracts.Common;

namespace ZawatSys.MicroLib.Lab.Domain.Commands;

public class CreateLabOrderIntegrationCmd : IDomainIntegrationCommand
{
    public Guid LabId { get; set; }
    public string LabNameSnapshot { get; set; } = string.Empty;
    public string? LabContactSnapshot { get; set; }

    public Guid PatientId { get; set; }
    public Guid DoctorId { get; set; }

    public Guid? EncounterId { get; set; }
    public Guid? ProcedureId { get; set; }
    public Guid? DiagnosisId { get; set; }

    public LabOrderPriority Priority { get; set; } = LabOrderPriority.Normal;
    public DateTimeOffset? ExpectedDeliveryDate { get; set; }
    public string? Notes { get; set; }
}

public class UpdateLabOrderIntegrationCmd : IDomainIntegrationCommand
{
    public Guid LabOrderId { get; set; }
    public LabOrderPriority Priority { get; set; }
    public DateTimeOffset? ExpectedDeliveryDate { get; set; }
    public string? Notes { get; set; }
}

public class SetLabOrderStatusIntegrationCmd : IDomainIntegrationCommand
{
    public Guid LabOrderId { get; set; }
    public LabOrderStatus Status { get; set; }
    public string? Notes { get; set; }
}

public class AddLabOrderItemIntegrationCmd : IDomainIntegrationCommand
{
    public Guid LabOrderId { get; set; }
    public Guid ItemTypeId { get; set; }
    public string LabTestName { get; set; } = string.Empty;
    public string LabTestCode { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string? Notes { get; set; }
}

public class AddLabAttachmentIntegrationCmd : IDomainIntegrationCommand
{
    public Guid LabOrderId { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string FileUrl { get; set; } = string.Empty;
    public string AttachmentType { get; set; } = string.Empty;
    public string? Notes { get; set; }
}
