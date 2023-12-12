using BadmintonPlayerRankingLibrary.Data;
using BadmintonPlayerRankingLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace BadmintonPlayerRanking.Pages
{
    public partial class CreatePlayer
    {
        [Inject]
        private ISqlData _db { get; set; }
        private PlayerModel newPlayer { get; set; }

        protected override void OnInitialized()
        {
            newPlayer = new PlayerModel();
        }


        private void CreateNewPlayer()
        {
            _db.InsertPlayer(newPlayer);
        }
    }
}
