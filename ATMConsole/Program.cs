



public class ATMConsoleApp{
    
    

    public static void Main(string[] args){
        Menu();
    }
    private static void Menu(){
    bool optionchosen = false;
    string selection;
    while(!optionchosen){
        Console.WriteLine("Welcome to the Dare Bank ATM");
        Console.WriteLine("please select an option");
        Console.WriteLine("1 - Input pin");
        Console.WriteLine("2 - Create an account");
        Console.WriteLine("3 - Quit");
        selection = Console.ReadLine().ToString();
        switch(selection){
            case "1":
                break;
            case "2":
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                break;

        }

    }

    }

}