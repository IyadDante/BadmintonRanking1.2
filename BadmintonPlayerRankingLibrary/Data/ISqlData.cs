using BadmintonPlayerRankingLibrary.Models;

namespace BadmintonPlayerRankingLibrary.Data
{
    public interface ISqlData
    {
        Task DeleteClub(int id);
        Task DeletePlayer(int id);
        Task<ClubModel?> GetClub(int id);
        Task<IEnumerable<ClubModel>> GetClubs();
        Task<PlayerModel?> GetPlayer(int id);
        Task<IEnumerable<PlayerModel>> GetPlayers();
        void InsertClub(ClubModel club);
        void InsertPlayer(PlayerModel player);
        void UpdateClub(ClubModel club);
        void UpdatePlayer(PlayerModel player);
    }
}