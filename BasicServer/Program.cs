﻿using ServerClassLibrary;
using System.Threading;

namespace BasicServer
{
    class Program
    {
        private static void Main(string[] args) {
            var config = new CommandLineConfig(args);
            var server = Server(config);
            var tokenSource = new CancellationTokenSource();
            server.Start(tokenSource.Token);
        }

        private static Server Server(CommandLineConfig config) {
            var listener = new Listener(config.IpAddress, config.Port);
            var parser = new Parser();
            var router = BasicServerRouter.Configure();
            var factory = new RequestProcessorFactory(parser, router);
            var logger = new FileLogger(config.LogFile);
            var server = new Server(listener, factory, logger);
            return server;
        }
    }
}
