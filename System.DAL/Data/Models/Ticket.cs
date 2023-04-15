

namespace System.DAL
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string Title { get; set; }

        public int departmentId { get; set; }

        public Department department { get; set; }

        public ICollection<Developer> Developers { get; set; } = new HashSet<Developer>();

    }
}
