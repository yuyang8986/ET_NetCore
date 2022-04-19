namespace ET.Domain.Entities.Aggregate.FormAggregate
{
    //TODO to be added to DB, in design, this table is to save previous prefilled info from ato to save loading time from loading ato api again
    public class Prefill
    {
        public int Id { get; set; }

        // 1 to 1
        //public MainForm MainForm { get; set; } 
    }
}
