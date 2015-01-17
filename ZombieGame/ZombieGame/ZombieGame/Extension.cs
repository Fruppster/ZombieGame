using System;


namespace ZombieGame
{
	class Extension
	{
		static readonly Random Rand = new Random();

		public static int Random(int _min, int _max)
		{
			return Rand.Next(_min, _max + 1);
		}

		public static int Random(int _max)
		{
			return Rand.Next(_max + 1);
		}
	}
}
