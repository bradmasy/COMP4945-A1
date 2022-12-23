using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    internal class Server
    {
        private int _port;
        private string _host;

        public Server() { };
        public Server(int port) {
            this._port = port;
        };
        
        public Server(string host, int port) {
            this(port);
            this._host = host;
        };   

    }
}
