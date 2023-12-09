using BadmintonPlayerRankingLibrary.Models;
using DataAccess.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonPlayerRankingLibrary.Data
{
    public class SqlData : ISqlData
    {
        private readonly ISqlDataAccess _db;
        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }
        // This is the CRUD Operations for the Player Table
        public Task<IEnumerable<PlayerModel>> GetPlayers()
        {
            var output = _db.LoadData<PlayerModel, dynamic>(storedProcedure: "spPlayers_GetAll", new { });
            return output;
        }

        public async Task<PlayerModel?> GetPlayer(int id)
        {
            var output = await _db.LoadData<PlayerModel, dynamic>(storedProcedure: "spPlayers_GetPlayerByID", new { Id = id });
            return (PlayerModel?)output;
        }

        public void InsertPlayer(PlayerModel player)
        {
            var output = _db.SaveData(storedProcedure: "spPlayer_Insert", new { player.FirstName, player.LastName });
        }

        public void UpdatePlayer(PlayerModel player)
        {
            var output = _db.SaveData(storedProcedure: "spPlayer_UpdateByID", player);
        }

        public Task DeletePlayer(int id)
        {
            var output = _db.SaveData(storedProcedure: "spPlayer_DeleteByID", new { Id = id });
            return Task.CompletedTask;
        }

        // This is the CRUD Operations for the Club Table
        public Task<IEnumerable<ClubModel>> GetClubs()
        {
            var output = _db.LoadData<ClubModel, dynamic>(storedProcedure: "spClub_GetAll", new { });
            return output;
        }

        public async Task<ClubModel?> GetClub(int id)
        {
            var output = await _db.LoadData<PlayerModel, dynamic>(storedProcedure: "spClub_GetClubByID", new { Id = id });
            return (ClubModel?)output;
        }

        public void InsertClub(ClubModel club)
        {
            var output = _db.SaveData(storedProcedure: "spClub_Insert", new { club.clubName });
        }

        public void UpdateClub(ClubModel club)
        {
            var output = _db.SaveData(storedProcedure: "spClub_UpdateByID", club);
        }

        public Task DeleteClub(int id)
        {
            var output = _db.SaveData(storedProcedure: "spClub_DeleteByID", new { Id = id });
            return Task.CompletedTask;
        }
    }
}
