using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace assignment2
{
    class RTPModel
    {
        //create class variables for and endpoint and for a udp socket
        IPEndPoint ip_ep;
        //Socket UDP_sock;
        //adding more variables that were not in server
        //udp client side vairable
        UdpClient UDP_client;
        //some integer variables to control the port/rcving values
        int pn;
        int rcv_length;

        public RTPModel (string new_ip)
        {
            try
            {
                //parse the ip address
                IPAddress ip = IPAddress.Parse(new_ip);
                UDP_client = new UdpClient(0);
                ip_ep = new IPEndPoint(IPAddress.Any, 0);
                pn = ((IPEndPoint)UDP_client.Client.LocalEndPoint).Port;
            }
            catch { }

        }

        //function to send udp datagram
        public byte[] Get_Data()
        {
            Byte[] ret = UDP_client.Receive(ref ip_ep);
            rcv_length = ret.Length;
            return ret;   
        }     
        public IPEndPoint Get_IPEndPoint()
        {
            return ip_ep;
        }
        
        public void Close()
        {
            UDP_client.Close();
        }
        public int Get_Port()
        {
            return pn;
        }
        public int Get_Length()
        {
            return rcv_length;
        }
    }
}
