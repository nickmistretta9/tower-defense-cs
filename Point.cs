using System;
namespace TreehouseDefense {
  class Point {
    public readonly int x;
    public readonly int y;
    
    public Point(int x, int y) {
      this.x = x;
      this.y = y;
    }
    
    public int distanceTo(int x, int y) {
      return (int) Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
    }
    
    public int distanceTo(Point point) {
      return distanceTo(point.x, point.y);
    }
  }
}