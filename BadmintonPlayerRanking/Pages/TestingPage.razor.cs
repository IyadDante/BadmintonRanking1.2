using BadmintonPlayerRankingLibrary.Models;
using Microsoft.AspNetCore.Components;
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

        protected override void OnInitialized()
        {
            playersList = _db.GetAllPlayers();
            newPlayer = new PlayerModel();
            selectedPlayer = new PlayerModel(); // Initialize selectedPlayer
        }

        private void ShowEditModal(PlayerModel player)
        {
            selectedPlayer = player;
            showForm = true;
            Console.WriteLine("ShowEditModal called");
        }

        private void SavePlayer()
        {
            // Implement logic to save the edited player
            _db.UpdatePlayer(selectedPlayer);

            // Reset selectedPlayer and hide the form
            selectedPlayer = null;
            showForm = false;

            // Refresh the player list
            playersList = _db.GetAllPlayers();
        }

        private void CancelForm()
        {
            selectedPlayer = null;
            showForm = false;
        }

        private async Task CreatePlayer()
        {
            _db.InsertPlayer(newPlayer);
            newPlayer = new PlayerModel();
        }
    }
}
