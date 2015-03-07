using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace PCFileTransferTCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient Client = new TcpClient("127.0.0.1", 8080);
            Console.WriteLine("[Trying to connect to localhost Server..]");
            NetworkStream stream = Client.GetStream();
            Console.WriteLine("[Connected]");
            string str = Console.ReadLine();
            byte[] message = Encoding.Unicode.GetBytes(str);
            stream.Write(message, 0, message.Length);
            Console.WriteLine("...........Sent..........");
            Client.Close();
            Console.ReadLine();
        }
    }
}
