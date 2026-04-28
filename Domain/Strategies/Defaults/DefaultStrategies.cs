namespace ZawatSys.MicroLib.Lab.Domain.Strategies.Defaults;

public static class DefaultStrategies
{
    public static Type GetDefaultCreationRuleEngine() => typeof(DefaultCreationRuleEngine);

    public static Type GetDefaultPricingStrategy() => typeof(DefaultPricingStrategy);
}

public class DefaultCreationRuleEngine
{
    public string GenerateOrderNumber()
    {
        return $"LAB-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString("N")[..8].ToUpper()}";
    }
}

public class DefaultPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice, int quantity)
    {
        return basePrice * quantity;
    }
}