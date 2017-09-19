namespace TreehouseDefense {
	class SniperTower : Tower {
		
		protected override double Accuracy {get;} = 1;
		protected override int Range {get;} = 2;
		
		public SniperTower(MapLocation location) : base(location) {
		}
	}
}