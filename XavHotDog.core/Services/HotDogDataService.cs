using System;
using System.Collections.Generic;

namespace XavHotDog.core
{
	public class HotDogDataService
	{
		private static HotDogRepository hotDogRepository = new HotDogRepository();

		public List<HotDog> GetAllHotDogs()
		{
			return hotDogRepository.GetAllHotDogs();
		}

		public HotDog GetHotDogById(int hotDogId)
		{
			return hotDogRepository.GetHotDogById(hotDogId);
		}

		public List<HotDogGroup> GetGroupedHotDogs()
		{
			return hotDogRepository.GetGroupedHotDogs();
		}

		public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
		{
			return hotDogRepository.GetHotDogsForGroup(hotDogGroupId);
		}

		public List<HotDog> GetFavoriteHotDogs()
		{
			return hotDogRepository.GetFavoriteHotDogs();
		}
	}
}

