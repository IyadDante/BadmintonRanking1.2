using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Data
{
    public class SqlData
    {
        private readonly ISqlDataAccess _db;

        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<PlayerModel>> GetPlayers()
        {
            _db.LoadData<PlayerModel, dynamic>(storedProcedure: "spPlayers_GetAll", new { });
        }

        public async Task<PlayerModel?> GetPlayers(int id)
        {
            var results = await _db.LoadData<PlayerModel, dynamic>(storedProcedure: "spPlayers_GetAll",
            new { Id = id });
        }

        public async Task<PlayerModel?> GetPlayer(int id)
        {
            var results = await _db.LoadData<PlayerModel, dynamic>(storedProcedure: "spPlayers_GetPlayerByID",
            new { Id = id });
            return results.FirstOrDefault();
        }

        public async Task InsertPlayer(PlayerModel player)
        {
            _db.SaveData(storedProcedure: "spPlayer_Insert", new { player.FirstName, player.LastName });
        }

        public async Task UpdatePlayer(PlayerModel player)
        {
            _db.SaveData(storedProcedure: "spPlayer_UpdateByID", player);
        }

        public async Task DeletePlayer(int id)
        {
            _db.SaveData(storedProcedure: "spPlayer_DeleteByID", new { Id = id });
        }



    }
}
