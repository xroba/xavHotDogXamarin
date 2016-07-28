using System;
using System.Collections.Generic;
using System.Linq;

namespace XavHotDog.core
{
	public class HotDogRepository
	{
		private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>()
		{

			new HotDogGroup()
			{
				HotDogGroupId = 1, Title = "Meat Lover", ImagePath = "", HotDogs = new List<HotDog>()
				{
					new HotDog()
					{
						HotDogId = 1, Name ="Twarres", ShortDescription="We are coming from far", Descritpion ="We shine true love, we are the children of the sun", ImagePath="hotdog1", Available= true, PrepTime = 4,
						Ingredients = new List<string>()
						{
							"Sun", "shine", "love"
						},
						Price = 8, IsFavourite = true
					},
					new HotDog()
					{
						HotDogId = 2, Name ="RadioHead", ShortDescription="I m a weirdo", Descritpion ="I want to have control, I want a perfect body, I want you to notice when i m not arround", ImagePath="hotdog2", Available= true, PrepTime = 3,
						Ingredients = new List<string>()
						{
							"Creep", "weirdo"
						},
						Price = 8, IsFavourite = true
					},
					new HotDog()
					{
						HotDogId = 6, Name ="Dusk", ShortDescription="what are the chance", Descritpion ="I had a dream turning to nightmare and tell me what are the chance I have, All my friend remind me that I live in Sci fi", ImagePath="hotdog6", Available= true, PrepTime = 4,
						Ingredients = new List<string>()
						{
							"Rain", "Break love","out of chance"
						},
						Price = 10, IsFavourite = true
					}

				}
			},
			new HotDogGroup()
			{
				HotDogGroupId = 2, Title = "Veggie", ImagePath = "", HotDogs = new List<HotDog>()
				{
					new HotDog()
					{
						HotDogId = 3, Name ="NightWish", ShortDescription="Opera Phantom", Descritpion ="One of the best classic tune on hard rock style", ImagePath="hotdog3", Available= true, PrepTime =8,
						Ingredients = new List<string>()
						{
							"Crystal", "devil", "hell feast"
						},
						Price = 8, IsFavourite = false
					},
					new HotDog()
					{
						HotDogId = 4, Name ="Kovacs", ShortDescription="My Love", Descritpion ="I have to prey, like a charm I will make you addict", ImagePath="hotdog4", Available= true, PrepTime = 3,
						Ingredients = new List<string>()
						{
							"black", "dust", "ashes"
						},
						Price = 6, IsFavourite = false
					},
				}
			},
			new HotDogGroup()
			{
				HotDogGroupId = 3, Title = "desire", ImagePath = "", HotDogs = new List<HotDog>()
				{
					new HotDog()
					{
						HotDogId = 5, Name ="Whithin", ShortDescription="Ice queen", Descritpion ="I m comming, just comming, don't you see it, you better believe", ImagePath="hotdog5", Available= true, PrepTime =2,
						Ingredients = new List<string>()
						{
							"Ice", "raging", "queen"
						},
						Price = 10, IsFavourite = false
					},
					new HotDog()
					{
						HotDogId = 7, Name ="Dabrowska", ShortDescription="Sound of silence", Descritpion ="hello darknest my old friend, I have came to talk with you again ", ImagePath="hotdog7", Available= true, PrepTime = 5,
						Ingredients = new List<string>()
						{
							"pray", "sound", "silence"
						},
						Price = 4, IsFavourite = true
					},
				}
			},
		};


		public List<HotDog> GetAllHotDogs()
		{
			IEnumerable<HotDog> hotDogs = from hotDogGroup in hotDogGroups
										  from hotDog in hotDogGroup.HotDogs
										  select hotDog;

			return hotDogs.ToList<HotDog>();
		}

		public HotDog GetHotDogById(int hotDogId)
		{
			IEnumerable<HotDog> hotDogs = from hotDogGroup in hotDogGroups
										  from hotDog in hotDogGroup.HotDogs
										  where hotDog.HotDogId == hotDogId
										  select hotDog;

			return hotDogs.FirstOrDefault<HotDog>();

		}

		public List<HotDogGroup> GetGroupedHotDogs()
		{
			return hotDogGroups;
		}

		public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
		{
			IEnumerable<HotDog> mData = from hotDogGroup in hotDogGroups
										where hotDogGroup.HotDogGroupId == hotDogGroupId
										from hotDog in hotDogGroup.HotDogs
										select hotDog;

			return mData.ToList<HotDog>();
		}

		public List<HotDog> GetFavoriteHotDogs()
		{
			IEnumerable<HotDog> mData = from hotDogGroup in hotDogGroups
										from hotDog in hotDogGroup.HotDogs
										where hotDog.IsFavourite == true
										select hotDog;

			return mData.ToList<HotDog>();
		}
	
	}
}

