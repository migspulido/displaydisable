/// Miguel Pulido / Systems Architect

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DisableDevice;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.IO;
using System.IO.Ports;


namespace DisplayDisable
{
    class Program
    {


        public static void EnableDisplay(bool enable)
        {

            // Every type of device has a hard-coded GUID, Right click the device in device manager
            // Below is the one for display after right clicking
            Guid displayGuid = new Guid("{4d36e96e-e325-11ce-bfc1-08002be10318}");

            // Get this from the properties > Details > Device Instance Path
            string instancePath = @"DISPLAY\HSD18B2\4&18a08b20&UID52826880";

            DeviceHelper.SetDeviceEnabled(displayGuid, instancePath, enable);
        }
        
        
        static void Main(string[] args)
        
        {

            Console.WriteLine("Display Hardware Initialized!");
        }
    }
}
