namespace AtmServices;
public class Atm
{
    public int balance;
    public Atm(int initialBalance) {
        this.balance = initialBalance;
    }
    public bool withdraw(int amount) {
        if(amount < balance) {
            this.balance -= amount;
            return true;
        }
        return false;
    }
    public bool deposit(int amount) {
        if(amount < 0) {
            return false;
        }
        balance += amount;
        return true;
    }
    public double getBalance() {
        return balance;
    }
}