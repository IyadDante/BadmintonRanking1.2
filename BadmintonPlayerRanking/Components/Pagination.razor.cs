using Microsoft.AspNetCore.Components;

namespace BadmintonPlayerRanking.Components
{
    partial class Pagination
    {
        [Parameter] public int CurrentPage { get; set; }
        [Parameter] public int TotalPages { get; set; }
        [Parameter] public Action<int> OnPageChange { get; set; }

        private bool IsFirstPage => CurrentPage == 1;
        private bool IsLastPage => CurrentPage == TotalPages;

        private void ChangePage(int page)
        {
            if (page >= 1 && page <= TotalPages)
            {
                OnPageChange?.Invoke(page);
            }
        }
    }
}
