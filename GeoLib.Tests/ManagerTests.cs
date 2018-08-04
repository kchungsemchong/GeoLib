using System;
using GeoLib.Contracts;
using GeoLib.Data;
using GeoLib.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GeoLib.Tests
{
	[TestClass]
	public class ManagerTests
	{
		[TestMethod]
		public void TestZipCodeRetrieval()
		{
			Mock<IZipCodeRepository> mockZipCodeRepository = new Mock<IZipCodeRepository>();

			ZipCode zipCode = new ZipCode()
			{
				City = "Lincoln Park",
				State = new State() { Abbreviation = "NJ" },
				Zip = "07035"
			};

			mockZipCod eRepository.Setup(obj => obj.GetByZip("07035")).Returns(zipCode);

			IGeoService geoService = new GeoManager(mockZipCodeRepository.Object);

			ZipCodeData data = geoService.GetZipInfo("07035");

			Assert.IsTrue(data.State == "NJ");
		}
	}
}
