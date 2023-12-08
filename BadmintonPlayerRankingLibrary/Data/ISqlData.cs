using BadmintonPlayerRankingLibrary.Models;

namespace BadmintonPlayerRankingLibrary.Data
{
    public interface ISqlData
    {
        Task DeletePlayer(int id);
        Task<PlayerModel?> GetPlayer(int id);
        Task<IEnumerable<PlayerModel>> GetPlayers();
        void InsertPlayer(PlayerModel player);
        void UpdatePlayer(PlayerModel player);
    }
}