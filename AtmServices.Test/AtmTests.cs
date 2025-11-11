namespace AtmServices.Test;
using AtmServices;
public class AtmTests
{
    Atm testAtm;
    int initialBalance = 100;
    public AtmTests() {
        testAtm = new Atm(initialBalance);
    }
 
    [Fact]
    public void Test_Withdraw()
    {
        var result = testAtm.withdraw(25);
        Assert.True(result);
        Assert.Equal(75, testAtm.getBalance());
    }

    [Fact]
    public void Test_WithdrawGreaterAmount()
    {
        var result = testAtm.withdraw(101);
        Assert.False(result);
    }
    
    [Fact]
    public void Test_deposit()
    {
        var result = testAtm.deposit(20);
        Assert.True(result);
        Assert.Equal(120,testAtm.getBalance());
    }

    [Fact]
    public void Test_depositNegative()
    {
        var result = testAtm.deposit(-20);
        Assert.False(result);
    }

    [Fact]
    public void Test_getBalance()
    {
        var result = testAtm.getBalance();
        Assert.Equal(100,result);
    }



}
 