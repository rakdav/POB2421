Console.Write("Введите путь к папке:");
string path = Console.ReadLine()!;

void PrintDirectory(DirectoryInfo directory, string indent,bool lastDirectory)
{
    Console.Write(indent);
    if(lastDirectory)
    {
        Console.Write("∟");
        indent += " ";
    }
    else
    {
        Console.Write("├");
        indent += "| ";
    }
    Console.WriteLine(directory.Name);
    DirectoryInfo[] subDirectories= directory.GetDirectories();
    for(int i = 0; i < subDirectories.Length; i++)
    {
        PrintDirectory(subDirectories[i], indent, i==subDirectories.Length-1);
    }
}

PrintDirectory(new DirectoryInfo(path), "", false);

