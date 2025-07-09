namespace Banking.Domain;

public class BankAccount
{
    private decimal _currentBalance = 5000;


    public decimal GetBalance()
    {
        return _currentBalance;
    }

    public void Deposit(decimal amountToDeposit)
    {
        _currentBalance += amountToDeposit;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        _currentBalance -= amountToWithdraw;
    }
}
