﻿using GeoLib.Services;
using System;
using System.ServiceModel;


namespace Geolib.ConsoleHost
{
	class Program
	{
		static void Main(string[] args)
		{
			ServiceHost hostGeoManager = new ServiceHost(typeof(GeoManager));
			hostGeoManager.Open();

			Console.WriteLine("Services started. Press [Enter] to exit");
			Console.ReadLine();
			
			hostGeoManager.Close();
		}

	}
}
