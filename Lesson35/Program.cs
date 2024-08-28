const int WINDOW_WIDTH = 120;
const int WINDOW_HEIGHT = 40;
DirectoryInfo directoryInfo=new DirectoryInfo(Environment.CurrentDirectory);
string currentPath = directoryInfo.Root.FullName;
Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);

DrawConsole(0, 0, WINDOW_WIDTH, 25);

void DrawConsole(int left,int top, int width, int height)
{
    Console.SetCursorPosition(left, top);
    Console.Write("┌");
    for(int j = 0;j<width-2;j++) Console.Write("─");
    Console.WriteLine("┐");
}
//do
//{
//    Console.Write(currentPath+">");
//    string command=Console.ReadLine()!;
//    string[] commands=command.Split(' ');
//    switch(commands[0])
//    {
//        case "cd":
//            {
//                switch(commands[1])
//                {
//                    case "..":
//                        {
//                            directoryInfo = directoryInfo.Parent!;
//                            currentPath = directoryInfo.FullName;
//                        }
//                        break;
//                    case "/":
//                        {
//                            directoryInfo = directoryInfo.Root!;
//                            currentPath = directoryInfo.FullName;
//                        }
//                        break;
//                    case "~":
//                        {
//                            //directoryInfo = ";
//                            //currentPath = directoryInfo.FullName;
//                        }
//                        break;
//                }
//            }
//            break;
//    }
//}
//while (true);
