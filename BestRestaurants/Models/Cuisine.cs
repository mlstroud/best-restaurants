using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public int CuisineId { get; set; }
    public string Name { get; set; }
    public virtual ICollection Restaurants { get; set; }

    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }
  }
}