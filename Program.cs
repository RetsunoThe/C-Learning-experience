// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Authentication.ExtendedProtection;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ProgramC
{
    class Program
    {
        static void Main(string[] args)
        {

            //FileManager();
            StartServer();


            Console.WriteLine(Environment.UserName);

            Console.WriteLine("done");
            Console.ReadLine();


        }

        static void FileManager()
        {

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "test/example.txt");
            string filePath1 = Path.Combine(desktopPath, "test/example1.txt");

            File.WriteAllText(filePath, "Hello! This file was created on the Desktop.");

            byte[] data = File.ReadAllBytes(filePath);

            File.WriteAllBytes(filePath1, data);


            //Get the Direct
            string terrariaPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string worldDirect0 = Path.Combine(terrariaPath, "My Games/Terraria/Worlds/test.wld");
            string worldDirect1 = Path.Combine(terrariaPath, "My Games/Terraria/Worlds/test1.wld");

            //Get data from first world
            byte[] overwrite = File.ReadAllBytes(worldDirect0);

            //Overwrite data into second world
            File.WriteAllBytes(worldDirect1, overwrite);

            // --- --- ---

            string worldDirect01 = Path.Combine(terrariaPath, "My Games/Terraria/Worlds/test.wld.bak");
            string worldDirect11 = Path.Combine(terrariaPath, "My Games/Terraria/Worlds/test1.wld.bak");

            byte[] overwrite1 = File.ReadAllBytes(worldDirect01);

            File.WriteAllBytes(worldDirect11, overwrite1);

        }

    }

}

