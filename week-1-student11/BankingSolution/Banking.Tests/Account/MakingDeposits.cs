using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Domain;

namespace Banking.Tests.Account;

public class MakingDeposits
{
    [Fact]
    public void MakingADepositIncreasesTheBalance()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 112.25M;

        account.Deposit(amountToDeposit);

        Assert.Equal(amountToDeposit + openingBalance, account.GetBalance());
    }
}
