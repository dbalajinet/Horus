﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;


namespace ServerClientService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServerClientService : IServerClientService
    {
        public string GetHostName()
        {
            return Environment.MachineName;
        }

        public void HandShake(string hostName)
        {
            try
            {
                var connectionString = "mongodb://localhost";
                var client = new MongoClient(connectionString);
                var server = client.GetServer();
                var database = server.GetDatabase("horus");
                var collection = database.GetCollection<Client>("clients");
                var thisClient = new Client { hostName = hostName };
                collection.Insert(thisClient);
                Console.WriteLine(collection.Name);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public class Client
        {
            public ObjectId Id { get; set; }
            public string hostName { get; set; }
        }
    }
}
