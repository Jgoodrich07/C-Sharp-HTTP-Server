﻿using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace HTTPServer {
    public class Listener : IListener {
        private readonly TcpListener _listener;

        public Listener(IPAddress ip, int port) {
            _listener = new TcpListener(ip, port);
        }

        public bool Listening() {
            return true;
        }

        public IClientSocket Accept() {
            var tcpClient = _listener.AcceptTcpClient();
            return new ClientSocket(tcpClient);
        }

        public void Start() {
            _listener.Start();
        }
    }
}