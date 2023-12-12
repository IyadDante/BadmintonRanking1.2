using BadmintonPlayerRankingLibrary.Data;
using BadmintonPlayerRankingLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace BadmintonPlayerRanking.Pages
{
    public partial class PlayerRanking
    {
        private const int PageSize = 100;
        private List<PlayersRankingModel> PlayersRankingList { get; set; }
        private List<PlayersRankingModel> DisplayedPlayersRanking { get; set; }

        private int selectedPlayerRankingId;
        private PlayersRankingModel newPlayerRanking { get; set; }
        private int currentPage = 1;
        private PlayersRankingModel editingPlayerRanking;
        private int totalPages => (int)Math.Ceiling((double)PlayersRankingList.Count / PageSize);

        [Inject]
        private ISqlData _db { get; set; }

        protected override void OnInitialized()
        {
            PlayersRankingList = _db.GetAllPlayersRanking();
            newPlayerRanking = new PlayersRankingModel();
            UpdateDisplayedPlayersRanking();
        }

        private void UpdateDisplayedPlayersRanking()
        {
            int startIndex = (currentPage - 1) * PageSize;
            DisplayedPlayersRanking = PlayersRankingList.Skip(startIndex).Take(PageSize).ToList();
        }

        private async Task ChangePage(int page)
        {
            currentPage = page;
            UpdateDisplayedPlayersRanking();
        }

        private void RefreshPlayerRankingList()
        {
            PlayersRankingList = _db.GetAllPlayersRanking();
        }

        private void UpdateCurrentPlayerRanking(PlayersRankingModel playerRanking)
        {
            _db.UpdatePlayersRanking(playerRanking);
            RefreshPlayerRankingList();
        }

        private void CancelAction()
        {
            selectedPlayerRankingId = 0;
        }

        private void StartEditing(PlayersRankingModel playerRanking)
        {
            editingPlayerRanking = new PlayersRankingModel
            {
                Id = playerRanking.Id,
                PlayerID = playerRanking.PlayerID,
                SinglesPoints = playerRanking.SinglesPoints,
                SinglesRanking = playerRanking.SinglesRanking,
                DoublesPoints = playerRanking.DoublesPoints,
                DoublesRanking = playerRanking.DoublesRanking,
                MixedPoints = playerRanking.MixedPoints,
                MixedRanking = playerRanking.MixedRanking,
                OverallPoints = playerRanking.OverallPoints,
                OverallRanking = playerRanking.OverallRanking
            };
        }

        private void SaveChanges()
        {
            _db.UpdatePlayersRanking(editingPlayerRanking);
            editingPlayerRanking = null;
            RefreshPlayerRankingList();
            UpdateDisplayedPlayersRanking();
        }

        private void CancelEditing()
        {
            editingPlayerRanking = null;
            UpdateDisplayedPlayersRanking();
        }
    }
}
