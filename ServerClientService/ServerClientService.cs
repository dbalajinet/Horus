﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServerClientService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServerClientService : IServerClientService
    {
        public string GetHostName()
        {
            return Environment.MachineName;
        }

        public Computer GetComputer(Computer computer)
        {
            if (computer == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (computer.BoolValue)
            {
                computer.StringValue += "Suffix";
            }
            return computer;
        }
    }
}
