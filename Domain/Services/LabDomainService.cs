using ZawatSys.MicroLib.Lab.Domain.Enums;

namespace ZawatSys.MicroLib.Lab.Domain.Services;

public class LabDomainService
{
    public bool CanTransitionStatus(LabOrderStatus currentStatus, LabOrderStatus newStatus)
    {
        return (currentStatus, newStatus) switch
        {
            (LabOrderStatus.Pending, LabOrderStatus.Ordered) => true,
            (LabOrderStatus.Ordered, LabOrderStatus.SampleCollected) => true,
            (LabOrderStatus.SampleCollected, LabOrderStatus.InProgress) => true,
            (LabOrderStatus.InProgress, LabOrderStatus.Completed) => true,
            (LabOrderStatus.Completed, LabOrderStatus.Reported) => true,
            (LabOrderStatus.Pending, LabOrderStatus.Cancelled) => true,
            (LabOrderStatus.Ordered, LabOrderStatus.Cancelled) => true,
            _ => false
        };
    }

    public decimal CalculateOrderTotal(IEnumerable<Guid> testIds, Dictionary<Guid, decimal> testPrices)
    {
        return testIds.Sum(id => testPrices.GetValueOrDefault(id, 0));
    }
}