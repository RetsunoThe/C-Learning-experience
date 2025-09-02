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
            //StartServer();

            Console.Write("Pick a number from one to five: ");
            int vari2 = Convert.ToInt32(Console.ReadLine());

            switch (vari2)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
            }

            for (int i = 0; i < vari2; i++)
            {
                Console.WriteLine(i + 1);
            }

            







            Console.WriteLine("---\ndone " + Environment.UserName);
            Console.ReadLine();
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
        static private TcpListener _tcpListener;
        static void StartServer()
        {



            var port = 7777;
            var hostAdress = IPAddress.Any;
            _tcpListener = new TcpListener(hostAdress, port);
            _tcpListener.Start();


            byte[] buffer = new byte[256];
            using TcpClient client = _tcpListener.AcceptTcpClient();
            var tcpStream = client.GetStream();
            int readTotal;


            var senMessage = Encoding.UTF8.GetBytes("hi Nellb ");
            tcpStream.Write(senMessage, 0, senMessage.Length);

            while ((readTotal = tcpStream.Read(buffer, 0, buffer.Length)) != 0)
            {

                string incMessage = Encoding.UTF8.GetString(buffer, 0, readTotal);
                Console.WriteLine(incMessage);


            }
        }
    }
}

