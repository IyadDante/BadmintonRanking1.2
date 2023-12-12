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

        // This is the CRUD Operations for the ********* Player Table

        public void DeletePlayer(int id)
        {
            _db.SaveData(sqlStatement: "spPlayer_DeleteByID", new { Id = id });
        }

        public List<PlayerModel> GetAllPlayers()
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
            _db.SaveData(sqlStatement: "spPlayer_Insert", new
            { player.FirstName, player.LastName, player.Club, player.Gender, player.AgeGroup, player.YearOfBirth });
        }

        public void UpdatePlayer(PlayerModel player)
        {
            _db.SaveData(sqlStatement: "spPlayer_UpdateByID", new
            { player.Id, player.FirstName, player.LastName, player.Club, player.Gender, player.AgeGroup, player.YearOfBirth });
        }


        // This is the CRUD Operations for the ********* Club Table

        public void DeleteClub(int id)
        {
            _db.SaveData(sqlStatement: "spClub_DeleteByID", new { Id = id });
        }

        public List<ClubModel> GetAllClubs()
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
            _db.SaveData(sqlStatement: "spClub_Insert", new { club.clubName, club.Description });
        }

        public void UpdateClub(ClubModel club)
        {
            _db.SaveData(sqlStatement: "spClub_UpdateByID", club);
        }

        // This is the CRUD Operations for the ********* Players Ranking Table

        public void DeletePlayersRanking(int id)
        {
            _db.SaveData(sqlStatement: "spPlayersRanking_DeleteByID", new { Id = id });
        }

        public List<PlayersRankingModel> GetAllPlayersRanking()
        {
            var output = _db.LoadData<PlayersRankingModel, dynamic>(sqlStatement: "spPlayersRanking_GetAll", new { });
            return output;
        }

        public PlayersRankingModel? GetPlayerRanking(int id)
        {
            var output = _db.LoadData<PlayersRankingModel, dynamic>(sqlStatement: "spPlayersRanking_GetPlayersRankingByID", new { Id = id });
            return output.First();
        }

        public void InsertPlayersRanking(PlayersRankingModel PlayersRanking)
        {
            _db.SaveData(sqlStatement: "spPlayersRanking_Insert", new
            {
                PlayersRanking.PlayerID,
                PlayersRanking.SinglesPoints,
                PlayersRanking.SinglesRanking,
                PlayersRanking.DoublesPoints,
                PlayersRanking.DoublesRanking,
                PlayersRanking.MixedPoints,
                PlayersRanking.MixedRanking,
                PlayersRanking.OverallPoints,
                PlayersRanking.OverallRanking
            });
        }

        public void UpdatePlayersRanking(PlayersRankingModel PlayersRanking)
        {
            _db.SaveData(sqlStatement: "spPlayersRanking_UpdateByID", new
            {
                PlayersRanking.Id,
                PlayersRanking.PlayerID,
                PlayersRanking.SinglesPoints,
                PlayersRanking.SinglesRanking,
                PlayersRanking.DoublesPoints,
                PlayersRanking.DoublesRanking,
                PlayersRanking.MixedPoints,
                PlayersRanking.MixedRanking,
                PlayersRanking.OverallPoints,
                PlayersRanking.OverallRanking
            });
        }
        // This is the Retuned Data for the ********* Tournament Table

        public void DeleteTournament(int id)
        {
            _db.SaveData(sqlStatement: "spTournament_DeleteByID", new { Id = id });
        }

        public List<TournamentModel> GetAllTournaments()
        {
            var output = _db.LoadData<TournamentModel, dynamic>(sqlStatement: "spTournament_GetAll", new { });
            return output;
        }

        public TournamentModel? GetTournament(int id)
        {
            var output = _db.LoadData<TournamentModel, dynamic>(sqlStatement: "spTournament_GetTournamentByID", new { Id = id });
            return output.First();
        }

        public void InsertTournament(TournamentModel Tournament)
        {
            _db.SaveData(sqlStatement: "spTournament_Insert", new { Tournament.TournamentName, Tournament.TournamentDate, Tournament.Description });
        }

        public void UpdateTournament(TournamentModel Tournament)
        {
            _db.SaveData(sqlStatement: "spTournament_UpdateByID", Tournament);
        }

        // This is the Retuned Data for the ********* LookUp Table

        public PlayerModel GetPlayerLookUpData(int id, string TableName)
        {
            var output = _db.LoadData<PlayerModel, dynamic>(sqlStatement: "spLookUp_GetData", new { Id = id, TableName });
            return output.First();
        }
    }
}
