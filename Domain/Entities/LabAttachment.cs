using ZawatSys.MicroLib.Lab.Domain.Enums;
using ZawatSys.MicroLib.Shared.Common.Models;

namespace ZawatSys.MicroLib.Lab.Domain.Entities;

public class LabAttachment : EntityBase
{
    public Guid LabOrderId { get; set; }
    public string FileUrl { get; set; } = string.Empty;
    public AttachmentType Type { get; set; }
}