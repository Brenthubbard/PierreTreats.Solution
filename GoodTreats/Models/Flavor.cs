using System.Collections.Generic;

namespace GoodTreats.Models
{
  public class Flavor
  {
    public Flavor()

    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<TreatFlavor> JoinEntities { get; }
  }
}