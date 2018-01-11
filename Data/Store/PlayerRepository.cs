using Store;
using System.Collections.Generic;
using System.Linq;

namespace Data.Store
{
    public interface IRepository
    {
        List<Player> GetAllPlayers();

        // This is code for Test5 
        void AddPlayer(Player player);
    }

    public class PlayerRepository : IRepository
    {
        // This is code for Test5 
        public void AddPlayer(Player player)
        {
            DOSDataContext context = new DOSDataContext();
            context.Players.InsertOnSubmit(player);
            context.SubmitChanges();
        }

        public List<Player> GetAllPlayers()
        {
            DOSDataContext context = new DOSDataContext();

            return (from p in context.Players                        
                        select p).ToList<Player>();
        }
    }
}
