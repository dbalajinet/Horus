﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorusAdmin.Horus;
using System.Windows.Forms;

namespace HorusAdmin
{

    class Program
    {

        public static string[] onlineClients;

        [STAThread]
        static void Main(string[] args)
        {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new HorusAdminMain());
        }

        public static void GetClients()
        {
            ServerAdminServiceClient AdminClient = new ServerAdminServiceClient();
            //net.tcp://localhost:12000/ServerAdminService/ServerAdminService/
            AdminClient.Endpoint.Address = new System.ServiceModel.EndpointAddress("net.tcp://" + Properties.Settings.Default.HorusServerAddress + ":12000/ServerAdminService/ServerAdminService/");

            AdminClient.Open();

            onlineClients = AdminClient.GetClients();

        }



        /*
            try
            {
                Console.WriteLine("Starting Testing");

                ServerAdminServiceClient AdminClient = new ServerAdminServiceClient();
                //net.tcp://localhost:12000/ServerAdminService/ServerAdminService/
                AdminClient.Endpoint.Address = new System.ServiceModel.EndpointAddress("net.tcp://"+Properties.Settings.Default.HorusServerAddress+":12000/ServerAdminService/ServerAdminService/");

                AdminClient.Open();

                Console.WriteLine("Available Clients");

                string[] onlineClients = AdminClient.GetClients();

                for (int i = 0; i < onlineClients.Count(); i++ )
                {
                    Console.WriteLine(i+1 + ": "  + onlineClients[i]);
                }

                Console.WriteLine("Please Enter The Number Relateing To The Client You Want To Send Command Too");

                int choice = int.Parse(Console.ReadLine()) - 1;
                bool intActive = true;
                
                while(intActive==true)
                {
                    Console.WriteLine("Choose An Option");
                    Console.WriteLine("1: Get Logged In User");
                    Console.WriteLine("2: Get Number Of CPU Cores");
                    Console.WriteLine("3: Get System Uptime (In Minutes)");
                    Console.WriteLine("4: Start Remote Process");
                    Console.WriteLine("5: End Remote Process");
                    Console.WriteLine("6: Start Remote Service");
                    Console.WriteLine("7: End Remote Service");
                    Console.WriteLine("8: Exit");
                    int option = int.Parse(Console.ReadLine());    

                    if(option==1)
                    {
                        Console.WriteLine(AdminClient.GetComputer(onlineClients[choice]).UserName);
                    }
                    else if(option==2)
                    {
                        Console.WriteLine(AdminClient.GetComputer(onlineClients[choice]).CPUNumLogicalCores);
                    }
                    else if(option==3)
                    {
                        Console.WriteLine(AdminClient.GetComputer(onlineClients[choice]).SystemUpTime.TotalMinutes);
                    }  
                    else if(option==4)
                    {
                        Console.WriteLine("Please enter a process name to start");
                        string procName = Console.ReadLine();
                        AdminClient.StartRemoteProcess(procName, AdminClient.GetComputer(onlineClients[choice]).HostName);
                        
                    }
                    else if(option==5)
                    {
                        Console.WriteLine("Please enter a process name to end");
                        string procName = Console.ReadLine();
                        AdminClient.EndRemoteProcess(procName, AdminClient.GetComputer(onlineClients[choice]).HostName);
                    }
                    else if (option==6)
                    {
                        Console.WriteLine("Please enter a service name to start");
                        string procName = Console.ReadLine();
                        AdminClient.StartRemoteService(procName, AdminClient.GetComputer(onlineClients[choice]).HostName);
                    }
                    else if (option==7)
                    {
                        Console.WriteLine("Please enter a service name to end");
                        string procName = Console.ReadLine();
                        AdminClient.EndRemoteService(procName, AdminClient.GetComputer(onlineClients[choice]).HostName);
                    }
                    else if(option==8)
                    {
                        intActive = false;
                    }
                }

                Console.WriteLine("Testing Over");

                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }*/
    }
}
