namespace HospitalSystem.Domain.Entities
{
    public class Carousel : Entity<int>
    {
        public required string ImageSrc { get; set; }
        public required string ImageAlt { get; set; }
    }
}