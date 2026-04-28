namespace ZawatSys.MicroLib.Lab.MessageCodes;

public static class LabMessageCodes
{
    // Order Messages
    public const string OrderCreated = "LAB_ORDER_001";
    public const string OrderUpdated = "LAB_ORDER_002";
    public const string OrderCancelled = "LAB_ORDER_003";
    public const string OrderCompleted = "LAB_ORDER_004";
    public const string OrderNotFound = "LAB_ORDER_404";
    public const string InvalidOrderStatus = "LAB_ORDER_400";

    // Test Messages
    public const string TestCreated = "LAB_TEST_001";
    public const string TestUpdated = "LAB_TEST_002";
    public const string TestNotFound = "LAB_TEST_404";
    public const string TestAlreadyExists = "LAB_TEST_409";

    // Sample Messages
    public const string SampleCollected = "LAB_SAMPLE_001";
    public const string SampleNotReceived = "LAB_SAMPLE_404";

    // Validation Messages
    public const string ValidationFailed = "LAB_VALIDATION_400";
    public const string PatientRequired = "LAB_VALIDATION_001";
    public const string DoctorRequired = "LAB_VALIDATION_002";
    public const string TestRequired = "LAB_VALIDATION_003";

    // General Messages
    public const string Success = "LAB_SUCCESS_200";
    public const string InternalError = "LAB_ERROR_500";
}