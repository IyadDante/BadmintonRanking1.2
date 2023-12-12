using BadmintonPlayerRankingLibrary.Models;

namespace BadmintonPlayerRankingLibrary.Data
{
    public interface ISqlData
    {
        void DeleteClub(int id);
        void DeletePlayer(int id);
        void DeletePlayersRanking(int id);
        void DeleteTournament(int id);
        List<ClubModel> GetAllClubs();
        List<PlayerModel> GetAllPlayers();
        List<PlayersRankingModel> GetAllPlayersRanking();
        List<TournamentModel> GetAllTournaments();
        ClubModel? GetClub(int id);
        PlayerModel GetPlayer(int id);
        PlayerModel GetPlayerLookUpData(int id, string TableName);
        PlayersRankingModel? GetPlayerRanking(int id);
        TournamentModel? GetTournament(int id);
        void InsertClub(ClubModel club);
        void InsertPlayer(PlayerModel player);
        void InsertPlayersRanking(PlayersRankingModel PlayersRanking);
        void InsertTournament(TournamentModel Tournament);
        void UpdateClub(ClubModel club);
        void UpdatePlayer(PlayerModel player);
        void UpdatePlayersRanking(PlayersRankingModel PlayersRanking);
        void UpdateTournament(TournamentModel Tournament);
    }
}