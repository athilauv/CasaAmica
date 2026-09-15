namespace CasaAmica.Domain.Enums;

public enum HandoverStatus
{
    Initiated = 1,
    AwaitingConfirmation = 2,
    Confirmed = 3,
    Completed = 4,
    Cancelled = 5,
    Failed = 6
}