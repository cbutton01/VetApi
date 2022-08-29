namespace VetApi.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public PetOwner Owner { get; set; }
    }
}
