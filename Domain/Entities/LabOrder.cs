using System;
using System.Collections.Generic;
using System.Text.Json;
using ZawatSys.MicroLib.Lab.Domain.Enums;
using ZawatSys.MicroLib.Shared.Common.Models;

namespace ZawatSys.MicroLib.Lab.Domain.Entities;

public class LabOrder : TenantEntity
{
    public Guid LabId { get; set; }
    public string LabNameSnapshot { get; set; } = string.Empty;
    public string LabContactSnapshot { get; set; } = string.Empty;
    public Guid PatientId { get; set; }
    public Guid DoctorId { get; set; }
    public Guid? EncounterId { get; set; }
    public Guid? ProcedureId { get; set; }
    public Guid? DiagnosisId { get; set; }
    public LabOrderStatus Status { get; set; } = LabOrderStatus.Draft;
    public LabOrderPriority Priority { get; set; } = LabOrderPriority.Normal;
    public DateTimeOffset? ExpectedDeliveryDate { get; set; }
    public string? Notes { get; set; }

    private readonly List<LabOrderItem> _items = new();
    public IReadOnlyCollection<LabOrderItem> Items => _items.AsReadOnly();

    private readonly List<LabAttachment> _attachments = new();
    public IReadOnlyCollection<LabAttachment> Attachments => _attachments.AsReadOnly();

    private readonly List<LabOrderStatusHistory> _statusHistory = new();
    public IReadOnlyCollection<LabOrderStatusHistory> StatusHistory => _statusHistory.AsReadOnly();

    public void AddItem(LabOrderItem item)
    {
        item.LabOrderId = Id;
        _items.Add(item);
    }

    public void RemoveItem(Guid itemId)
    {
        var item = _items.FirstOrDefault(i => i.Id == itemId);
        if (item != null)
        {
            _items.Remove(item);
        }
    }

    public void AddAttachment(LabAttachment attachment)
    {
        attachment.LabOrderId = Id;
        _attachments.Add(attachment);
    }

    public void RemoveAttachment(Guid attachmentId)
    {
        var attachment = _attachments.FirstOrDefault(a => a.Id == attachmentId);
        if (attachment != null)
        {
            _attachments.Remove(attachment);
        }
    }

    public void AddStatusHistoryEntry(LabOrderStatusHistory historyEntry)
    {
        historyEntry.LabOrderId = Id;
        _statusHistory.Add(historyEntry);
    }

    public void UpdateStatus(LabOrderStatus newStatus, Guid changedById, string? notes = null)
    {
        var historyEntry = new LabOrderStatusHistory
        {
            Id = Guid.CreateVersion7(),
            Status = newStatus,
            ChangedById = changedById,
            ChangedAt = DateTimeOffset.UtcNow,
            Notes = notes
        };
        
        AddStatusHistoryEntry(historyEntry);
        Status = newStatus;
    }
}