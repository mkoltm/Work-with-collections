//ЗАВДАННЯ 2

// Клас для представлення користувачів
class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public User(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

// Клас для управління користувачами
class UserManager
{
    private List<User> users;

    public UserManager()
    {
        users = new List<User>();
    }

    public void AddUser(int id, string name)
    {
        User newUser = new User(id, name);
        users.Add(newUser);
        Console.WriteLine($"User added: {newUser.Id} - {newUser.Name}");
    }

    public void RemoveUser(int id)
    {
        User userToRemove = users.Find(user => user.Id == id);

        if (userToRemove != null)
        {
            users.Remove(userToRemove);
            Console.WriteLine($"User removed: {userToRemove.Id} - {userToRemove.Name}");
        }
        else
        {
            Console.WriteLine($"User with Id {id} not found.");
        }
    }

    public void DisplayUsers()
    {
        Console.WriteLine("Users:");

        foreach (var user in users)
        {
            Console.WriteLine($"{user.Id} - {user.Name}");
        }
    }

    public string GetUserInfo(int id)
    {
        User user = users.Find(u => u.Id == id);
        return user != null ? $"{user.Id} - {user.Name}" : $"User with Id {id} not found.";
    }
}

class Program
{
    static void Main()
    {
        UserManager userManager = new UserManager();

        // Додавання користувачів
        userManager.AddUser(1, "John Doe");
        userManager.AddUser(2, "Jane Doe");

        // Виведення усіх користувачів
        userManager.DisplayUsers();

        // Видалення користувача
        userManager.RemoveUser(1);

        // Виведення усіх користувачів після видалення
        userManager.DisplayUsers();

        // Пошук та виведення інформації про користувача за ідентифікатором
        Console.WriteLine("\nUser Information:");
        Console.WriteLine(userManager.GetUserInfo(2));
    }
}