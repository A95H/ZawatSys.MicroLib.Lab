using ZawatSys.MicroLib.Lab.Domain.Enums;
using ZawatSys.MicroLib.Shared.Common.Models;

namespace ZawatSys.MicroLib.Lab.Domain.Entities;

public class LabOrderStatusHistory : EntityBase
{
    public Guid LabOrderId { get; set; }
    public LabOrderStatus Status { get; set; }
    public Guid ChangedById { get; set; }
    public DateTimeOffset ChangedAt { get; set; }
    public string? Notes { get; set; }
}