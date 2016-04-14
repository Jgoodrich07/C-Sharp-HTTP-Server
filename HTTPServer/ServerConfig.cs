﻿using System;
using System.IO;
using System.Linq;

namespace HTTPServer {
    public class ServerConfig {
        private int _port;
        private string _publicDir;

        public ServerConfig(string[] args) {
            Config(args);
        }

        public void Config(string[] args) {
            SetPort(args);
            SetPublicDir(args);
        }

        private void SetPort(params string[] args) {
            if (args.Contains("-p")) {
                var portIndex = Array.IndexOf(args, "-p") + 1;
                _port = args[portIndex] != null ? int.Parse(args[portIndex]) : 5000;
            }
            else {
                _port = 5000;
            }
        }

        private void SetPublicDir(params string[] args) {
            if (args.Contains("-d")) {
                var dirIndex = Array.IndexOf(args, "-d") + 1;
                _publicDir = args[dirIndex] ?? Path.Combine(Environment.CurrentDirectory, @"..\..\Fixtures\");
            }
            else {
                _publicDir = Path.Combine(Environment.CurrentDirectory, @"..\..\Fixtures\");
            }
        }

        public int GetPort() {
            return _port;
        }

        public string GetPublicDir() {
            return _publicDir;
        }
    }
}