using ZawatSys.MicroLib.Shared.Contracts.Common;

namespace ZawatSys.MicroLib.Lab.Domain.Commands;

public class CreateLabIntegrationCmd : IDomainIntegrationCommand
{
    public string Name { get; set; } = string.Empty;
    public string? ContactInfo { get; set; }
    public Guid? AddressId { get; set; }
}

public class UpdateLabIntegrationCmd : IDomainIntegrationCommand
{
    public Guid LabId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? ContactInfo { get; set; }
    public Guid? AddressId { get; set; }
}

public class ActivateLabIntegrationCmd : IDomainIntegrationCommand
{
    public Guid LabId { get; set; }
}

public class DeactivateLabIntegrationCmd : IDomainIntegrationCommand
{
    public Guid LabId { get; set; }
}

public class DeleteLabIntegrationCmd : IDomainIntegrationCommand
{
    public Guid LabId { get; set; }
}
