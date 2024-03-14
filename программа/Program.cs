List<string> GenerateList()
{
    Random random = new Random();
    List<string> sp = new List<string>();

    for (int i = 0; i < random.Next(3, 8); i++)
    {
        sp.Add(Console.ReadLine());
    }

    return sp;
}

