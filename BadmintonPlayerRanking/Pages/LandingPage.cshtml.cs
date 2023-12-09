using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BadmintonPlayerRanking.Data;
using BadmintonPlayerRankingLibrary.Data;


namespace BadmintonPlayerRanking.Pages
{
    public class LandingPageModel : PageModel
    {
        private readonly ISqlData _db;
        public LandingPageModel(ISqlData db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }
    }
}
