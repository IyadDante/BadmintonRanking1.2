using BadmintonPlayerRankingLibrary.Data;
using BadmintonPlayerRankingLibrary.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BadmintonPlayerRanking.Pages
{
    public partial class TestingPage
    {
        private List<PlayerModel> playersList { get; set; }

        private bool showForm = false;
        private PlayerModel selectedPlayer { get; set; }
        public PlayerModel newPlayer { get; set; }

        [Inject]
        private ISqlData _db { get; set; }

        protected override void OnInitialized()
        {
            playersList = _db.GetAllPlayers();
            newPlayer = new PlayerModel();
            selectedPlayer = new PlayerModel(); // Initialize selectedPlayer
        }

        private void UpdatePlayer()
        {
            // Implement logic to Update the edited player
            _db.UpdatePlayer(selectedPlayer);

            // Reset selectedPlayer and hide the form
            selectedPlayer = null;
            showForm = false;

            // Refresh the player list
            playersList = _db.GetAllPlayers();

        }

        private async Task CreatePlayer()
        {
            _db.InsertPlayer(newPlayer);
            newPlayer = new PlayerModel();
        }

        private async Task DeletePlayer(int id)
        {
            _db.DeletePlayer(id);
        }

        private void ShowEditModal(PlayerModel player)
        {
            selectedPlayer = player;
            showForm = true;
            // Show the modal when a row is double-clicked
            //JSRuntime.InvokeVoidAsync("ShowModal", "playerModal");
        }
    }
}
