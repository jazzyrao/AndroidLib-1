﻿using AndroidLib.Adb;
using AndroidLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (!Adb.ServerIsRunning) Adb.StartServer();
            //Console.WriteLine("Started!");
            //Console.Write(Adb.ExecuteAdbCommandWithOutput("devices -l", null, false));
            //Console.Write("FINISHED!");
            //Console.Read();
            //Adb.StopServer();
            //Console.WriteLine("Stopped!");

            List<AndroidLib.Device> devices = Adb.GetConnectedDevices();

            Console.WriteLine(devices.Count);

            Console.Read();

            Device dev = devices[0];

            Console.Read();

            Console.WriteLine(dev.SerialNumber);

            Console.WriteLine(dev.Pull("/sdcard/TMemo", "C:\\Android\\WA"));

            Console.Read();
        }
    }
}