namespace ToolBox.Domain.Entities
{
    public record Tag
    {
        public int Id { get; init; }
        public string Name { get; init;  }

        public Tag(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}   