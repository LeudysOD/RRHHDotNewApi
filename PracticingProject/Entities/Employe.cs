namespace PracticingProject.Entities
{
    public class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Position { get; set; }
        public bool IsDeleted { get; set; }
    }
}
