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
            client.Connect();
       
            // 连接断开事件
          
            while (true) ;
        }
    }

        
}
    
