



public class ATMConsoleApp{
    
    

    public static void Main(string[] args){
        Menu();
    }
    private static void Menu(){
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
            CreateAccount();
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
    private static void CreateAccount(){
        bool optionChosen = false; 
        String name;
        float balance;
        int pin;
        //loops around when an option is agreed on 
        while(!optionChosen){
            Console.WriteLine("please input your name");
            name = Console.ReadLine().ToString();
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
    }

}