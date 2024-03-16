namespace API_Mission10.Data
{
    public interface IBowlersRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
    }
}
