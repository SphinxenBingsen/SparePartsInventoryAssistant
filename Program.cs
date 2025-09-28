string[] inventory = { "hydraulic pump", "PLC module", "servo motor" };

Console.WriteLine("Hej. Welcome to the spare parts inventory!");
Console.WriteLine("Which part do you need?");

bool found = false;

while (found == false)
{
    Console.Write("> ");
    string input = Console.ReadLine();

    foreach (string part in inventory)
    {
        if (input == part)
        {
            Console.WriteLine("I have got " + part + " here for you. Bye!");
            found = true;
        }
    }

    if (found == false)
    {
        Console.WriteLine("I am afraid we don’t have any " + input + " in the inventory.");
    }
}
 