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
        public List<PlayerModel> GetPlayers()
        {
            var output = _db.LoadData<PlayerModel, dynamic>(sqlStatement: "spPlayers_GetAll", new { });
            return output;
        }

        public PlayerModel GetPlayer(int id)
        {
            var output = _db.LoadData<PlayerModel, dynamic>(sqlStatement: "spPlayers_GetPlayerByID", new { Id = id });
            return output.First();
        }

        public void InsertPlayer(PlayerModel player)
        {
            _db.SaveData(sqlStatement: "spPlayer_Insert", new { player.FirstName, player.LastName });
        }

        public void UpdatePlayer(PlayerModel player)
        {
            _db.SaveData(sqlStatement: "spPlayer_UpdateByID", player);
        }

        public void DeletePlayer(int id)
        {
            _db.SaveData(sqlStatement: "spPlayer_DeleteByID", new { Id = id });
        }

        // This is the CRUD Operations for the Club Table
        public List<ClubModel> GetClubs()
        {
            var output = _db.LoadData<ClubModel, dynamic>(sqlStatement: "spClub_GetAll", new { });
            return output;
        }

        public ClubModel? GetClub(int id)
        {
            var output = _db.LoadData<ClubModel, dynamic>(sqlStatement: "spClub_GetClubByID", new { Id = id });
            return output.First();
        }

        public void InsertClub(ClubModel club)
        {
            _db.SaveData(sqlStatement: "spClub_Insert", new { club.clubName });
        }

        public void UpdateClub(ClubModel club)
        {
            _db.SaveData(sqlStatement: "spClub_UpdateByID", club);
        }

        public void DeleteClub(int id)
        {
            _db.SaveData(sqlStatement: "spClub_DeleteByID", new { Id = id });
        }
    }
}
