using System;
using System.Collections.Generic;
using System.Linq;

namespace ThreadsAndParellelism
{
    public class ServerManager
    {
        private List<Server> _servers = new List<Server>()
        {
            new Server { Name = "Server1", Ram = 8, Status = false, Location = "NorthAmerica"},
            new Server { Name = "Server2", Ram = 18, Status = false, Location = "NorthAmerica"},
            new Server { Name = "Server3", Ram = 18, Status = true, Location = "NorthAmerica"},
            new Server { Name = "Server4", Ram = 6, Status = true, Location = "Asia"},
            new Server { Name = "Server5", Ram = 18, Status = true, Location = "Asia"},
            new Server { Name = "Server6", Ram = 8, Status = true, Location = "Asia"},
            new Server { Name = "Server6", Ram = 8, Status = false, Location = "Asia"},
            new Server { Name = "Server7", Ram = 8, Status = false, Location = "Europe"},
            new Server { Name = "Server8", Ram = 18, Status = false, Location = "Europe"},
            new Server { Name = "Server9", Ram = 6, Status = false, Location = "Europe"},
            new Server { Name = "Server10", Ram = 6, Status = false, Location = "Africa"},
            new Server { Name = "Server11", Ram = 8, Status = true, Location = "Africa"},
            new Server { Name = "Server12", Ram = 8, Status = true, Location = "Africa"}
        };

        public void PrintOfflineAsianServersWithLotsOfRam()
        {
            foreach (var server in _servers)
            {
                if (server.Location == "Asia" && server.Ram >= 8 && !server.Status)
                {
                    Console.WriteLine(server);
                }
            }
        }

        public void PrintOfflineAsianServersWithLotsOfRamLinq()
        {
            var targetServer = from s in _servers where s.Location == "Asia" && s.Ram >= 8 && s.Status == false select s;

            foreach (var t in targetServer)
            {
                Console.WriteLine(t);
            }
        }

        public void PrintOfflineServers()
        {
            var offlineServer = from s in _servers where s.Status == false orderby s.Location descending select s;

            foreach (var s in offlineServer)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"Number of offline server: {offlineServer.Count()}"); 

            Console.WriteLine("**** adding server ****");

            _servers.Add(new Server() { Name = "Server15", Ram = 18, Status = false, Location = "Europe" });

            Console.WriteLine($"Number of offline server: {offlineServer.Count()}"); 


            foreach (var s in offlineServer)
            {
                Console.WriteLine(s);
            }

            // we'll get the new server even after we adde the query.

            // Dang that's pretty crazy. This is only possible because we didn't convert our Enumerable to a list or an array which we can do in our LINQ query.  
        }

        // linq only get's filled out after you iterate. You don't need to repeat yourself if you need to find it multiple times. 
        // 


    }
}