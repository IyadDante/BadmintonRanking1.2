// AdminPage.razor.cs
using BadmintonPlayerRankingLibrary.Data;
using BadmintonPlayerRankingLibrary.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BadmintonPlayerRanking.Pages
{
    public partial class AdminPage
    {
        private List<PlayerModel> playersList { get; set; }
        private int selectedPlayerId;
        private bool showConfirmationModal = false;
        private PlayerModel newPlayer { get; set; }

        [Inject]
        private ISqlData _db { get; set; }

        protected override void OnInitialized()
        {
            playersList = _db.GetAllPlayers();
            newPlayer = new PlayerModel(); // Ensure newPlayer is initialized
        }

        private void EditPlayer(PlayerModel player)
        {
            // Implement logic to handle edit action
            // You can navigate to the edit page or show a modal
            // For example, you can use NavigationManager.NavigateTo("/EditPlayer/" + player.Id);
            _db.UpdatePlayer(player);
        }

        private void ShowConfirmationModal(PlayerModel player)
        {
            // Set selectedPlayerId or take any necessary action based on the player
            selectedPlayerId = player.Id;

            // Show the confirmation modal
            showConfirmationModal = true;
        }

        private void ConfirmAction()
        {
            // Implement logic to perform the selected action (Edit/Delete) based on selectedPlayerId
            // After the action, reset selectedPlayerId and close the confirmation modal
            selectedPlayerId = 0;
            showConfirmationModal = false;
            playersList = _db.GetAllPlayers(); // Refresh the player list
        }

        private void CancelAction()
        {
            // Reset selectedPlayerId and close the confirmation modal
            selectedPlayerId = 0;
            showConfirmationModal = false;
        }

        private async Task CreatePlayer()
        {
            // Implement the logic to navigate to the create player page or show a modal
            _db.InsertPlayer(newPlayer);
            // Optionally, you can clear the form after submission
            newPlayer = new PlayerModel();
        }
    }
}
