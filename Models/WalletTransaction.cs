namespace buoi18.Models;

public enum TransactionType
{
    Deposit,
    Withdraw
}

public sealed record WalletTransaction(
    TransactionType Type,
    decimal Amount,
    DateTime CreatedAt);
