using System;
using System.Collections.Generic;

namespace Test6.Game
{
    public class Game : IGame
    {
        public List<Player> GetAllPlayers()
        {
            Data.Store.PlayerRepository repository = new Data.Store.PlayerRepository();

            List<Store.Player> storeDto = repository.GetAllPlayers();

            List<Test6.Game.Player> businesDto = new List<Test6.Game.Player>();

            // map to business layer. 
            // Probably use a Mapping library for this
            foreach(Store.Player p in storeDto)
            {
                Test6.Game.Player tempPlayer = new Test6.Game.Player()
                {
                    Age = p.Age,
                    Country = p.Country,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Username = p.Username
                };

                businesDto.Add(tempPlayer);
            }

            return businesDto;
        }
    }
}