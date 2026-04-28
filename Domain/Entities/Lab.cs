using ZawatSys.MicroLib.Shared.Common.Models;

namespace ZawatSys.MicroLib.Lab.Domain.Entities;

public class Lab : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public string? ContactInfo { get; set; }
    public Guid? AddressId { get; set; }
    public bool IsActive { get; set; } = true;
    public string NameSnapshot { get; set; } = string.Empty;
    public string? ContactSnapshot { get; set; }
}