using System.Text.Json;
using ZawatSys.MicroLib.Lab.Domain.Enums;
using ZawatSys.MicroLib.Shared.Common.Models;

namespace ZawatSys.MicroLib.Lab.Domain.Entities;

/// <summary>
/// Defines the types of lab order items and their metadata schemas for UI generation.
/// </summary>
public class LabItemType : TenantEntity
{
    /// <summary>
    /// Display name of the lab item type (e.g., "Crown", "Blood Test", "MRI").
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Category classification for the lab item type.
    /// </summary>
    public LabItemCategory Category { get; set; }

    /// <summary>
    /// JSON schema for dynamic UI generation. Defines the structure of metadata
    /// that can be collected for orders of this type.
    /// </summary>
    public JsonDocument? MetadataSchema { get; set; }

    /// <summary>
    /// Indicates whether this lab item type is active and available for use.
    /// </summary>
    public bool IsActive { get; set; } = true;
}