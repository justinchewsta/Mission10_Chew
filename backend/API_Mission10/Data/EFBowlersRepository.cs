
namespace API_Mission10.Data
{
    public class EFBowlersRepository : IBowlersRepository
    {
        private BowlersContext _bowlersContext;
        public EFBowlersRepository(BowlersContext temp) { 
            _bowlersContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlersContext.Bowlers;
        public IEnumerable<Team> Teams => _bowlersContext.Teams;
    }
}
