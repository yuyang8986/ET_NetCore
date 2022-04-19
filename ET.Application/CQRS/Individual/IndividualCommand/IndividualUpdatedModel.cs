namespace ET.Application.CQRS.Individual.IndividualCommand
{
    public class IndividualUpdatedModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Changed { get; set; } = true;
    }
}
