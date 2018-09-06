using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SuperSocket.ClientEngine;

namespace socket_client
{
    class Program
    {

        static void Main(string[] args)
        {

            Socket_client client = new Socket_client();
            string ip = "192.168.1.104";
            int port = 8080;
            client.Connect(ip,port);
               
            while (true) ;
        }
    }

        
}
    
