namespace TreehouseDefense {
  class Invader {
    private readonly Path path;
    private int pathStep = 0;
    
    public MapLocation Location => path.getLocationAt(pathStep);
    public int Health {get; set;} = 2;
    public bool HasScored {get {return pathStep >= path.Length;}}
    public bool IsNeutralized => Health <= 0;
    public bool IsActive => !(IsNeutralized || HasScored);
    
    public Invader(Path path) {
      this.path = path;
    }
    
    public void Move() => pathStep +=1;
    
    public void DecreaseHealth(int factor) {
      Health -= factor;
    }
  }
}