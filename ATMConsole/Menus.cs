using System.Runtime.CompilerServices;
using System.Security;

public class theMenus{
    private static List<Account> accountList = new List<Account>();
    public static void Menu(){
    bool optionchosen = false;
    while(!optionchosen){
        Console.WriteLine("Welcome to the Dare Bank ATM");
        Console.WriteLine("please select an option");
        Console.WriteLine("1 - Input pin");
        Console.WriteLine("2 - Create an account");
        Console.WriteLine("3 - Quit");
       
        switch(Console.ReadLine().ToString()){
            case "1":
                break;
            case "2":
            CreateAccount(accountList);
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("invalid input please try again");
                break;

        }

    }

    }
    public static void CreateAccount(List<Account> accounts){
        bool optionChosen = false; 
        String name = "NOT SELECTED";
        float balance = 0.00f;
        int pin = 0;
        //loops around when an option is agreed on 
        while(!optionChosen){
            Console.WriteLine("please input your name");
            name = Console.ReadLine().ToString().ToUpper();
            Console.WriteLine("you inputted "+ name +" is this correct");
            Console.WriteLine("Y/N");
            string ans = Console.ReadLine().ToString().ToUpper();
            if(ans == "Y"){
                optionChosen = true; 
            }
            else{
                Console.WriteLine("please try again");
            }
        }
        optionChosen = false;
        while(!optionChosen){
            Console.WriteLine("please input your wanted pin");
            pin = int.Parse(Console.ReadLine());
            Console.WriteLine("you inputted "+ pin +" is this correct");
            Console.WriteLine("Y/N");
            string ans = Console.ReadLine().ToString().ToUpper();
            if(ans == "Y"){
                optionChosen = true; 
            }
            else{
                Console.WriteLine("please try again");
            }
        }
        optionChosen = false;
        while(!optionChosen){
            Console.WriteLine("please input the balance");
            balance = int.Parse(Console.ReadLine());
            Console.WriteLine("you inputted "+ balance +" is this correct");
            Console.WriteLine("Y/N");
            string ans = Console.ReadLine().ToString().ToUpper();
            if(ans == "Y"){
                optionChosen = true; 
            }
            else{
                Console.WriteLine("please try again");
            }
        }
        Account theAccount = new Account(name,pin,balance);
        if(!accounts.Contains(theAccount)){
            accounts.Add(theAccount);
        }
        Console.WriteLine("Account Created");
    }

    public static void CheckAccount(List<Account> accounts){

    }


}

    
    
         
        
        
        

    
