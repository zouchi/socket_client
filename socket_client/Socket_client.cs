using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SuperSocket.ClientEngine;
using System.Net;
using System.Net.Sockets;

namespace socket_client
{
    public class Socket_client
    {



        public static AsyncTcpSession client;
        public Socket_client()
        {
            client = new AsyncTcpSession();
            client.Closed += client_Closed;
            // 收到服务器数据事件
            client.DataReceived += client_DataReceived;
            // 连接到服务器事件
            client.Connected += client_Connected;
            // 发生错误的处理
            client.Error += client_Error;

           
        }
        


        void client_Error(object sender, ErrorEventArgs e)
        {
             Console.WriteLine(e.Exception.Message);
        }

        void client_Connected(object sender, EventArgs e)
        {
            Console.WriteLine("连接成功");
        }

        void client_DataReceived(object sender, DataEventArgs e)
        {
            string msg = Encoding.Default.GetString(e.Data);
            Console.WriteLine(msg);
        }

        void client_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("连接断开");
        }

        public void Connect(string Ip, int Port)
        {
            client.Connect(new IPEndPoint(IPAddress.Parse(Ip), Port));
            string loginCmd = "LOGIN test\r\n";
            byte[] data = Encoding.Default.GetBytes(loginCmd);
            client.Send(data, 0, data.Length);
        }

    }
}
