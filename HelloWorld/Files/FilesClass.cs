using System;
using System.Collections.Generic;
using System.Text;
using System.IO;  // include the System.IO namespace

namespace HelloWorld.Files
{
    class FilesClass
    {
        static void Main(string[] args)
        {
            string myText = "Hello World!";
            File.WriteAllText("filename.txt", myText);

            string readMyText = File.ReadAllText("filename.txt");
            Console.WriteLine(readMyText);
        }
    }
}
