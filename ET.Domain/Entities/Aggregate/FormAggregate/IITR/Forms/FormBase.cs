namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms
{
    public abstract class FormBase
    {
        protected FormBase() { }

        protected FormBase(bool isReviewed)
        {
            IsReviewed = isReviewed;
        }
        public int Id { get; set; }
        protected bool IsReviewed { get; set; }
    }
}
