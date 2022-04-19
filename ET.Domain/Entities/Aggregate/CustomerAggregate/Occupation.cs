using System.Collections.Generic;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.CustomerAggregate
{
    public class Occupation
    {
        public Occupation()
        {
            Individuals = new HashSet<Individual>();
        }
        public int OccupationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public ICollection<Individual> Individuals { get; private set; }  //individual to occupation : 1 to 0...1, individual can has no occupation

        public OccupationCategory OccupationCategory { get; set; }
        public int OccupationCategoryId { get; set; }//must haves
    }
}
