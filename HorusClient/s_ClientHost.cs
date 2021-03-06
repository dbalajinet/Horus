﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using HorusClient.HorusClientSide;
using HorusClient.HorusServerClient;

namespace HorusClient
{
    class s_ClientHost
    {
        public s_ClientHost()
        {

        }

        public void StartServce()
        {
            // Step 1 Create a URI to serve as the base address.
            //Port 15000

            Uri ClientSideAddress = new Uri("net.tcp://localhost:15000/UserClientService/");

            // Step 2 Create a ServiceHost instance
            ServiceHost ClientSideHost = new ServiceHost(typeof(UserClientService.ClientSideService), ClientSideAddress);

            try
            {
                // Step 3 Add a service endpoint.
                ClientSideHost.AddServiceEndpoint(typeof(UserClientService.IClientSideService), new NetTcpBinding(SecurityMode.None), "UserClientService");

                // Step 4 Enable metadata exchange.
                ServiceMetadataBehavior ClientMetaBehaviour = new ServiceMetadataBehavior();
                ClientSideHost.Description.Behaviors.Add(ClientMetaBehaviour);

                // Step 5 Start the service.
                ClientSideHost.Open();

                Console.WriteLine("The services are ready.");
                Console.WriteLine("Admin: " + ClientSideHost.BaseAddresses[0]);
                Console.WriteLine();

            }
            catch (Exception ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                ClientSideHost.Abort();
            }
        }
    }
}
