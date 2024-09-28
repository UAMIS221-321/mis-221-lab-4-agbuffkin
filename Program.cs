//start main
DisplayMenu();
string userinput = GetUserChoice();
while (userinput != "4"){
    RouteEm(userinput);
    DisplayMenu();
    userinput = GetUserChoice();
}
//end main

//menu
static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Welcome to Crimson Crust. Please select which pizza you would like to see. \n1. Plain toppingless slice \n2. Cheese Pizza Slice\n3. Pepperoni Pizza Slice \n4. Exit.");
}

static string GetUserChoice(){
    return Console.ReadLine();
}

static void RouteEm(string userchoice){
    if(userchoice == "1"){
        PlainPizza();
    }
    else if(userchoice == "2"){
        CheesePizza();
    }
    else if(userchoice == "3"){
        PepperoniPizza();
    }
    else if(userchoice == "4"){
        Exit();
    }
    else{
        InvalidInput();
    }
}

static void Exit(){
    Pause();
}

static void Pause(){
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

static void InvalidInput(){
    System.Console.WriteLine("Invalid input. Please select a pizza slice option from the menu.");
    Pause();
}

static void PlainPizza(){
    System.Console.WriteLine("Now displaying a plain pizza slice.");
    Random rnd = new Random();
    int rows = rnd.Next(8,13);
    for(int i = rows; i > 0; i--){
        for(int j = 0; j < i; j++) {
            System.Console.Write("*  ");
        }
        System.Console.WriteLine();
    }
    Pause();
}

static void CheesePizza(){
    System.Console.WriteLine("Now displaying a cheese pizza slice.");
    Random rnd = new Random();
    int rows = rnd.Next(8,13);
    for(int i = rows; i > 0; i--){
        for(int j = 0; j < i; j++) {
            if(i == rows){
                System.Console.Write("*  ");
            }
            else{
                if(j == 0){
                    System.Console.Write("*  ");
                }
                else if(j == i - 1){
                    System.Console.Write("*  ");
                }
                else{
                    System.Console.Write("#  ");
                }
            }
        }
        System.Console.WriteLine();
    }
    Pause();
}


static void PepperoniPizza(){
    System.Console.WriteLine("Now displaying a pepperoni pizza slice.");
    Random rnd = new Random();
    int rows = rnd.Next(8,13);
    for(int i = rows; i > 0; i--){
        for(int j = 0; j < i; j++) {
            if(i == rows){
                System.Console.Write("*  ");
            }
            else{
                if(j == 0){
                    System.Console.Write("*  ");
                }
                else if(j == i - 1){
                    System.Console.Write("*  ");
                }
                else{
                    int topping = rnd.Next(0,4);
                    if(topping == 0){
                        System.Console.Write("[] ");
                    }
                    else{
                        System.Console.Write("#  ");
                    }
                }
            }
        }
        System.Console.WriteLine();
    }
    Pause();
}

