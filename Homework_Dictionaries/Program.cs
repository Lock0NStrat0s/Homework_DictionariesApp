
// Create a Dictionary list of employees ID and the name that goes with the ID.
// Fill in a few records.
// Then ask the user for their ID and return their name.

//create dictionary with filled records
Dictionary<int, string> employees = new Dictionary<int, string>();

//fill dictionary with records
employees[134] = "Bobby Jackson";
employees[784] = "Bilbo Bagpipe";
employees[321] = "Corey Torey";
employees[620] = "Larry Bones";

//loop until user enters 0
int id;
do
{
    //ask user for their ID and store in a variable
    Console.Write("What is your ID (0 to exit): ");
    int.TryParse(Console.ReadLine(), out id);

    //check if ID matches dictionary key and print to console
    if (id != 0)
    {
        if (employees.ContainsKey(id))
        {
            Console.WriteLine($"Your name is {employees[id]}.");
        }
        else
        {
            Console.WriteLine("Incorrect ID!");
        }
    }
} while (id != 0);
