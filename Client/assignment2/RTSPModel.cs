using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;
using System.Net;

namespace assignment2
{
    class RTSPModel
    {
        //variables for the ip and port
        private int pn;
        public IPAddress ip;
        //variable for the socket
        Socket RTSP_sock = null;
        //variable for end point to be set up
        IPEndPoint ep = null;
        //variable to recieve message
        byte[] rcv = new byte[1024];

        public RTSPModel(int p, string ip)
        {          

            this.pn = p;
            try { this.ip = IPAddress.Parse(ip); }
            catch (FormatException e) { /*invalid IP*/ }

            
            try
            {
                ep = new IPEndPoint(this.ip, pn);
                RTSP_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
            catch (SocketException e)
            {
                if (RTSP_sock != null) { RTSP_sock.Close(); }
            }

            try { RTSP_sock.Connect(ep); }
            catch { }
        }

        public Socket Accept_Server()
        {
            return RTSP_sock;
        }
    }
}
