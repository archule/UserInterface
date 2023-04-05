namespace UserInterface.Querier {
    public class Querier {

        public Querier() {

        }

        public static void run() {
            WelcomeMessage();
            AskForContainer();
        }

        /* Welcome message to user */
        public static void WelcomeMessage() {
            Console.WriteLine("Welcome!");
        }

        public static void AskForContainer() {
        Console.WriteLine("What container would you like: ");
        Console.WriteLine("1: Div");
        Console.WriteLine("2: Section");
        Console.WriteLine("3: Header");
        Console.WriteLine("4: span (inline - nonsemantic)");
        getContainerStart();
        }

        public static string getContainerStart() {

            string response = Console.ReadLine();

            string container = "";
            if(response =="div") {
                container = "<div>";
            } else if (response == "section") {
                container = "section";
            } else if (response == "header") {
                container = "header";
            } else if (response == "span") {
                container = "span";
            } else {
                Console.WriteLine("Invalid entry");
                return getContainerStart();
            }

            return container;
        }

    }
}