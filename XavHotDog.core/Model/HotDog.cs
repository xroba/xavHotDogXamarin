﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XavHotDog.core
{
	public class HotDog
	{
		public int HotDogId { get; set; }
		public string Name { get; set; }

		public string ShortDescription { get; set; }

		public string Descritpion { get; set; }

		public string ImagePath { get; set; }

		public int Price { get; set; }

		public bool Available { get; set; }

		public int PrepTime { get; set; }

		public List<string> Ingredients { get; set; }

		public bool IsFavourite { get; set; }

		public string GroupName { get; set; }
	}
}

