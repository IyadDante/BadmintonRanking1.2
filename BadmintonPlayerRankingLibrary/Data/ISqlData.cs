using BadmintonPlayerRankingLibrary.Models;

namespace BadmintonPlayerRankingLibrary.Data
{
    public interface ISqlData
    {
        void DeleteClub(int id);
        void DeletePlayer(int id);
        void DeletePlayersRanking(int id);
        List<ClubModel> GetAllClubs();
        List<PlayerModel> GetAllPlayers();
        List<PlayersRankingModel> GetAllPlayersRanking();
        ClubModel? GetClub(int id);
        PlayerModel GetPlayer(int id);
        void InsertClub(ClubModel club);
        void InsertPlayer(PlayerModel player);
        void InsertPlayersRanking(PlayersRankingModel PlayersRanking);
        PlayersRankingModel? PlayersRanking(int id);
        void UpdateClub(ClubModel club);
        void UpdatePlayer(PlayerModel player);
        void UpdatePlayersRanking(PlayersRankingModel PlayersRanking);
    }
}