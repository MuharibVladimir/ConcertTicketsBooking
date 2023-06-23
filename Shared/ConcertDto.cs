namespace Shared
{
    public record ConcertDto
    {
        public int Id { get; init; }
        public string? Name { get; init; }
        public DateTime? Date { get; init; }
        public int TicketsNumber { get; set; }
        public string? Artist { get; set; }
        public string? Place { get; init; }
    }
}