using System;
using System.Collections.Generic;
using GeoLib.Contracts;
using GeoLib.Data;

namespace GeoLib.Services
{
	public class GeoManager : IGeoService
	{
		public IEnumerable<string> GetStates(bool primaryOnly)
		{
			List<string> stateData = new List<string>();

			IStateRepository stateRepository = new StateRepository();

			IEnumerable<State> states = stateRepository.Get(primaryOnly);
			if(states != null)
			{
				foreach (State state in states)
				{
					stateData.Add(state.Abbreviation);
				}
			}

			return stateData;
		}

		public ZipCodeData GetZipInfo(string zip)
		{
			ZipCodeData zipCodeData = null;

			IZipCodeRepository zipCodeRepository = new ZipCodeRepository();

			ZipCode zipcodeEntity = zipCodeRepository.GetByZip(zip);
			if(zipcodeEntity != null)
			{
				zipCodeData = new ZipCodeData()
				{
					City = zipcodeEntity.City,
					State = zipcodeEntity.State.Abbreviation,
					ZipCode = zipcodeEntity.Zip
				};
			}

			return zipCodeData;
		}

		public IEnumerable<ZipCodeData> GetZips(string state)
		{
			List<ZipCodeData> zipCodeData = new List<ZipCodeData>();

			IZipCodeRepository zipCodeRepository = new ZipCodeRepository();

			return zipCodeData;
		}

		public IEnumerable<ZipCodeData> GetZips(string zip, int range)
		{
			List<ZipCodeData> zipCodeData = new List<ZipCodeData>();

			IZipCodeRepository zipCodeRepository = new ZipCodeRepository();

			return zipCodeData;
		}
	}
}
