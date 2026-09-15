namespace CasaAmica.Domain.Enums;

public enum AuditActionType
{
    Create = 1,
    Update = 2,
    Delete = 3,
    Login = 4,
    Logout = 5,
    StatusChange = 6,
    Approval = 7,
    Rejection = 8,
    Handover = 9,
    OwnershipTransfer = 10,
    Verification = 11,
    Other = 12
}