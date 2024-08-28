using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson28._2
{
    public class ClassFileManager
    {
        public static string Read(string file)=>File.ReadAllText(file);
        public static void Write(string file, string text) => File.WriteAllText(file,text);
        public static bool FileExist(string file) => File.Exists(file);
        public static void FileRemove(string file) => File.Delete(file);
    }
}
