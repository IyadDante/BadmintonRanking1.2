using BadmintonPlayerRankingLibrary.Data;
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

        [Inject]
        private ISqlData _db { get; set; }

        private int currentPage = 1;
        private int itemsPerPage = 10; // You can change this based on your requirements

        private IEnumerable<PlayerModel> DisplayedPlayers =>
            playersList.Skip((currentPage - 1) * itemsPerPage).Take(itemsPerPage);

        private int totalPages => (int)Math.Ceiling((double)playersList.Count / itemsPerPage);

        private void ChangePage(int page)
        {
            currentPage = page;
            StateHasChanged();
        }

        protected override void OnInitialized()
        {
            playersList = _db.GetAllPlayers();
            newPlayer = new PlayerModel();
            selectedPlayer = new PlayerModel(); // Initialize selectedPlayer
        }

        private void RefreshPlayerList()
        {
            playersList = _db.GetAllPlayers();
        }

        private async Task CreatePlayer()
        {
            _db.InsertPlayer(newPlayer);
            newPlayer = new PlayerModel();
            RefreshPlayerList();
        }

        private void UpdatePlayer()
        {
            _db.UpdatePlayer(selectedPlayer);
            selectedPlayer = null;
            showForm = false;
            RefreshPlayerList();
        }

        private async Task DeletePlayer(int id)
        {
            _db.DeletePlayer(id);
            RefreshPlayerList();
        }

        private void ShowEditModal(PlayerModel player)
        {
            selectedPlayer = player;
            showForm = true;
        }

        
    }
}
