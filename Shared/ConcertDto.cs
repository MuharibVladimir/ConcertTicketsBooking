namespace Shared
{
    public record ConcertDto
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public DateTime? Date { get; init; }
        public string? Place { get; init; }
    }
}