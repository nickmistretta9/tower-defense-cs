using System;
namespace TreehouseDefense {
  class Tower {
		private const int _range = 1;
		private const int _power = 1;
		private const double _accuracy = 0.75;
		private static readonly Random _random = new Random();
		
		private readonly MapLocation location;
		public Tower(MapLocation location) {
			this.location = location;
		}
		
		public bool IsSuccessfulShot() {
			return _random.NextDouble() < _accuracy;
		}
		
		public void FireOnInvaders(Invader[] invaders) {
			foreach(Invader invader in invaders) {
				if(invader.IsActive && location.InRangeOf(invader.Location, _range)) {
					if(IsSuccessfulShot()) {
						invader.DecreaseHealth(_power);
						Console.WriteLine("Shot at and hit an invader");
						if(invader.IsNeutralized) {
							Console.WriteLine("Neutralized an invader");
						}
					} else {
						Console.WriteLine("Shot at and missed an invader");
					}
					break;
				}
			}
		}
  }
}