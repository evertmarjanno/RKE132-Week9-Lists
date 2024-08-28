string folderPath = @"C:\data";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created.");
}

List<string> myShoppingList = [];
myShoppingList = GetItemsFromUser();
File.WriteAllLines(filePath, myShoppingList);

static List<string> GetItemsFromUser()
{
    List<string> userList = [];

    while (true)
    {
        Console.WriteLine("Add an item (add) / Exit (exit:");
        string? userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("Enter an item:");
            string? userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }
    }
    return userList;
}

static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int listLength = someList.Count;
    Console.WriteLine($"You have added {listLength} items to your shopping list.");

    int i = 1;
    foreach (string item in someList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}