using ZawatSys.MicroLib.Shared.Common.Models;

namespace ZawatSys.MicroLib.Lab.Domain.Entities;

public class LabTest : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public bool IsActive { get; set; } = true;
}