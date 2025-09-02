            //-- Lesson 3

            //Console.WriteLine("Tickets are 5$. Please, insert cash.");

            //int cash = Convert.ToInt32(Console.ReadLine());
            //int change;

            //if (cash < 5)
            //{
            //    Console.Write("That's not enough money");
            //}
            //else if (cash == 5)
            //{
            //    Console.Write("Here's your ticket");
            //}
            //else
            //{
            //    change = cash - 5;
            //    Console.WriteLine("Here's your change: " + change);
            //}


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write(i + 1);
            //}


            //Console.ReadLine();


            //-- Lesson 2

            //int num1;
            //int num2;

            //Console.Write("Input a number: ");

            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input a second number: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //int result = (num1 + num2) / 2;

            //Console.Write("The average of this addition is equal " + result);


            //-- Lesson 1 

            //Console.WriteLine("\n\nWhat is your name?");

            //string userName = Console.ReadLine();

            //Console.WriteLine("Hello " + userName + ", nice to meet you");

            //Console.Title = "lol";
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WindowHeight = 40;

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