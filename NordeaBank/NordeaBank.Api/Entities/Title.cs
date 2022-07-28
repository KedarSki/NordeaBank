namespace NordeaBank.Api.Entities
{
    public class Title
    {
        public int Id { get; set; }
        public int Worker_Ref_Id { get; set; }
        public string Worker_Title { get; set; }
        public DateTime Affected_From { get; set; }

    }
}
