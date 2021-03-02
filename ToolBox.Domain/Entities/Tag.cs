namespace ToolBox.Domain.Entities
{
    public record Tag
    {
        public int Id { get; }
        public int Name { get; }

        public Tag(int id, int name)
        {
            Id = id;
            Name = name;
        }
    }
}