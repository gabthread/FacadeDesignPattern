using System;

namespace FacadeDesignPatternDemo
{
    public class FileLoader
    {
        public void LoadFile(string fileName)
        {
            Console.WriteLine(string.Format("File {0} Loaded",fileName));
        }
    }
}
