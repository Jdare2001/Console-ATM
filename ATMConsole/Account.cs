

public class Account{
    private int pin;
    private String name;
    private float balance; 

    public Account(String name, int pin, float balance){
        this.name = name;
        this.pin = pin;
        this.balance = balance;
    }
    public bool checkPin(int enteredPin){
        bool outcome = false;
        if(enteredPin == pin){
            outcome = true;
        }
        return outcome;
    }

    public String getName(){
        return this.name;
    }
    public float getBalance(){
        return this.balance;
    }
    public void updateBalance(float change){
        balance = balance + change;

    }


}