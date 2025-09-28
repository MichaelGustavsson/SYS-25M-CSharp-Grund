namespace Bank.Domain.Models;

public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    public override decimal Balance
    {
        get
        {
            decimal sum = 0;
            foreach (var trx in Transactions)
            {
                sum += trx.Amount;
            }
            return sum * (1 + InterestRate);
        }
    }

    public SavingsAccount(decimal initialBalance)
    {
        InterestRate = 0.0175M;
        Transactions = [new Transaction(initialBalance)];
    }

    public override string ToString()
    {
        return $"Kontodatum: {CreatedDate:d} - Kontonummer: {AccountNumber} - Saldo: {Balance} - Räntesats: {InterestRate}";
    }
}
