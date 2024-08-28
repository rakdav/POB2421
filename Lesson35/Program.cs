const int WINDOW_WIDTH = 120;
const int WINDOW_HEIGHT = 44;
DirectoryInfo directoryInfo=new DirectoryInfo(Environment.CurrentDirectory);
string currentPath = directoryInfo.FullName;
Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);


void DrawConsole(int left,int top, int width, int height)
{
    Console.SetCursorPosition(left, top);
    Console.Write("┌");
    for(int j = 0;j<width-2;j++) Console.Write("─");
    Console.WriteLine("┐");
    for(int i = 0;i<height-2;i++)
    {
        Console.Write("│");
        for (int j = 0; j < width - 2; j++) Console.Write(" ");
        Console.WriteLine("│");
    }
    Console.Write("└");
    for (int j = 0; j < width - 2; j++) Console.Write("─");
    Console.WriteLine("┘");
}

void PrintDirectory(DirectoryInfo directory, string indent, bool lastDirectory)
{
    Console.Write(indent);
    if (lastDirectory)
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
    DirectoryInfo[] subDirectories = directory.GetDirectories();
    for (int i = 0; i < subDirectories.Length; i++)
    {
        PrintDirectory(subDirectories[i], indent, i == subDirectories.Length - 1);
    }
}
do
{
    DrawConsole(0, 0, WINDOW_WIDTH, 25);
    DrawConsole(0, 25, WINDOW_WIDTH, 8);
    DrawConsole(0, 33, WINDOW_WIDTH, 4);
    Console.SetCursorPosition(1, 1);
    PrintDirectory(directoryInfo, "", false);
    Console.SetCursorPosition(1, 34);
    Console.Write(currentPath + ">");
    string command = Console.ReadLine()!;
    string[] commands = command.Split(' ');
    switch (commands[0])
    {
        case "cd":
            {
                switch (commands[1])
                {
                    case "..":
                        {
                            directoryInfo = directoryInfo.Parent!;
                            currentPath = directoryInfo.FullName;
                        }
                        break;
                    case "/":
                        {
                            directoryInfo = directoryInfo.Root!;
                            currentPath = directoryInfo.FullName;
                        }
                        break;
                    case "~":
                        {
                            string userName= Environment.UserName;
                            directoryInfo =directoryInfo.Root;
                            currentPath = directoryInfo.FullName+"\\Users\\"+userName;
                            directoryInfo=new DirectoryInfo(currentPath);
                        }
                        break;
                }
            }
            break;
    }
}
while (true);
