using BadmintonPlayerRankingLibrary.Data;
using BadmintonPlayerRankingLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace BadmintonPlayerRanking.Pages
{
    public partial class UpdatePlayer
    {
        private const int PageSize = 100;
        private List<PlayerModel> playersList { get; set; }
        private List<PlayerModel> displayedPlayers { get; set; }

        private int selectedPlayerId;
        private PlayerModel newPlayer { get; set; }

        private int currentPage = 1;

        private PlayerModel editingPlayer;

        private int totalPages => (int)Math.Ceiling((double)playersList.Count / PageSize);

        [Inject]
        private ISqlData _db { get; set; }

        protected override void OnInitialized()
        {
            playersList = _db.GetAllPlayers();
            newPlayer = new PlayerModel();
            UpdateDisplayedPlayers();
        }

        private void UpdateDisplayedPlayers()
        {
            int startIndex = (currentPage - 1) * PageSize;
            displayedPlayers = playersList.Skip(startIndex).Take(PageSize).ToList();
        }

        private async Task ChangePage(int page)
        {
            currentPage = page;
            UpdateDisplayedPlayers();
        }

        private void RefreshPlayerList()
        {
            playersList = _db.GetAllPlayers();
        }

        private void UpdateCurrentPlayer(PlayerModel player)
        {
            _db.UpdatePlayer(player);
            RefreshPlayerList();
        }

        private void CancelAction()
        {
            selectedPlayerId = 0;
        }

        private void StartEditing(PlayerModel player)
        {
            editingPlayer = new PlayerModel
            {
                Id = player.Id,
                FirstName = player.FirstName,
                LastName = player.LastName,
                Club = player.Club,
                Gender = player.Gender,
                AgeGroup = player.AgeGroup,
                YearOfBirth = player.YearOfBirth
            };
        }

        private void SaveChanges()
        {
            _db.UpdatePlayer(editingPlayer);
            editingPlayer = null;
            RefreshPlayerList();
            UpdateDisplayedPlayers();
        }

        private void CancelEditing()
        {
            editingPlayer = null;
            UpdateDisplayedPlayers();
        }
    }
}

