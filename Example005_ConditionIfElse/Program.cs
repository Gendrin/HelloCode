Console.WriteLine("Введите имя польхователя:");
string? username = Console.ReadLine();
if (username.ToLower() == "маша") Console.WriteLine("Ура это же МАША!");
    else Console.WriteLine($"Привет:{username}");
