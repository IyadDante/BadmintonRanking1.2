using BadmintonPlayerRankingLibrary.Models;

namespace BadmintonPlayerRankingLibrary.Data
{
    public interface ISqlData
    {
        void DeleteClub(int id);
        void DeletePlayer(int id);
        ClubModel? GetClub(int id);
        List<ClubModel> GetClubs();
        PlayerModel GetPlayer(int id);
        List<PlayerModel> GetPlayers();
        void InsertClub(ClubModel club);
        void InsertPlayer(PlayerModel player);
        void UpdateClub(ClubModel club);
        void UpdatePlayer(PlayerModel player);
    }
}