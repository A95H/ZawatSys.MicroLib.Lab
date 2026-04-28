using System;
using System.Text.Json;
using ZawatSys.MicroLib.Lab.Domain.Enums;
using ZawatSys.MicroLib.Shared.Common.Models;

namespace ZawatSys.MicroLib.Lab.Domain.Entities;

public class LabOrderItem : EntityBase
{
    public Guid LabOrderId { get; set; }
    public Guid ItemTypeId { get; set; }
    public LabItemCategory Category { get; set; }
    public int Quantity { get; set; } = 1;
    public string? Notes { get; set; }
    public JsonDocument? Metadata { get; set; }
}