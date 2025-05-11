namespace WebApplication2.Models.Domain
{
    public class Walk
    {
        public Guid Id
        {
            get;
            set;
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public double Length { get; set; }
        public string? WalkImageUrl { get; set; }

        public Guid DifficultyId
        {
            get;
            set;
        }
        public Guid RegionId { get; set; }


        //Navigation Properity 
        public Difficuilty Difficuilty { get; set; }
        public Region Region { get; set; }
    }
}
