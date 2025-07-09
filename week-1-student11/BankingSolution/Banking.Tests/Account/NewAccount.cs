using Banking.Domain;

namespace Banking.Tests.Account;

public class NewAccount
{
    [Fact]
    public void NewAccountsHaveCorrectOpeningBalance()
    {
        var account = new BankAccount();
        var expectedOpeningBalance = 5000.00M;

        var accountBalance = account.GetBalance();

        Assert.Equal(expectedOpeningBalance, accountBalance);
    }
}
